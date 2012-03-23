# T4 Configuration ReadMe #

T4Configuration is a T4 (text template) file that lives in Visual Studio 2010 and automatically creates a static class with properties from your configuration (*.config) file.

Best way to install is through [Nuget.Org](http://nuget.org/packages/T4Configuration "http://nuget.org/packages/T4Configuration"):

**Install-Package T4Configuration**

Changelog 26/07/2011:

- Taken out dependency to T4Toolbox

- Updated Nuget package

After installation it should run automatically, if you need to regenerate the class just right click and select "run custom tool".

To use in your application you should just have to type:

`Config.appSetting`

`Config.connectionString`

It will also be in your root namespace.