# ADTokenGenerator
This is a helper application to generate Active Directory Authentication Layer JWT tokens to use when authenticating to services requiring tokens in the Bearer header.

## Usage
The tool takes four parameters `authority`, `clientId`, `clientSecret` and `resourceId`.

`authority` will most likely be your Azure tenant endpoint, something like `https://login.microsoftonline.com/<tenant id>`. `clientId` is the application id of the application registration you've set up in your active directory. The `clientSecret` is a secret you've created for this application. Finally the `resourceId` is the application id of the application in the AD you wish to generate a token for.

Example:
```
ADTokenGenerator.exe https://login.microsoftonline.com/fd1ce6e3-fd2a-4742-9589-24a18910cef7 bfb112fa-5b5c-47c0-87da-b2090ce4847d ZmVpNDMyajNqMzIxa2ZkczthZndsZTtqdnJpb3cgYWlqIHdhXWVyIGFwW1wgO8OhXCA7W2Eg https://yourdomain.com/4AEC0149-9DB1-448A-96A5-E7EF8DD5B46A
```

## Building/running
The tool is written in .Net Core 2.1 so it can be run using the `dotnet run` in both Windows and MacOS.

```
$ dotnet run <authority> <clientId> <clientSecret> <resourceId>
```
