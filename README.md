# ARP_Tools

![Revit API](https://img.shields.io/badge/Revit%20API-2020-blue.svg)
![Platform](https://img.shields.io/badge/platform-Windows-lightgray.svg)
![.NET](https://img.shields.io/badge/.NET-4.7-blue.svg)

**Author:** [Angel Ruiz-Peinado Sanchez](https://www.linkedin.com/in/angelruizpeinado/)   [<img src="https://github.com/angelrps/MasterDataScience_FinalProject/blob/master/img/linkedin-icon.jpg" width="25" height="25" title="Github Logo">](https://www.linkedin.com/in/angelruizpeinado/)

## Description
This repository is a C# .NET Revit add-in project that works with Revit 2018, 2019 and 2020.<br>
It is a collection of custom tools programmed to help out with drawing production, modeling and model management.<br>
Currently these are the tools included in the ribbon:
- List them.

### Folder estructure
`./2020`: Here you can find all the IExternalCommands stored in different folders. Each IExternalCommand has its own manifest ```.addin``` file and could be installed and used separately.

## Installation
### Full ARP_Tools Ribbon
To install the whole set of tools within a new ribbon just copy the ```.bundle``` folder in this destination:

```%ProgramData%\Autodesk\Revit\Addins\2020```
### Each tool separately 
You can install any tool like any other Revit add-in,
by [copying the add-in manifest and the assembly DLL to the Revit Add-Ins folder](http://help.autodesk.com/view/RVT/2019/ENU/?guid=Revit_API_Revit_API_Developers_Guide_Introduction_Add_In_Integration_Add_in_Registration_html).

If you specify the full DLL pathname in the add-in manifest, it can also be located elsewhere.

They will appear under the Add-Ins Tab > External Tools

## Usage
Detailed information about the usage in the wiki page.

## Credits

Many thanks to [PyRevit](https://github.com/eirannejad/pyRevit) for let us access his code. Also many thanks to CASE Apps for freeing up their code and [John Pierson](https://github.com/johnpierson/case-apps) for hosting the source code. I have used both frecuently as a starting point and adapted it to my needs. 

Thanks to [icons8.com](https://icons8.com) and [thenounproject.com](https://thenounproject.com/) for most of the icons.
