# About

Provides read/write methods to app.config


![img](assets/Versions.png)

![img](assets/core_csharp_shield.png)

# ApplicationSettings class

|Method | Description   |
| :---         |  :---  |
|GetSettingAsString(string configKey)| Get app setting as string from application file|
|GetSettingAsInt(string configKey)|Get app setting as int from application file|
|SetValue(string key, string value)| Set value by key|
|Reload| Refresh appSettings|
|Fetch| Start fresh reading settings|

## Examples
```csharp
ApplicationSettings.SetValue("LinesToSplit",50);
ApplicationSettings.GetSettingAsInt("LinesToSplit");
```

### Sample setting
```xml
<?xml version="1.0" encoding="utf-8" ?>
<configuration>    
  <appSettings>
    <add key="LinesToSplit" value="1000" />
  </appSettings>
</configuration>
```


# Exceptions class

Write exception details to unhandledException.txt in application folder


|Method | Description   |
| :---         |  :---  |
|Write| Write Exception information to UnhandledException.txt in the executable folder.|
|ToLogString| Provides full stack trace for the exception that occurred.|

## Example

```csharp
catch (Exception e)
{
    Exceptions.Write(e);
}
```

