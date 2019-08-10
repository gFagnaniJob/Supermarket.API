
  

## Pre-Requisites:

  

  

1. An instance of [Sql-Server](https://www.microsoft.com/it-it/sql-server/sql-server-downloads) installed on PC

  

2.  [ASP.NET CORE 2.2 SDK](https://dotnet.microsoft.com/download/dotnet-core/2.2) installed on PC


## Set the Application
1. `git clone https://github.com/gFagnaniJob/Supermarket.API.git`
2.  `cd Supermarket.API`
3. `dotnet restore`


## Run the Application
1. `dotnet run`

## Test the Application
### Pre-Requisites
1. Postman installed on PC
### Testing
1. Open Postman
2. Click on File -> Settings -> General and turn off the "SSL Certificate Verification"
3. Create a new Request
4. Select the HTTP Method from Dropdown menu (e.g. GET)
5. Insert https://localhost:5001/ + relative API path (e.g. api/categories)
6. If necessary, in tab "BODY" select "raw" and JSON (application/json) as input type and write the request body in JSON format.
7. Click on Send and analyze the server response
  

  

### Credits To: Evandro Gomes ([FreeCodeCamp.org](https://www.freecodecamp.org/news/an-awesome-guide-on-how-to-build-restful-apis-with-asp-net-core-87b818123e28/))