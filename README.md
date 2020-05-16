<img src="https://github.com/angelrps/ARP_Toolkit/blob/master/img/ARP_Toolkit_Ribbon.PNG">

# ARP_Toolkit

![Revit API](https://img.shields.io/badge/Revit%20API-2020-blue.svg)
![Platform](https://img.shields.io/badge/platform-Windows-lightgray.svg)
![.NET](https://img.shields.io/badge/.NET-4.7-blue.svg)

This repository is a C# .NET Revit add-in project that works with Autodesk Revit 2018, 2019 and 2020.<br>
It is a collection of custom tools programmed to help out with drawing production, modeling and model management.<br>
The collection is composed of the following tools:
- **Flip Walls and Doors** ([documentation](https://angelruizpeinado.gitbook.io/arp-toolkit/tools/flip-walls-or-doors)/[code](https://github.com/angelrps/ARP_Toolkit/tree/master/2020/Flip/VS_Flip))
- **Room Centroid, Tag to Room** ([documentation](https://angelruizpeinado.gitbook.io/arp-toolkit/tools/room-centroid-tag-to-toom)/[code](https://github.com/angelrps/ARP_Toolkit/tree/master/2020/RoomInsertionPoints/VS_RoomInsertionPoints))
- **Remove Empty Elevation Tags** ([documentation](https://angelruizpeinado.gitbook.io/arp-toolkit/tools/remove-empty-elevation-tags)/[code](https://github.com/angelrps/ARP_Toolkit/tree/master/2020/RemoveEmptyElevationTags/VS_RemoveEmptyElevationTags))
- **Assign View Templates** ([documentation](https://angelruizpeinado.gitbook.io/arp-toolkit/tools/assign-view-templates)/[code](https://github.com/angelrps/ARP_Toolkit/tree/master/2020/AssignViewTemplates/VS_AssignViewTemplates))
- **Transfer View Filters** ([documentation](https://angelruizpeinado.gitbook.io/arp-toolkit/tools/transfer-view-filters)/[code](https://github.com/angelrps/ARP_Toolkit/tree/master/2020/TransferViewFilters/VS_TransferViewFilters))
- **Reassign Detail Number** ([documentation](https://angelruizpeinado.gitbook.io/arp-toolkit/tools/reassign-detail-number)/[code](https://github.com/angelrps/ARP_Toolkit/tree/master/2020/ReassignDetailNumbers/VS_ReassignDetailNumbers))
- **Sheet Duplicator** ([documentation](https://angelruizpeinado.gitbook.io/arp-toolkit/tools/sheet-duplicator)/[code](https://github.com/angelrps/ARP_Toolkit/tree/master/2020/SheetDuplicator/VS_SheetDuplicator))
- **Create Print Set** ([documentation](https://angelruizpeinado.gitbook.io/arp-toolkit/tools/create-print-set)/[code](https://github.com/angelrps/ARP_Toolkit/tree/master/2020/CreatePrintSet/VS_CreatePrintSet))
- **Schedule to Excel** ([documentation](https://angelruizpeinado.gitbook.io/arp-toolkit/tools/schedule-to-excel)/[code](https://github.com/angelrps/ARP_Toolkit/tree/master/2020/ScheduleToExcel/VS_ScheduleToExcel))
- **Purge Filters** ([documentation](https://angelruizpeinado.gitbook.io/arp-toolkit/tools/purge-filters)/[code](https://github.com/angelrps/ARP_Toolkit/tree/master/2020/TransferViewFilters/VS_TransferViewFilters))
- **Purge Text** ([documentation](https://angelruizpeinado.gitbook.io/arp-toolkit/tools/purge-text)/[code](https://github.com/angelrps/ARP_Toolkit/tree/master/2020/DeleteUnusedTextNoteTypes/VS_DeleteUnusedTextNoteTypes))
- **Purge Dim Styles** ([documentation](https://angelruizpeinado.gitbook.io/arp-toolkit/tools/purge-dim-styles)/[code](https://github.com/angelrps/ARP_Toolkit/tree/master/2020/PurgeDimStyles/VS_PurgeDimStyles))
- **Parameter Mapper** ([documentation](https://angelruizpeinado.gitbook.io/arp-toolkit/tools/parameter-mapper)/[code](https://github.com/angelrps/ARP_Toolkit/tree/master/2020/ParameterMapper/VS_ParameterMapper))
- **Parameter Loader** ([documentation](https://angelruizpeinado.gitbook.io/arp-toolkit/tools/parameter-loader)/[code](https://github.com/angelrps/ARP_Toolkit/tree/master/2020/ParameterLoader/VS_ParameterLoader))
- **Transfer Worksets** ([documentation](https://angelruizpeinado.gitbook.io/arp-toolkit/tools/transfer-worksets)/[code](https://github.com/angelrps/ARP_Toolkit/tree/master/2020/TransferWorksets/VS_TransferWorksets))
- **Transfer View Templates** ([documentation](https://angelruizpeinado.gitbook.io/arp-toolkit/tools/transfer-view-templates)/[code](https://github.com/angelrps/ARP_Toolkit/tree/master/2020/TransferViewTemplates/VS_TransferViewTemplate))
- **Import CAD Popup Message** ([documentation](https://angelruizpeinado.gitbook.io/arp-toolkit/tools/import-cad-popup-message)/[code](https://github.com/angelrps/ARP_Toolkit/tree/master/ArpRibbon.2020/VS_ArpRibbon.2020/Entry))
- **In-Place Component Popup Message** ([documentation](https://angelruizpeinado.gitbook.io/arp-toolkit/tools/create-model-in-place-popup-message)/[code](https://github.com/angelrps/ARP_Toolkit/tree/master/ArpRibbon.2020/VS_ArpRibbon.2020/Entry))

## Installation
These instructions will get you a copy of the project up and running on your local machine.

### Prerequisites
Revit 2018-2020.

### Install full ARP Toolkit Ribbon
- Download the repository and browse to the ```Deploy``` folder.
- Copy the ```ArpRibbon.bundle``` folder and paste it into this destination:
```%ProgramData%\Autodesk\ApplicationPlugins```
- If the ```\ApplicationPlugins``` folder does not exists, create it.
- Open Revit. If you see this message click 'Always Load'.
<img src="https://github.com/angelrps/ARP_Toolkit/blob/master/img/UnssignedAddinPrompt.PNG">

### Install each tool separately 
If you just want to install a couple of tools you can do it by copying the ```.addin``` manifest file and the assembly ```.dll``` to the Revit Add-Ins folder and they will appear under the *Add-Ins Tab > External Tools*.
<img src="https://github.com/angelrps/ARP_Toolkit/blob/master/img/AddinsTab.PNG">

Both ```.addin``` and ```.dll``` files can be found in this route ```..\bin\x64\Debug``` inside each project location.

You can use any of these addins folders:

User Addins:<br>
```%AppData%\Autodesk\Revit\Addins\2020``` (or whatever your Revit version is).

Machine Addins (for all users of the machine):<br>
```%ProgramData%\Autodesk\Revit\Addins\2020``` (or whatever your Revit version is).

If you open the add-in manifest and specify the full DLL pathname, it can also be located elsewhere.

More information about Add-In Registration can be found [here](http://help.autodesk.com/view/RVT/2019/ENU/?guid=Revit_API_Revit_API_Developers_Guide_Introduction_Add_In_Integration_Add_in_Registration_html).

## Documentation
Detailed information about how to use each tool can be found in this [gitbook](https://angelruizpeinado.gitbook.io/arp-toolkit/).

## Author
[Angel Ruiz-Peinado Sanchez](https://www.linkedin.com/in/angelruizpeinado/)   [<img src="https://github.com/angelrps/MasterDataScience_FinalProject/blob/master/img/linkedin-icon.jpg" width="25" height="25" title="Linkedin Logo">](https://www.linkedin.com/in/angelruizpeinado/)

## Acknowledgements

Credit to Luis + Vidal Architects as I was employed there when working on it.

Many thanks to [PyRevit](https://github.com/eirannejad/pyRevit) for letting us access his code. Also many thanks to CASE Apps for freeing up their code and [John Pierson](https://github.com/johnpierson/case-apps) for hosting the source code. I have used both frecuently as a starting point and adapted it to my needs. 

Thanks to [icons8.com](https://icons8.com) and [thenounproject.com](https://thenounproject.com/) for most of the icons. I have used them as a base and tweaked them to fit my style.
