# UmbracoNineDemoSite
Demo site build in Umbraco v.9.0.0-beta004 and .NET Core 5.0.

## About this solution
This is a demo site for Umbraco v9 build in the new .NET Core version. 
It is built as an experiment/investigation and should not be used as a template for your next Umbraco site.
Use it as a reference if you will and steal whatever you like and ignore the things you dont.

This is not **the way** of building Umbraco sites, it's **a way**. 
This site is build in the way that I like to build my Umbraco sites, which could be called a very "backend way" or "MVC way". 
- Every page is rendered through a RenderController.
- **TODO**: Every block *(Blocklist vs. Nested Content?)* is rendered through a ViewComponent.
- Every view uses strongly typed View Models *(inheriting from ContentModel)*.
- **TODO**: Page components that handles Umbraco logic are rendered through ViewComponents.
- Non-logic components are rendered through Partial views.
- Custom services are registered in the IUmbracoBuilder through an IUserComposer.
- **TODO**: Forms are submitted through a SurfaceController.
- **TODO**: Searching is submitted and handled through a controller and Examine.
- **TODO**: Unit Testing all the things!

### Login:
This site uses an embeded SQLCE database to avoid having to restore and keep updating a restore script.
To login to the Umbraco backoffice use these credentials:
- Username: admin@admin.com
- Password: adminadmin