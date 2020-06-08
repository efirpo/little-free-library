# **Little Free Library**

#### Author: **_Jessica Hvozdovich and Ethan Firpo_**
#### June 8, 2020

### Description

_This application serves as an introduction to building an API with C#/.NET Core. The API is a public library book tracker. Users can update current stocks of little librairies and keep track of books they have checked out._

### Instructions for use:
<!-- UPDATE WHEN DATABASE IS CREATED -->
<!-- 1. Open Terminal (macOS) or PowerShell (Windows)
2. To download the project Directory to your desktop enter the following commands:
```
cd Desktop
git clone https://github.com/jhvozdovich/little-free-library.git
cd little-free-library (or the file name you created for the main Directory of the download)
```
3. To view the downloaded files, open them in a text editor or IDE of your choice.
* if you have VSCode for example, when your terminal is within the main project Directory you can open all of the files with the command:
```
code .
```
4. Create a file within the Library folder named appsettings.json.
5. Add the following code:
```
{
  "ConnectionStrings": {
    "DefaultConnection": "Server=localhost;Port=3306;database=jessica_hvozdovich;uid=root;pwd=YOURMYSQLPASSWORDHERE;"
  }
}
```
* Make any other changes needed if you have an alternative server, port, or uid selected. These are the default settings.

6. To install the necessary dependencies and start a local host, after replicating the database steps below run the following commands:
```
dotnet restore
dotnet build
dotnet run
``` -->

