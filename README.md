# Student Management API (ASP.NET Core + CQRS + MediatR)
An ASP.NET Core API for a Student Management System using CQRS and the Mediator pattern. The system support adding, updating, deleting, and retrieving all students, with all data stored in memory.

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
```


<img width="1641" height="856" alt="image" src="https://github.com/user-attachments/assets/147d5c9e-872f-49fc-8504-9c53d161571f" />

