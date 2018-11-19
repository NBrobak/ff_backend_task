# Funday Factory Backend Test Task
A task made to test a individuals skills in writing code for backend usage at Funday Factory.


# Description
This assignment is used as the base for a technical talk, so remember to consider the design and architecture around the implementation of the system and testing.

A good idea is to timebox the assignment and write your thoughts down on stuff which have not been implemented or that you want to implement.

# Assignment
Write a program (API) which fulfills the following criterias:
- C#/.NET Core API (using the MVC framework).
- Use JSON for communication
- Use a datastore (Relational or NOSQL). You can pick whatever datastore you want.
- Project should contain a dockerfile and should be able to be built as a container for Linux.
- Should have atleast 2 GET and 1 POST ([HttpGet] / [HttpPost]) methods.
- Needs to use **D**ependency **I**njection (use .NET Core built-in **DI**) with interfaces.

Last but not least; your solution should be added as a fork of this project, here on github. :-)


#### GET methods
1. No parameter: should return all values in datastore.
2. With parameter: should return the object with the ID (if any). Otherwise return 404 Not Found.


#### POST method
- Add an object to the datastore. Returns the ID once inserted.


#### Return value
When returning data to the user, please make a model for APIResult.
Example (which you can use if  you wish):
```C#
public class APIResult
{
  public bool Success { get; set; }
  public string ErrMessage { get; set; }
  public object Data { get; set; }
}
```

Data should be empty if call was not successful and an appropiate error message should be added.

You choose what you believe is appropriate.

#### Data
You can pick whatever data you want. It could be pizzas, pokemons, games, music - whatever you wish.


#### Final remarks
You can use docker for spinning up an database easily.

#### Note
This task might seem trivial, but please think carefully about how you structure you code, as this is what we will look at most.

Also look up best practices, how to handle returning status codes in a MVC project. Also, remember to write comments for methods which does not easily tell the reader what is does.

Example of such method:
```C#
public void DoStuff() {}
```
In this case, a comment is required, as we do not know what "DoStuff" is doing. An alternative to writing a comment, is to change the name of the method to be more fitting.

A comment should ALWAYS be added if the method is doing complex stuff (bonus points for making something more complex).
