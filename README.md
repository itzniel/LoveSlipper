# LoveSlipper

*At 2023-02-14 1638 Created my Web App, experienced difficulty in downloading the 
the right Visual studio code.

* At 1804 Added a contoller Added an interface with the IActionResult so the it can return the layout when /slipper is added to the wen address 
@1816 took a break!
@ 2023-02-15 1630 resumed :corrected previous error which was having my home index page in the shared folder in views , did this by creating an home folder
and moving the index and privacy layout into the home folder created
The error was a result of me using a wrong controller to call the home layout
@1645 Added a slipper view for my project and created an index page
@1650 using the site.js i was able to set an automatic date that would display current date 
@1745 Made a model class called "slipper.cs" and it properties which were name, category, material, color, release date and customer rating
because of the date type had to the namespace "using System.ComponentModel.DataAnnotations;".
@ 2023-02-17 928 Resumed building the project, create a database context class for the slipper model
@934 registered the Database by adding "options.UseSqlServer(Configuration.GetConnectionString("MvcMovieContext")));" in the startup.cs 
@952 Examined the database connection string to the appsettings.json 
@1013 Scaffolded the slipper pages by using the scaffolding tool to produce Create, Read, Update, and Delete (CRUD) pages for the movie model.
@1123 Carried initial migration using Add-Migration InitialCreate and the Update-Database had an error saying they multiple context that it should be specified 
added this for specification " -Context LocSlipperContext".
@1155 added an entry , there was a typo error in one of my properties wrote in size instead of price 
@1300 Application crashed due to the wrong property was unable to fix it after several attempt had to start all over again
Rushed through the process
@1450 Data was seeded by create a new Model called SeedData.cs
