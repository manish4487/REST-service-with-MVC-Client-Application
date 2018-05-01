# REST-service-with-MVC-Client-Application
REST service for vehicle Management with MVC5 Client application in ASP.NET

Implement a RESTful web service that performs CRUD operations (Create, Read, Update, and Delete) for a Vehicle entity.
A Vehicle is a simple object defined as follows: 

public class Vehicle 
{ 
public int Id { get; set; } 
public int Year { get; set; } 
public string Make { get; set; } 
public string Model { get; set; } 
}
Your RESTful service must implement the following routes:
GET vehicles
GET vehicles/{id}
POST vehicles
PUT vehicles
DELETE vehicles/{id}



1) SQL server table creation of table vehicle
2) WEB API project creation for REST service hosting.
3) Entity framework Used as ORM with a solution in DB first approach.
4) Creation of GET, PUT, POST, DELETE methods for accessing service over HTTP.
5) MVC Application as a client creation.
6) Vehicle Controller creation for create, Edit and delete data in Datagrid.
7) Calling WEB API methods for displaying data in the Client application.

![op3](https://user-images.githubusercontent.com/25961531/39497051-4aa03ed0-4d56-11e8-9d2d-0efa8de51ade.jpg)

![opfinal](https://user-images.githubusercontent.com/25961531/39497052-4ad60236-4d56-11e8-87fe-1ed284fba287.jpg)
