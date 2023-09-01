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
<img width="997" alt="1" src="https://github.com/chrisch0ng/.NETCore-MVC-REST-API/assets/74153634/70242f56-f890-48e2-b44f-d77d3366479f">

### The 6 API Endpoints for creating, reading, updating, and deleting resources (which is this case are commands) 
<img width="923" alt="2" src="https://github.com/chrisch0ng/.NETCore-MVC-REST-API/assets/74153634/5be57f7a-e0cc-468d-9a9b-d9ad530031d1">

### The API Endpoints (CRUD):

### Demonstrating endpoints using Postman:
#### [HttpGet] Reads the command under given id / 

<img width="640" alt="get1" src="https://github.com/chrisch0ng/.NETCore-MVC-REST-API/assets/74153634/1ebd6652-ea7e-499e-9269-b6c2ca732bbd">
<img width="701" alt="get2" src="https://github.com/chrisch0ng/.NETCore-MVC-REST-API/assets/74153634/794c157b-3966-4446-b590-79523bc39b69">


#### [HttpPost] Creates new command, returns a "201 created" status code and the location header with link to new resource 
<img width="664" alt="post1" src="https://github.com/chrisch0ng/.NETCore-MVC-REST-API/assets/74153634/5d588944-75aa-4b95-a813-bc57cc72bf88">
<img width="698" alt="post2" src="https://github.com/chrisch0ng/.NETCore-MVC-REST-API/assets/74153634/6d6078cc-e27f-4fc2-bced-8e03faf4ad09">

#### [HttpPut] Replaces the resource with a new given command 
<img width="661" alt="put1" src="https://github.com/chrisch0ng/.NETCore-MVC-REST-API/assets/74153634/4386a5a6-9bb0-4172-b3b5-166175c17a92">
<img width="636" alt="put2" src="https://github.com/chrisch0ng/.NETCore-MVC-REST-API/assets/74153634/01cd852e-9465-43fe-888b-986636dc8828">
<img width="641" alt="put3" src="https://github.com/chrisch0ng/.NETCore-MVC-REST-API/assets/74153634/0ae2b519-6d3c-4d17-b90c-fe95aed47005">


#### [HttpPatch] Updates a resource, can change part of a command depending on input 
<img width="445" alt="patch1" src="https://github.com/chrisch0ng/.NETCore-MVC-REST-API/assets/74153634/34a4d199-a6d9-4ed9-86c0-f15f2bb759a8">
<img width="620" alt="PATCH2" src="https://github.com/chrisch0ng/.NETCore-MVC-REST-API/assets/74153634/133095de-605e-4da7-8025-1c88bf413726">
<img width="613" alt="patch3" src="https://github.com/chrisch0ng/.NETCore-MVC-REST-API/assets/74153634/b8f5dcda-2cb0-44b8-a6c9-81e6e0c5f6d7">


#### [HttpDelete] Deletes a resource 
<img width="603" alt="delete 1" src="https://github.com/chrisch0ng/.NETCore-MVC-REST-API/assets/74153634/bc4d1d5e-d1d6-4104-afdf-5a42e9d56110">
<img width="687" alt="delete 2" src="https://github.com/chrisch0ng/.NETCore-MVC-REST-API/assets/74153634/9cd66d45-9c00-4085-b5fd-846808da15d5">


