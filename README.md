# General Notes
- stick with .NET 5
- when you setup a project select Console.App (.NET framework)
- choose windows from 4.8
- follow instructions on how to name the project
- keep the default structure of .NET 5 as:

```
namespace COMP3602Assign01
{
    internal class Program
    {
```

# Handin Requirements
- Need at `least 3 comments`
- the comments can be based on the requirements document your read
- add the comments above the area not beside so there is less scrolling left and right
- Add `starUML` or `Visual Paradigme Community Edition` file to root of the folder
- UML diagram in PDF format

# Resubmission
- you can resubmit the assignments and labs in order to achieve a better mark
- resubmit as many times as you want

# Variables - Best practice
- put them as close to the area you will be using it (not all at the top)

# Constants for microsoft just do:
```
const int MaxNumber = 20
```

# ref in parameter
- when you want origainal value to change in the function then you want to wright reg int input must do this where you call and in the parameter of the function you call

# if you use ref then the heap will change as well to match because it was updated

# If one heap is not called?
> then it is put up for collection to and will be removed as part of the garbage collector

# Out
> does not require initialization before collectin the method

# Casting
1. implicit casting
> when you for example move from a small house to a big house it is ok

2. Explicit casting
> ex when you move from a large house to a small one then you will lose something

# While loop for numeric input data must use this 

```
string input = ""
while(int.TryParse(input, out age) == false)
{
    Console.Write(Enter your age in years);
    input = Console.ReadLine();
}
```

# Enums
> labels for numbers

# UI validations
> If you are testing if the person inputs a number this testing should be done in the UI