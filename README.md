# HairSalon

#### By Mo Byrne

#### An application to keep track of a HairSalon's stylists and their Clients.

## Technologies Used

* C#
* Razor
* HTML
* CSS
* Bootstrap
* MySQL
* Entity

## Description

A webpage for the owner of an imaginary HairSalon to add stylists when they are hired, then add their new clients to a list. Stylists' and clients' names and details are saved on a database. They can both be added to, edited, or deleted. 

## Setup/Installation Requirements

* Open console application, and run the command


    ``git clone https://github.com/MoseyByrne/HairSalon``

* Then run 

    ``cd HairSalon``

* You should now have a folder `HairSalon` with the following structure.
    <pre>HairSalon
    └── HairSalon
        ├── Controllers
        ├── Models
        ├── ...
        ├── README.md
        └── Startup.cs</pre>

* Add a file named appsettings.json in the following location 

    <pre>HairSalon
    └── HairSalon
        ├── Controllers
        ├── Models
        ├── ...
        ├── README.md
        ├── Startup.cs
        └── <strong>appsettings.json</strong></pre>

* Copy and paste below JSON text in appsettings.json.

```json
{
  "ConnectionStrings": {
      "DefaultConnection": "Server=localhost;Port=3306;database=mo_byrne;uid=[YOUR-USERNAME-HERE];pwd=[YOUR-PASSWORD-HERE]"
  }
}
```

* Replace [YOUR-USERNAME-HERE] with your MySQL username.

* Replace [YOUR-PASSWORD-HERE] with your MySQL password.


* To navigate to the following directory in the console run ``cd HairSalon``
  
    <pre>HairSalon
    └── <strong>HairSalon</strong>
        ├── Controllers
        ├── Models
        ├── ...
        ├── README.md
        ├── Startup.cs
        └── appsettings.json</pre>

Run the following command in the console

  ``dotnet build``

Then run this command in the console

  ``dotnet run``


This program was built using _`Microsoft .NET SDK 5.0.401`_, and may not be compatible with other versions. Your milage may vary.

## Known Bugs

* _No known issues_

## License


Copyright (c) 07/30/2022 Mo Byrne
