# C# class inheritance example

An example of how class inheritance works in C#.

We have a base class called 'Animal' which contains methods Walk() and Poo() and ActHappy(). This will allow any animal that inherits the Animal class to be able to do those things, by default. This prevents code duplication; no point defining Walk() for both a Cat and a Dog if all it is is "move all four legs one after another". We could also define Run() and Eat() and so on.

Walk() and Poo() are the same for all animals and so is ActHappy() - but the last method, ActHappy() is defined as a 'virtual' class which means it can be overwritten by a specific animal. This means if all animals ActHappy() by doing the same thing, except one, we only have to define it differently in one place.

In our specific example, the dog performs ActHappy() by calling its own Bark() method (with repetition and volume parameters).

The cat, on the other hand, does nothing. Because it's a cat.

Each specific animal class (Dog and Cat) has also its own methods of Bark() and Meow() which wouldn't make sense to define in the initial Animal class as Bark and Meow are specific behaviours rather than a general one.

I hope this helps to explain inheritance - any questions please give me a shout.

# How to get the best from this code

The best way to understand this code is to take it, paste it into your program console, and try and define new cats, new dogs, and to make them do things. Try and make a cat bark, try and make a dog meow, and make new methods (such as "sit" and "purr" and "sleep") and define them in the relevant area, preventing code duplication. If you have to define the same method twice, chances are you're doing it wrong.  
