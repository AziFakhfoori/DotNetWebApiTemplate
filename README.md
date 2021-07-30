# Bunnings Web Api Templates for .Net 5

## Features

## Installing the templates

```
dotnet new -i Bunnings.Templates.WebApi.1.x.x.nupkg
```

### Verify template is installed

```
dotnet new --list

Templates                                    Short Name              Language    Tags
-------------------------------------------  ----------------------  ----------  --------------------------------------
Bunnings WebApi Application                      Bunnings-webapi             [C#]        Bunnings/WebApi
Bunnings WebApi Command                          Bunnings-webapicommand      [C#]        Bunnings/WebApi/Command
Bunnings WebApi Controller                       Bunnings-webapicontroller   [C#]        Bunnings/WebApi/Controller
Bunnings WebApi Query                            Bunnings-webapiquery        [C#]        Bunnings/WebApi/Query
```

## Create a new Web Api

```
dotnet new Bunnings-webapi --name MyProjectName
```

```
cd .\MyProjectName
cd .\src
```

### Add a controller

```
.\AddController.ps1 MyControllerName
```

### Add a command feature

```
.\AddFeatureCommand.ps1 MyCommandFeatureName
```

### Add a query feature

```
.\AddFeatureQuery.ps1 MyQueryFeatureName
```

## Running the Web Api

-

## Uninstalling the template

```
dotnet new -u
```

```
  Bunnings.Templates.WebApi
    Details:
      NuGetPackageId: Bunnings.Templates.WebApi
      Version: 1.0.0
      Author: Me
    Templates:
      Bunnings WebApi Controller (Bunnings-webapicontroller) C#
      Bunnings WebApi Command (Bunnings-webapicommand) C#
      Bunnings WebApi Query (Bunnings-webapiquery) C#
      Bunnings WebApi Application (Bunnings-webapi) C#
    Uninstall Command:
      dotnet new -u Bunnings.Templates.WebApi
```

```
dotnet new -u Bunnings.Templates.WebApi
```