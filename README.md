# CatBoardInterface
### By **Dusty McCord**  April 3rd 2020

ASP.NET core API application to track and display animals in an animal shelter.

## Specifications user stories:

* As a user, I want to be able to GET a list of all animals in the shelter.
* As a user, I want to be able to POST a new animal to the shelter Database.
* As a user, I want to be able to Get details of a specific animal.
* As a user, I want to be able to PUT and DELETE Animal entries in the database.

## API End Points
```
GET /api/Animals
POST /api/Animals
GET /api/Animals/{AnimalId}
PUT /api/Animals/{AnimalId}
DELETE /api/Animals/{AnimalId}
```

## Further Explorations include
* installed swagger with Nswg 
* [Versioned API](https://neelbhatt.com/2018/04/21/api-versioning-in-net-core/)

## Setup/Installation Requirements
_Make sure you have these tools installed on your computer:_
*  [Git version control](https://git-scm.com/downloads)
*  [MySql](https://azure.microsoft.com/en-us/free/mysql/)
*  [Microsoft .Net Core 2.2](https://docs.microsoft.com/en-us/dotnet/framework/install/)
*  [.Net Script](https://dotnet.microsoft.com/download/dotnet-core/2.2)


### Prerequisites

1. [.NET Framework](https://dotnet.microsoft.com/download/thank-you/dotnet-sdk-2.2.106-macos-x64-installer) 
2. Text Editor (Visual Studio Code)

### Installing
_In your terminal_

* Clone the project from GitHub by typing:
```sh
git clone  https://github.com/dustatron/AnimalShelter
```

* Navigate to the project folder by typing:
```sh
cd AnimalShelter/ApiAnimalShelter
```
* Restore the project with this terminal command:
```sh
dotnet restore
```

Build the database by entering the command:
```sh
dotnet ef database update
```

Run the program by typing:
```sh
dotnet run
```
Navigate to the MVC project
```sh
cd ../MvcAnimalShelter
```
Run the MVC project to see the front end by typing:
```sh
dotnet run
``` 
View MVC project by going to this address in your browser:
```sh
http://localhost:5010/
```
View Endpoint by entering the follow address in your browser:
```sh
http://localhost:5000/swagger
```


## Technologies Used

* C#
* ASP.NET core MVC 2.2
* RestSharp API
* Entity Framework
* Newtonsoft.Json
* MySqlConnector
* Razer
* Git
* Nswag
* [Materializecss](https://materializecss.com/)


## Known Bugs
Currently there's no known bugs.

## Contact Info 
Currently there's no known bugs, however, if there are any issues running this website I would love feedback! Please email us at 
* DustyMcCord@gmail.com.


## License

Licensed under the MIT license.

&copy; 2020 Dusty McCord.