#### If you need to install and configure MySQL:
1. Download the MySQL Community Server DMG file [here](https://dev.mysql.com/downloads/file/?id=484914) with the "No thanks, just start my download" link.
2. On the configuration page of the installer select the following options:
* Use legacy password encryption
* Set your password
3. Open the terminal and enter the command:
*'export PATH="/usr/local/mysql/bin:$PATH"' >> ~/.bash_profile
4. Download the MySQL Workbench DMG file [here](https://dev.mysql.com/downloads/file/?id=484391)
5. Open Local Instance 3306 with the password you set.

#### To create a local version of the database:
1. Open MySQL Workbench and Local Instance 3306.
2. Select the SQL + button in the top left of the navigation bar.
3. Paste the following in the query section to create the database:
<!-- UPDATE INSTRUCTIONS WHEN DB IS BUILT REFORMAT FOR LARGER DB USING AN EXTERNAL SQL FILE -->
<!-- ```
CREATE DATABASE `jessica_hvozdovich`;

USE `jessica_hvozdovich`;

CREATE TABLE `Treats` (
  `TreatId` int(11) NOT NULL AUTO_INCREMENT,
  `Name` longtext,
  `Price` int(11) NOT NULL,
  `UserId` varchar(255) DEFAULT NULL,
  PRIMARY KEY (`TreatId`),
  KEY `IX_Treats_UserId` (`UserId`),
  CONSTRAINT `FK_Treats_AspNetUsers_UserId` FOREIGN KEY (`UserId`) REFERENCES `aspnetusers` (`Id`) ON DELETE RESTRICT
);

CREATE TABLE `Flavors` (
  `FlavorId` int(11) NOT NULL AUTO_INCREMENT,
  `Name` longtext,
  `UserId` varchar(255) DEFAULT NULL,
  PRIMARY KEY (`FlavorId`),
  KEY `IX_Flavors_UserId` (`UserId`),
  CONSTRAINT `FK_Flavors_AspNetUsers_UserId` FOREIGN KEY (`UserId`) REFERENCES `aspnetusers` (`Id`) ON DELETE RESTRICT
);

CREATE TABLE `FlavorTreat` (
  `FlavorTreatId` int(11) NOT NULL AUTO_INCREMENT,
  `FlavorId` int(11) NOT NULL,
  `TreatId` int(11) NOT NULL,
  PRIMARY KEY (`FlavorTreatId`),
  KEY `IX_FlavorTreat_FlavorId` (`FlavorId`),
  KEY `IX_FlavorTreat_TreatId` (`TreatId`),
  CONSTRAINT `FK_FlavorTreat_Flavors_FlavorId` FOREIGN KEY (`FlavorId`) REFERENCES `flavors` (`FlavorId`) ON DELETE CASCADE,
  CONSTRAINT `FK_FlavorTreat_Treats_TreatId` FOREIGN KEY (`TreatId`) REFERENCES `treats` (`TreatId`) ON DELETE CASCADE
);

CREATE TABLE `AspNetUsers` (
  `Id` varchar(255) NOT NULL,
  `NormalizedUserName` varchar(256) DEFAULT NULL,
  `Email` varchar(256) DEFAULT NULL,
  `NormalizedEmail` varchar(256) DEFAULT NULL,
  `EmailConfirmed` bit(1) NOT NULL,
  `PasswordHash` longtext,
  `SecurityStamp` longtext,
  `ConcurrencyStamp` longtext,
  `PhoneNumber` longtext,
  `PhoneNumberConfirmed` bit(1) NOT NULL,
  `TwoFactorEnabled` bit(1) NOT NULL,
  `LockoutEnd` datetime(6) DEFAULT NULL,
  `LockoutEnabled` bit(1) NOT NULL,
  `AccessFailedCount` int(11) NOT NULL,
  `UserName` varchar(256) DEFAULT NULL,
  PRIMARY KEY (`Id`),
  UNIQUE KEY `UserNameIndex` (`NormalizedUserName`),
  KEY `EmailIndex` (`NormalizedEmail`)
);

``` -->

4. Press the lightning bolt button to run this command.
5. If the database does not appear, right click in the schemas bar and select Refresh All.

### Known Bugs

No bugs have been identified at the time of this update.
Passwords requirements are currently reduced for testing.

### Support and Contact Information

Please contact me with any suggestions or questions at jhvozdovich@gmail.com. Thank you for your input!  
_Have a bug or an issue with this application? [Open a new issue](https://github.com/jhvozdovich/little-free-library/issues) here on GitHub._

### Technologies Used

* C#
* `ASP.NET` Core
* `ASP.NET` Core MVC
* Entity Framework Core
* MySQL
* Git and GitHub

### Specs
| Spec | Input | Output |
| :------------- | :------------- | :------------- |
| **User enters home page** | User Input:"URL: localhost:5000/" | Output: “Welcome!” |
| **User can view book descriptions and see locations** | User Input:"Click: Howl's Moving Castle" | Output: “Author: Dianna Wynne Jones, Condition: Good, Locations: Charter 98701, Charter 23646 ” |
| **User can view the books available at a certain location and information** | User Input:"Charter 23646" | Output: “Location 88th & Oak, 8885 Nw Oak St, Portland OR 97229, Books: Howl's Moving Castle, The Cruel Prince, Six of Crows” |
| **User can add a book** | User Input:"Click: Add Book" | Output: “Add Book Form: Title: Howl's Moving Castle, Author: Dianna Wynne Jones, Condition: Good, Location: Charter 98701, Book ID: Auto Incremented” |
| **User can add a book to a location** | User Input:"Click: Dropoff" | Output: Dropoff form: Book ID” |
| **User can add location** | User Input:"Click: Add Library" | Output: Add library form: Address: Location 88th & Oak, 8885 Nw Oak St, Portland OR 97229, Charter ID: Auto Incremented” |
| **User can update books condition and availability** | User Input:"Click: Book ID, Click: Update" | Output: “Condition and Location Form: Condition: Poor Location: Charter 98701” |
| **User can delete books available at a location when checked out** | User Input:"Click: Charter 23646, Click: Checkout, Click: Six of Crows" | Output: “Available books: Howl's Moving Castle, The Cruel Prince” |
| **User can delete books completely if they are the original owners** | User Input:"Your Contributions > Click Book > Click Remove" | Output: “Are you sure you want to take Six of Crows out of circulation? > Yes > Remove from database” |
| **User can look up random books** | User Input:"Find random book" | Output: “Title: Howl's Moving Castle, Author: Dianna Wynne Jones, Condition: Good, Location: Charter 98701” |
| **User can search for a book** | User Input:"Search by title: Howl's Moving Castle" | Output: "Title: Howl's Moving Castle, Author: Dianna Wynne Jones, Condition: Good, Location: Charter 98701, Book ID: Auto Incremented” |
| **User can search for a little library location** | User Input:"Locations near me" | Output: “Charter 98701, Charter 23646” |

### Stretch Goals
| Spec | Input | Output |
| :------------- | :------------- | :------------- |
| **Data visualization of libraries the book has been** | User Input:"Click: Howl's Moving Castle" | Output: “Map of book journey” |
| **Include data about businesses or organizations that may be connected to a library** | User Input: Follow link to business data | Output: Page now displays organization data. | 
| **Add a model for copies of books linked to book ID** | Book: BookID, Title, Author | Copy: CopyID, BookID, Condition, CurrentLocation, Locations, Users | 


### Resources
* (Sample Data)[https://littlefreelibrary.org/ourmap/]

#### License

This software is licensed under the MIT license.

Copyright © 2020 **_Jessica Hvozdovich and Ethan Firpo_**