This example shows how to integrate Ninject into a WebAPI 2 application.

Required Packages
Ninject
Ninject.MVC 5
Ninject.Web.WebApi

Relevant Files
App_Start\NinjectWebCommon.cs
	RegisterServices modified to load modules from executing assembly and other non references assemblies.

Controllers\ValueController.cs
	Uses DI to access functionality in this assembly and functionality in plugin assembly

Models\ModelsModule.cs
	Bind types in Models namespace

Example.Module.ExampleModule
	Bind types in the Example.Module namespace