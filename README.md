# .NETCore MVC REST API 
 
### The goal of this project is to practice and use techniques releated to 
> 1. .NET Core
> 2. Building a REST API from the ground up
> 3. MVC
> 4. C#

#### With a vast number of Command Line functions to remember and learn, it can be useful to have an API which . This Commander API will store command line snippets together with a description of what each snippet does, and the platform it is for. 

### In particular, the following concepts were used:
> - Dependency Injection
> - Entity Framework Core (Migration, DBContext)
> - SQL Server Management Studio and SQL Server Express
> - AutoMapper & Data Transfer Objects (DTOs)
> - Testing API Endpoints and functions (Postman)
> - Repository Design Pattern
> - HTTP Request and Response (GET, POST, PUT, PATCH, DELETE, status codes)

### Application Architecture Diagram 
![image](https://github.com/chrisch0ng/.NETCore-MVC-REST-API-/assets/74153634/bc301b13-59b0-481d-8faa-4cbd07a7bf6b)

### The 6 API Endpoints for creating, reading, updating, and deleting resources (which is this case are commands) 
![image](https://github.com/chrisch0ng/.NETCore-MVC-REST-API-/assets/74153634/9a436117-232d-4d8b-8a0f-4a0757086ad8)

### The API Endpoints (CRUD):
![image](https://github.com/chrisch0ng/.NETCore-MVC-REST-API-/assets/74153634/8adbf450-fb7d-4c43-9349-efefd2193541)

### Demonstrating endpoints using Postman:
#### [HttpGet] Reads the command under given id / ![6234081_sd](https://github.com/chrisch0ng/.NETCore-MVC-REST-API/assets/74153634/f1ccaa99-9578-4b74-bd54-074482f42b3e)
all commands 

<img width="654" alt="image" src="https://github.com/chrisch0ng/.NETCore-MVC-REST-API-/assets/74153634/c367f5ca-d697-4867-902d-42a45a80374e">
<img width="653" alt="image" src="https://github.com/chrisch0ng/.NETCore-MVC-REST-API-/assets/74153634/a1ed68ff-65b8-4900-a764-816c1cbbfbb2">

#### [HttpPost] Creates new command, returns a "201 created" status code and the location header with link to new resource 
<img width="657" alt="image" src="https://github.com/chrisch0ng/.NETCore-MVC-REST-API-/assets/74153634/8bb43365-1b26-41da-9c6f-523c62c6edba">

#### [HttpPut] Replaces the resource with a new given command 
<img width="639" alt="image" src="https://github.com/chrisch0ng/.NETCore-MVC-REST-API-/assets/74153634/cc19e2e4-38f5-4077-a2ee-09efda5baf53">
<img width="650" alt="image" src="https://github.com/chrisch0ng/.NETCore-MVC-REST-API-/assets/74153634/d4dfcc0f-b672-41d5-a070-02a156a22f91">
<img width="671" alt="image" src="https://github.com/chrisch0ng/.NETCore-MVC-REST-API-/assets/74153634/01ddbc8a-ba9f-44e8-8a5a-661fe75581ec">

#### [HttpPatch] Updates a resource, can change part of a command depending on input 
<img width="653" alt="image" src="https://github.com/chrisch0ng/.NETCore-MVC-REST-API-/assets/74153634/9afc3950-e8f5-4250-babb-e3c431dc2a3d">
<img width="654" alt="image" src="https://github.com/chrisch0ng/.NETCore-MVC-REST-API-/assets/74153634/8bcd60ce-8384-4f0f-aa56-43d13bfca693">
<img width="657" alt="image" src="https://github.com/chrisch0ng/.NETCore-MVC-REST-API-/assets/74153634/5a67750d-b4ea-4a2e-a08e-e73f4d8321ed">

#### [HttpDelete] Deletes a resource 
<img width="669" alt="image" src="https://github.com/chrisch0ng/.NETCore-MVC-REST-API-/assets/74153634/dff4fc1e-4210-4930-bfff-e11263464656">
<img width="664" alt="image" src="https://github.com/chrisch0ng/.NETCore-MVC-REST-API-/assets/74153634/00d168c9-712c-4d4c-b75e-0f7b67482a04">
<img width="664" alt="image" src="https://github.com/chrisch0ng/.NETCore-MVC-REST-API-/assets/74153634/55724026-3250-47ac-89e9-10597d741b5e">


