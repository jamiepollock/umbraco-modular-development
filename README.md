# Modular Development demo for Umbraco v7

This is a demo repo which is here to support an article I did for the 24 Days In Umbraco project 2016.

## Build

 - [Visual Studio 2015 Community Edition](https://www.visualstudio.com/vs/community/)
 - [.NET 4.5.2](https://www.microsoft.com/en-us/download/details.aspx?id=42643)
 - [Umbraco CMS v7.5.4](https://www.nuget.org/packages/UmbracoCms/7.5.4)
 - [Ditto v0.10.0](https://www.nuget.org/packages/Our.Umbraco.Ditto/0.10.0)
 - [Nested Content v0.3.0](https://www.nuget.org/packages/Our.Umbraco.NestedContent/0.3.0)
 - [Doc Type Grid Editor v0.3.0](https://www.nuget.org/packages/Our.Umbraco.DocTypeGridEditor/0.3.0)

### Installation

Running the solution in Visual Studio 2015 (or higher) should restore all the nuget packages and there's a post build which xcopys the demo content Database and Media files. This demo comes with a SQL Server CE database which is preinstalled with Umbraco and the necessary content, media, data types to work through.

### Running the demo

This project was built to run with IIS Express built into Visual Studio but with some configuration it could also run on a local or hosted IIS server.

### User credentials

To access the demo Umbraco CMS access use the following credentials:

**Username:** admin@admin.com  
**Password:** password

## Feedback 

Leave me a message [on Twitter](https://twitter.com/jamiepollock) or [leave an issue](https://github.com/jamiepollock/umbraco-modular-development/issues/new) if you have a problem, be sure to check [existing issues](https://github.com/jamiepollock/umbraco-modular-development/issues) first though!