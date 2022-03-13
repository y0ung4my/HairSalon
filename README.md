# _Bakery App: Vendor Tracker_

#### By _**Amy Young**_

#### _Allows user to track stylists and their clients_

## Technologies Used

* _C#_
* _ASP.Net Core_
* _Entity Framework_
* _SQL_


## Description

_This is a web application with pages for home, stylists, and client pages. The user creates new stylists using a form. Once a stylist is created, the user can create new clients for each stylist using another form. The application will display information for each stylist (including a list of the stylist's clients) and client details._

Database Structure

![Database Structure Image](/DatabaseImage.jpg)

## Setup/Installation Requirements

**To clone the repository**
* _open terminal_
* _enter the following into terminal: `git clone https://github.com/y0ung4my/BakeryApp`_

**To run the application on your computer**
* _navigate to the `VendorTracker` directory_
* _in the console application of your choice, navigate to the `VendorTracker` directory then enter `dotnet restore` to install the files necessary to run the local server_
* _enter the URL into the web browser of your choice, usually `http://localhost:5000`_
* _follow the prompts on the web application_
* _to reload the server while updates to the code are made, enter `dotnet watch run`_


**To import the database to MySql WorkBench**
* _download MySql workbench here: `https://www.mysql.com/products/workbench/`_
* _In the **Navigator > Administration** window, select **Data Import/Restore**_
* _In **Import Options** select **Import** from Self-Contained File**_
* _Navigate to the database file in the project._
* _Under **Default Schema to be Imported To**, select the **New** button.
* _Enter a new name for the database_
* _Click **OK**_
* _Navigate to the tab called **Import Progress** and click **Start Import** at the bottom right corner of the window._
* _click on the **Schemas** tab. Right-click in the **Schemas** window, and select **Refresh All**. The imported schema should now be listed._

**Configure Database**
* _create a file called `appsettings.json` in the root directory and enter the following:_

{
  "ConnectionStrings": {
      "DefaultConnection": "Server=localhost;Port=[your-port-number];database=[new_database_name];uid=root;pwd=[your-password];"
  }
}

* _Determine if the MySql server is running locally by typing the following into the command line `mysql -uroot -p[The password you set up]`_

## Known Bugs

* _no known bugs_

## License

MIT License

Copyright (c) 2022 Amy Young

Questions or comments: youngamy1223@gmail.com