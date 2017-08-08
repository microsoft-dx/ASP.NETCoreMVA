# Entity Framework


### What is Entity Framework?
[Entity Framework] is a set of technologies that helps developers build data-driven software applications. Traditionally, developers had to deal with two very different tasks:

  * model the entities, relationships, and logic of the business problems they are solving
  * work with the data engines used to store and retrieve the data
  
The problems that can occur are that the database can span between multiple storage systems, each with its own protocols, each with its own protocols and even if the database is held in one single storage systems, the developer has the concern of respecting both the requirements of the storage system and writing efficient and maintainable code.

With the Entity Framework, developers can work at a higher level of abstraction when they deal with data, and can create and maintain data-oriented applications with less code than in traditional applications.

### How can we do this?

![CodeFirstModelFirst](https://github.com/microsoft-dx/aspnet-core-fundamentals-mva/blob/master/Images/EF-1.PNG)

There are two approaches to using Entity Framework 
  * Code-First
  * Model-First

#### Code First

![CodeFirst](https://github.com/microsoft-dx/aspnet-core-fundamentals-mva/blob/master/Images/EF-2.png)

This approach autmatically creates the database schema based on what *models* you have in your application.

With the Code-First approach, you can focus on the domain design and start creating classes as per your domain requirement rather than design your database first and then create the classes which match your database design.

