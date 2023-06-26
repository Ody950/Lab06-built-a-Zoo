# Lab06 Built a Zoo

## introduction 

This Console app is a practical application on Object Oriented Programming and its four types, as we will classify animals into different categories based on their characteristics, and the most important thing is to send method and proparts from parents to children.

## Digital UML drawing of the zoo

<img src="./Lab06-built-a-Zoo/UML .jpg" style="width: 1000px;">


## Overview of the four OOP principles:

Inheritance is part of object-oriented programming and one of the basic components of. NET. It is critical for organizing code and dividing large problems into small parts. It enables you to reuse your code in more than one location to achieve high benefits. As for inheritance, it works well in .NET, as it allows me to create new classes that reuse, extend, and modify the behavior defined in previous classes, which means there is less redundancy in the code we write.


### Inheritance

The basic function of Inheritance is to pass the behavior from one class to another, where the class that gives the behavior is the parent and the class that inherits the behavior is the children, it inherits all the members (fields, properties and methods). This behavior can be modified or added to in children. And the main benefit of all of this is to make the code we write less in the number of lines and more professional.

 ### Abstract

 Abstract makes us able to create classes with details hidden from the user or other programmer, so that he can only use what he is allowed to do, which is called interface and prevent him from accessing implementations so that this does not cause programming problems as a result of accessing unrelated code or certain people's work. The closest example is a car. You do not have to know the mechanics of how the car works to drive it. You just have to learn to drive to use a car. There are lots of benefits to using abstract including the reduction of code complexity, and it also makes refactoring very easy.

### Polymorphism

Polymorphism is complementary to Inheritance, as it enables us to send behavior from parents to children with the possibility of modification, as this is done through two methods, override, overloading. 


## Encapsulation

which is simply a collection of data and methods that operate on that data within a single unit, such as a class, which protects this data from unauthorized modification Authorized, where access to data is guaranteed only through available methods.

## Applying OOP into my project:

- Inheritance: we have a base abstract class, Animal, that give properties and methods to all five animal, where it pass properties and methods through all the categories in a quadruple level of layers until you reach them.

- Abstraction: where the Tiger have covers her skin() from his abstract parent class the Mammals.

- Polymorphism: our two concrete class Crocodile a reference of type Animal or of type Cold-Blooded or Reptiles, and all them using the Animal reference, that give them access to the methods and properties .

- Encapsulation: The client will not be able to access the actual values in which the animal data is stored, it can only access the public field to get the value that returns to it after processing it.






