using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Autodesk.Revit.DB;
using Autodesk.Revit.UI;
using System.Windows.Forms;
using System.IO;
using System.Reflection;

namespace Data
{
    class Helpers
    {
        // get all categories in the project
        public static List<Category> GetCategories (Document doc)
        {
            List<Category> categoriesList = new List<Category>();

            foreach (Category cat in doc.Settings.Categories)
            {
                categoriesList.Add(cat);
            }

            return categoriesList;
        }

        // get elements of selected category
        public static List<Element> GetInstances(Document doc, Category cat)
        {
            List<Element> catInstances = new List<Element>();

            IEnumerable<Element>  catCol = new FilteredElementCollector(doc)
                .WhereElementIsNotElementType()
                .OfCategoryId(cat.Id)
                .Cast<Element>();

            foreach (Element e in catCol)
            {
                if (e.GroupId.IntegerValue < 1)
                {
                    catInstances.Add(e);
                }
            }

            return catInstances;
        }

        // get parameters of selected category
        public static List<Parameter> GetSourceParameters(List<Element> catInstances)
        {
            List<Parameter> allCatParameters = new List<Parameter>();
            List<ElementId> allCatParamIds = new List<ElementId>();

            // get all category instances
            foreach (Element e in catInstances)
            {
                // get all instance parameters
                foreach (Parameter p in e.Parameters)
                {
                    if (!allCatParamIds.Contains(p.Id))
                    {
                        allCatParamIds.Add(p.Id);
                        allCatParameters.Add(p);
                    }                                     
                }

            }
            //allCatParameters = allCatParameters.Distinct().ToList();
            //allCatParameters.Sort();
            return allCatParameters;
        }

        // get parameter values as string
        public static String GetParamValueAsString (Parameter param)
        {
            string valueString = "";

            if (param.StorageType == StorageType.String)
            {
                valueString = param.AsString();
            }
            else
            {
                valueString = param.AsValueString();
            }
            return valueString;
        }

        // get parameter values as double
        public static Double GetParamValueAsDouble (Parameter param)
        {
            double valueDouble = 0;
            double newValueDouble = 0;

            if (param.StorageType == StorageType.Double)
            {
                valueDouble = param.AsDouble();
                newValueDouble = UnitUtils.ConvertFromInternalUnits(valueDouble, param.DisplayUnitType);
            }
            return newValueDouble;
        }

        // get target parameters compatible with selected source parameter
        public static List<Parameter> GetTargetParameters(Document doc, Category cat, Parameter sourceParam)
        {
            List<Parameter> targetParameters = new List<Parameter>();
            List<ElementId> targetParamIds = new List<ElementId>();
            //List<string> textParameters = new List<string>();

            foreach (Parameter p in GetSourceParameters(GetInstances(doc, cat))) // get all parameters for each instance of category
            {
                // filter out not eligible parameters
                if (p.IsReadOnly == false
                    && p.StorageType != StorageType.ElementId
                    && p.StorageType != StorageType.None
                    && p.Definition.ParameterType != ParameterType.Invalid
                    && p.Definition.ParameterGroup != BuiltInParameterGroup.INVALID
                    && p.Definition.ParameterType != ParameterType.YesNo
                    && p.Id != sourceParam.Id
                    && !targetParamIds.Contains(p.Id))
                {
                    // filter only Double parameters
                    if (sourceParam.StorageType == StorageType.Double && sourceParam.StorageType == p.StorageType)
                    {
                        if (sourceParam.Definition.ParameterType == ParameterType.Length
                            && p.Definition.ParameterType == ParameterType.Length)
                        {
                            targetParamIds.Add(p.Id);
                            targetParameters.Add(p);
                            continue;
                        }
                        if (sourceParam.Definition.ParameterType == ParameterType.Area
                            && p.Definition.ParameterType == ParameterType.Area)
                        {
                            targetParamIds.Add(p.Id);
                            targetParameters.Add(p);
                            continue;
                        }
                        if (sourceParam.Definition.ParameterType == ParameterType.Volume
                            && p.Definition.ParameterType == ParameterType.Volume)
                        {
                            targetParamIds.Add(p.Id);
                            targetParameters.Add(p);
                            continue;
                        }
                    }
                    // filter String, ElementId or Integer parameters
                    else if (sourceParam.StorageType == StorageType.String || sourceParam.StorageType == StorageType.ElementId || sourceParam.StorageType == StorageType.Integer)
                    {
                        if (p.StorageType == StorageType.String)
                        {
                            targetParamIds.Add(p.Id);
                            targetParameters.Add(p);
                            continue;
                        }                        
                    }
                }
            }
            return targetParameters;
        }

        // get only text target parameters
        public static List<Parameter> GetTargetTextParameters (Document doc, Category cat)
        {
            List<Parameter> targetTextParameters = new List<Parameter>();
            List<ElementId> targetTextParamIds = new List<ElementId>();

            foreach (Parameter p in GetSourceParameters(GetInstances(doc, cat)))
            {
                // filter out not eligible parameters
                if (p.IsReadOnly == false
                    && p.StorageType == StorageType.String
                    && !targetTextParamIds.Contains(p.Id))
                {
                    targetTextParamIds.Add(p.Id);
                    targetTextParameters.Add(p);
                    continue;
                }
            }
            return targetTextParameters;
        }

    }
}
