// This is an example of code that gives you examples of how inheritance works in c#
// by Daniel Dainty, Birmingham City University
// You will see we have a main class called Animal which can Walk() and Poo() and ActHappy()
// ActHappy() is defined as 'virtual' meaning it can be overwritten by specific animals
// Then we have Dog and Cat which inherits Animal (so it can walk, poo and act happy) and then
// we allow the dog to bark, the cat to meow. So far, so good.
// For the last trick we define what happens when a dog gets happy (it barks, repeatedly, loudly)
// but for a cat we don't define it - because that's just how cats roll.

using System;

namespace ClassInheritanceExample
{
    class Program
    {
        static void Main(string[] args)
        {

            Dog Bessie = new Dog();     // create a dog called Bessie from class 'Dog'
            Bessie.Walk("north");       // the code for 'walk' is the same regardless of animal
            Bessie.Bark(7,7);           // bark is defined on dog, not on animal
            Bessie.ActHappy();          // Good girl! There's a good girl! Ssshhhh...

            Cat Felix = new Cat();      // create a cat called Felix from the class 'Cat'
            Felix.Walk("north");        // 'walk' is the same as dog
            Felix.Meow(5, 2);           // dog cannot meow, cat can
            Felix.ActHappy();           // displays 'animal does not know how to be happy' - not only because
                                        // it's a cat, but because we're using the 'animal' method of ActHappy.
                                        // In 'dog' we overwrote it, but not in 'cat'.

            Console.ReadLine();         // pause the program so you can see the output.


        }
    }
    class Animal
    {
        public void Walk(string direction)
        { Console.WriteLine("Animal is now walking"); }
        public void Poo(int intensity)
        { Console.WriteLine("Animal is now defecating"); }
        public virtual void ActHappy()
        { Console.WriteLine("Animal does not know how to be affectionate"); }
    }

    class Dog : Animal // inherits all the methods of 'animal' as well as being able to create its own
    {
        public void Bark(int volume, int repetitions)
        { Console.WriteLine("Bark!"); }
        public new void ActHappy()
        {  this.Bark(9, 12); }
    }
    class Cat : Animal // inherits all the methods of 'animal' as well as being able to create its own
    {
        public void Meow(int volume, int repetitions)
        { Console.WriteLine("Meow!"); }
    }
}
