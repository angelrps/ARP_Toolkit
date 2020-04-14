using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;
using Autodesk.Revit.DB;
using Autodesk.Revit.UI;
using Autodesk.Revit.DB.Architecture;
using System.IO;
using Autodesk.Revit.ApplicationServices;

namespace Data
{
    class Helpers
    {       
        public static List<Room> GetModelRooms (Document doc)
        {
            List<Room> modelRooms = new List<Room>();

            ElementClassFilter classFilter = new ElementClassFilter(typeof(SpatialElement));

            IEnumerable<SpatialElement> seRooms = new FilteredElementCollector(doc)
                                            .OfCategory(BuiltInCategory.OST_Rooms)
                                            .WherePasses(classFilter)
                                            .Cast<SpatialElement>()
                                            .Where(se => se.Location != null);

            foreach (SpatialElement se in seRooms)
            {
                try
                {
                    Room r = se as Room;
                    if (r != null)
                    {
                        modelRooms.Add(r);
                    }
                }
                catch (Exception)
                {
                    continue;
                }
            }
            return modelRooms;
        }

        public static List<Room> GetModelRoomsActView(Document doc)
        {
            List<Room> modelRooms = new List<Room>();

            ElementClassFilter classFilter = new ElementClassFilter(typeof(SpatialElement));

            IEnumerable<SpatialElement> seRooms = new FilteredElementCollector(doc, doc.ActiveView.Id)
                                            .OfCategory(BuiltInCategory.OST_Rooms)
                                            .WherePasses(classFilter)
                                            .Cast<SpatialElement>()
                                            .Where(se => se.Location != null);

            foreach (SpatialElement se in seRooms)
            {
                try
                {
                    Room r = se as Room;
                    if (r != null)
                    {
                        modelRooms.Add(r);
                    }
                }
                catch (Exception)
                {
                    continue;
                }
            }
            return modelRooms;
        }

        public static List<RoomTag> GetModelRoomTags (Document doc)
        {
            List<RoomTag> roomTagList = new List<RoomTag>();

            IEnumerable<SpatialElementTag> seTags = new FilteredElementCollector(doc)
                                                .OfClass(typeof(SpatialElementTag))
                                                .Cast<SpatialElementTag>()
                                                .Where(t => !t.IsTaggingLink);
            foreach (SpatialElementTag set in seTags)
            {
                try
                {
                    RoomTag rt = set as RoomTag;
                    if (rt != null)
                    {
                        roomTagList.Add(rt);
                    }                    
                }
                catch (Exception)
                {
                    continue;
                }
            }
            return roomTagList;
        }

        public static List<RoomTag> GetModelRoomTagsActView(Document doc)
        {
            List<RoomTag> roomTagList = new List<RoomTag>();

            IEnumerable<SpatialElementTag> seTagsActView = new FilteredElementCollector(doc, doc.ActiveView.Id)
                                                .OfClass(typeof(SpatialElementTag))
                                                .Cast<SpatialElementTag>()
                                                .Where(t => !t.IsTaggingLink);
            foreach (SpatialElementTag set in seTagsActView)
            {
                try
                {
                    RoomTag rt = set as RoomTag;
                    if (rt != null)
                    {
                        roomTagList.Add(rt);
                    }
                }
                catch (Exception)
                {
                    continue;
                }
            }
            return roomTagList;
        }

        public static List<RoomTag> GetLinkRoomTags(Document doc)
        {
            List<RoomTag> roomTagList = new List<RoomTag>();

            IEnumerable<SpatialElementTag> seTags = new FilteredElementCollector(doc)
                                                .OfClass(typeof(SpatialElementTag))
                                                .Cast<SpatialElementTag>()
                                                .Where(t => t.IsTaggingLink && !t.IsOrphaned);

            foreach (SpatialElementTag set in seTags)
            {
                try
                {
                    RoomTag rt = set as RoomTag;
                    if (rt != null)
                    {
                        roomTagList.Add(rt);
                    }                    
                }
                catch (Exception)
                {
                    continue;
                }
            }
            return roomTagList;
        }

