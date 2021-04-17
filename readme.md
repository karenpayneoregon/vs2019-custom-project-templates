# Information

A repository for base projects for .NET 5, C#9 which can be exported as templates and used from Visual Studio `start window`.

Several projects require NuGet packages which can be fixed by running [NuGet restore packages](https://docs.microsoft.com/en-us/nuget/consume-packages/package-restore).

:bulb: Pin the ones used often in the `start window`

- Templates are place in the following folder. To share, give the .zip file to another developer and they drop the file in their Export folder.
- For the developer who is given the zip file, they should have Visual Studio close.
- For the developer who exported the template, the template is immediately available. Suggest pinning the project template to the projection selection in the start window,

C:\Users\\**UserName**\\Documents\Visual Studio 2019\My Exported Templates

# Included templates

| Project  |  Description  |
| :---         |  :---  |
| BaseNetCoreClassProject  | .NET Core 5 using C#9   |
| BaseNetCoreSqlClientClassProject  | .NET Core 5 using C#9  with SqlClient |
| BaseNetCoreOracleProviderClassProject  | .NET Core 5 using C#9  with Oracle |
| BaseNetCoreConfigurationHelper  | .NET Core 5 using C#9  appsettings.json helpers |
| PayneUnitTestProject  | .NET Core 5 using C#9  base unit test setup |
| ShouldlyUnitTestProject | .NET Core 5 using C#9  base unit test setup|
|| Using [Shouldly library](https://github.com/shouldly/shouldly/tree/master/documentation) |
| BaseNetCoreAppConfigProject | .NET Core 5 C#9 base class project for appconfig |
| BaseNetCoreFormsProject | .NET Core 5 C#9 base forms project |
| BaseNetCoreWpfAppProject | .NET Core 5 C#9 base wpf project |
| BaseNetCoreConsoleProject | .NET Core 5 C#9 base console project |
| BaseNetCoreClassNewtonsoftProject | .NET Core 5 C#9 class project for json.net |
| BaseValidationLibrary | .NET Core 5 C#9 class project for [data annotations](https://docs.microsoft.com/en-us/aspnet/mvc/overview/older-versions-1/models-data/validation-with-the-data-annotation-validators-cs) |

</br>

<table>
	<tr>
		<td>&mdash;<strong>Note</strong>&mdash;</br>Each project template in many cases may have more than needed such as a readme file. If not needed simply remove these files</td>
	</tr>
</table>

</br>



![image](assets/core_csharp_shield.png)

