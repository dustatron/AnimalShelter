# CatBoardInterface
### By **Dusty McCord**  April 3rd 2020

ASP.NET core MVC application to display views that interact with the CatBoardApi application.

## Specifications user stories:

* As a user, I want to be able to GET all messages related to a specific group.
* As a user, I want to be able to POST messages to a specific group.
* As a user, I want to be able to see a list of all groups.
* As a user, I want to input date parameters and retrieve only messages posted during that timeframe.
* As a user, I want to be able to PUT and DELETE messages, but only if I wrote them. (Start by requiring a user_name param to match the user_name of the author on the message. You can always try authentication later.)

## API End Points
```
GET /api/Animals
POST /api/Animals
GET /api/Animals/{AnimalId}
PUT /api/Animals/{AnimalId}
DELETE /api/Animals/{AnimalId}
```


## Getting Started

Download the .zip file and extract all files into directory of your choice OR clone the repository to a directory. Open project directory in preferred text editor.

### Prerequisites

1. [.NET Framework](https://dotnet.microsoft.com/download/thank-you/dotnet-sdk-2.2.106-macos-x64-installer) 
2. Text Editor (Visual Studio Code)

### Installing

1. Clone the repository:
    ```
    git clone https://github.com/KeturahDev/CatBoardApi.git
    ```

2. Restore all dependencies:
    ```
    dotnet restore
    ```

### Open program

3. Compile and Run code:
    ```
    dotnet build
    dotnet run
    ```



## Technologies Used

* C#
* ASP.NET core MVC 2.2
* RestSharp API
* Newtonsoft.Json
* Git


## Known Bugs
Currently there's no known bugs.

## Contact Info 
Currently there's no known bugs, however, if there are any issues running this website I would love feedback! Please email us at 
* DustyMcCord@gmail.com.


## License

Licensed under the MIT license.

&copy; 2020 Dusty McCord.
