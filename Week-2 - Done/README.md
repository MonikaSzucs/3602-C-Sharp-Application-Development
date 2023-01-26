# Reference
address in memory

# S and H stands for?
Stack vs the heap

# C# notes
- int is a value type
- in C# - int is a value type
- values are saved on the stack as name and value
- objects are not saved on the stack it is saved on the heap (rest of the memory)
- Person person = new Person the variable person will be on teh stack (hexadecimal address) but the value here is just the address which will reference the heap 
- object has attributes like data, methods/functions
- Class has attributes and behaviours

# 3 programming structures ( structuring programming )
- this maps to human logic
1. sequence
2. conditional (if/else)
3. repetitive structures (loops)

- where you place the code is different but how you comprehend it you must know how to solve it. 

- if we need to implement an action (behaviour) for a software we need to look at the methods 
- we create lots of methods which create the functionality 
- data can be stored in memory in variables then we have more complex data types liek arrays, dictionaries and much more on run time
- persistant data in files etc 
- functions manipulate the data and they have the UI
- class is a container which organizes data. They belong to the same entity

# String
- behaves like a value type 
- you can reassign it
- are immutable
- is an object and cannot be changed
- be careful when you build strings at runtime
- when its so slow at runtime look at your Strings
- when you concatenate strings. it drops those two then drops them and creates a new object in memory

- when you create a class you will get all the default behaviours you will get like toString()

# toUpper/Lower
- immutible

# substrings
- extract for parsing

# Hard coding = magic numbers
- if we do a forloop we dont need to hard code it because its a programming number 

# Struct
- is like choices to store data in memory

# Data class
- have variables at the top, constructor, methods with getter/setter
- should not perform any UI function 
- the Console.WriteLine should be a UI not in a data class

# UI Classes
- are classed utility calsses
- they print to the console
- cont call the class utility ever make it unique as to what  this UI will specifically do

structs are value types, classes are reference types

- static method you dont need to create and instance 
- structs are faster because it is on stack

Constructor is a method that is executed first

You can have overloaded constructors with different parameters

# Encapsulation
- hiding data attribute but you provide getters and setters to help get this info
- make the data private at the top

- property wraps the get adn the setter

# Writing varaibles and classes
- private attributes are camelCase (backing field)
- the method is written as PascalCase

- add comments at the top of the property not at the top of every getter and setter

# Object initializer
- can be any order
- one line of code
Person person = new Person({FirstName = "Monika"});

# Constructor of this class
- the default constructor
- no parameters it is created automatically

# Setting the name
person.FirstName = "Lewis"

# Creating an instance that is empty
Person person = new Person();

- then add to it
person.FirstName = "Lewis"

# namespace
- is automatically created when you create teh project

# Comments
- always put the comments above not at the end on the same line or else we have to scroll left and right
- we comment why we put the code