        public static void MoveRoomToCentroid(Document doc, List<Room> modelRooms)
        {
            SpatialElementGeometryCalculator geomCalculator = new SpatialElementGeometryCalculator(doc);
            bool NotEnclosedRooms = false;  //declare variable to detect Not Enclosed rooms

            foreach (Room r in modelRooms)
            {
                if (r.Area == 0) //are there not enclosed rooms?
                {
                    NotEnclosedRooms = true;
                    continue;
                }
                if (r.Area > 0) //hadle exception for Not Enclosed rooms when trying to calculate SpatialElementGeometry
                {
                    Location rLoc = r.Location;
                    LocationPoint currentLoc = (LocationPoint)r.Location;
                    XYZ currentLocPoint = currentLoc.Point;

                    SpatialElementGeometryResults geomResults = geomCalculator.CalculateSpatialElementGeometry(r);
                    Solid roomSolid = geomResults.GetGeometry();
                    XYZ roomCentroid = roomSolid.ComputeCentroid();

                    XYZ moveVector = new XYZ(roomCentroid.X - currentLocPoint.X, roomCentroid.Y - currentLocPoint.Y, roomCentroid.Z - currentLocPoint.Z);

                    // don´t move if centroid is outside of a room
                    if (r.IsPointInRoom(roomCentroid))
                    {
                        rLoc.Move(moveVector);
                    }
                }   
            }

            if (NotEnclosedRooms == true)   //warn the user about not enclosed rooms
            {
                TaskDialog tdNotEnclosedRooms = new TaskDialog("Warning!")
                {
                    MainIcon = TaskDialogIcon.TaskDialogIconWarning,
                    MainInstruction = "There are Not Enclosed rooms in this project." + "\n"
                                    + "They have been ignore." + "\n"
                                    + "We strongly recommend you to revise them and amend as appropriate.",
                    TitleAutoPrefix = false
                };
                TaskDialogResult tdInfoResult = tdNotEnclosedRooms.Show();
            }
        }

        public static void MoveModelTags(Document doc, List<RoomTag> rTagList)
        {
            bool NotEnclosedRooms = false;  //declare variable to detect Not Enclosed rooms

            foreach (RoomTag rt in rTagList)
            {                
                if (rt.Room.Area == 0) //are there not enclosed rooms?
                {
                    NotEnclosedRooms = true;
                    continue;
                }
                if (rt.Room.Area > 0) //proceed only with enclosed rooms
                {
                    Location tLoc = rt.Location;

                    // get room location
                    LocationPoint rLoc = rt.Room.Location as LocationPoint;
                    XYZ rPoint = rLoc.Point;

                    // get tag location
                    LocationPoint tagLoc = (LocationPoint)rt.Location;
                    XYZ tagPoint = tagLoc.Point;

                    XYZ moveVector = new XYZ(rPoint.X - tagPoint.X, rPoint.Y - tagPoint.Y, rPoint.Z - tagPoint.Z);

                    tLoc.Move(moveVector);
                }                
            }
            if (NotEnclosedRooms == true)   //warn the user about not enclosed rooms
            {
                TaskDialog tdNotEnclosedRooms = new TaskDialog("Warning!")
                {
                    MainIcon = TaskDialogIcon.TaskDialogIconWarning,
                    MainInstruction = "There are Not Enclosed rooms in this project." +"\n"
                                    + "They have been ignore." + "\n"
                                    + "We strongly recommend you to revise them and amend as appropriate.",
                    TitleAutoPrefix = false
                };
                TaskDialogResult tdInfoResult = tdNotEnclosedRooms.Show();
            }
        }

        public static void MoveLinkTags (Document doc, RoomTag rt)
        {
            ElementClassFilter classFilter = new ElementClassFilter(typeof(SpatialElement));
            ElementId roomId = rt.TaggedRoomId.LinkedElementId;

            //get link document
            ElementId rvtLinkId = rt.TaggedRoomId.LinkInstanceId;
            RevitLinkInstance rvtLink = new FilteredElementCollector(doc)
                                        .OfClass(typeof(RevitLinkInstance))
                                        .Cast<RevitLinkInstance>()
                                        .Where(rv => rv.Id == rvtLinkId)
                                        .FirstOrDefault();
            Document link_doc = rvtLink.GetLinkDocument();

            // get room from linked document
            SpatialElement linkedSE = new FilteredElementCollector(link_doc)
                                        .OfCategory(BuiltInCategory.OST_Rooms)
                                        .WherePasses(classFilter)
                                        .Cast<SpatialElement>()
                                        .Where(se => se.Id == roomId)
                                        .FirstOrDefault();
            Room linkedRoom = linkedSE as Room;

            // tag location
            Location tLoc = rt.Location;
            LocationPoint tagLoc = (LocationPoint)rt.Location;
            XYZ tagPoint = tagLoc.Point;

            // room location
            LocationPoint rLoc = linkedRoom.Location as LocationPoint;
            XYZ rPoint = rLoc.Point;

            // create "move vector" and move tag
            XYZ moveVector = new XYZ(rPoint.X - tagPoint.X, rPoint.Y - tagPoint.Y, rPoint.Z - rPoint.Z);

            tLoc.Move(moveVector);            
        }

    }
}
