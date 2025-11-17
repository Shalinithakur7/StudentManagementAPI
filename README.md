# Student Management API (ASP.NET Core + CQRS + MediatR)

an ASP.NET Core API for a Student Management System using CQRS and the Mediator pattern.

---

## Features
- Add Student  
- Update Student  
- Delete Student  
- Get All Students  
- CQRS (Commands + Queries)  
- Mediator Pattern using MediatR  
- In-memory Data Storage  

---

## Run the Project

```bash
dotnet restore
dotnet build
dotnet run
Swagger UI:
https://localhost:7077/swagger

API Endpoints
GET /api/Students
Retrieve all students.

POST /api/Students
Create a new student.

PUT /api/Students/{id}
Update student by ID.

DELETE /api/Students/{id}
Delete student by ID.

Returns 204 No Content if deleted

Returns 404 Not Found if ID doesn’t exist
