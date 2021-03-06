# Custom Visual Studio 2019 project templates

# About

A repository for base projects for .NET 5, C#9 which can be exported as templates and used from Visual Studio `start window`.

Several projects require NuGet packages which can be fixed by running [NuGet restore packages](https://docs.microsoft.com/en-us/nuget/consume-packages/package-restore).

:bulb: Pin the ones used often in the `start window`

- Templates are place in the following folder. To share, give the .zip file to another developer and they drop the file in their Export folder.
- For the developer who is given the zip file, they should have Visual Studio close.
- For the developer who exported the template, the template is immediately available. Suggest pinning the project template to the projection selection in the start window,

C:\Users\\**UserName**\\Documents\Visual Studio 2019\My Exported Templates

# Copy local to remote

The [following repository](https://github.com/karenpayneoregon/class-utilities/tree/Changes1) contains a utility useful for copying templates to a developer machine

![img](assets/TemplateUtility.png)


# Included templates

| Project  |  Description  |
| :---         |  :---  |
| BaseNetCoreClassProject  | .NET Core 5 using C#9   |
| BaseNetCoreSqlClientClassProject  | .NET Core 5 using C#9  with SqlClient |
| BaseNetCoreOracleProviderClassProject  | .NET Core 5 using C#9  with Oracle |
| BaseNetCoreConfigurationHelper  | .NET Core 5 using C#9  appsettings.json helpers |
| BaseNorthWindCoreLibrary  | Starter project for EF Core 5 - NorthWind database |
| PayneUnitTestProject  | .NET Core 5 using C#9  base unit test setup |
| ShouldlyUnitTestProject | .NET Core 5 using C#9  base unit test setup|
|| Using [Shouldly library](https://github.com/shouldly/shouldly/tree/master/documentation) |
| BaseNetCoreAppConfigProject | .NET Core 5 C#9 base class project for appconfig |
| BaseNetCoreFormsProject | .NET Core 5 C#9 base forms project |
|  BaseWindowsFormsClassic| .NET 4.8 C# base forms project |
| BaseNetCoreWpfAppProject | .NET Core 5 C#9 base wpf project |
| BaseNetCoreConsoleProject | .NET Core 5 C#9 base console project |
| BaseNetCoreClassNewtonsoftProject | .NET Core 5 C#9 class project for json.net |
| BaseValidationLibrary | .NET Core 5 C#9 class project for [data annotations](https://docs.microsoft.com/en-us/aspnet/mvc/overview/older-versions-1/models-data/validation-with-the-data-annotation-validators-cs) |
| BaseNetCoreFileHelpers | .NET Core 5 C#9 class project for file operations **work in progress** |
| BaseNetCoreImagesProject | .NET Core 5 C#9 class project for image conversions  |

</br>

<table>
	<tr>
		<td>&mdash;<strong>Note</strong>&mdash;</br>Each project template in many cases may have more than needed such as a readme file. If not needed simply remove these files</td>
	</tr>
</table>

</br>

### See also

- [Add tags to project templates](https://docs.microsoft.com/en-us/visualstudio/ide/template-tags?view=vs-2019)
- [.NET Boxed Project](https://github.com/Dotnet-Boxed/Templates) templates with batteries included, providing the minimum amount of code required to get you going.
- [Application templates](https://github.com/thangchung/awesome-dotnet-core#application-templates)

![image](assets/core_csharp_shield.png)

