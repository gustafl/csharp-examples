namespace AbstractClass
{
    /**
     * Abstract classes cannot be instantiated. Use them when you want to
     * provide a common base for derived classes while also providing some
     * of the implementation. A class can inherit from only one abstract class,
     * and abstract classes can inherit from other abstract classes.
     * 
     * Abstract classes can have a combination of abstract, virtual, and
     * concrete (non-abstract, non-virtual) members. Abstract members can only
     * occur in abstract classes. Abstract methods have no implementation and
     * must be overridden in derived classes. Virtual methods provide a default
     * implementation that may be overridden in derived classes. Other methods
     * have an implementation and cannot be overridden.
     * 
     * Apart from abstract methods, there are abstract properties and abstract
     * indexers. They have the same characteristics as abstract methods.
     */

    public abstract class Animal
    {
        public string Name { get; set; }

        public Animal(string name)
        {
            Name = name;
        }

        // Abstract method (to be implemented by derived classes)
        public abstract void MakeSound();

        // Virtual method (to be optionally overridden by derived classes)
        public virtual void Sleep()
        {
            Console.WriteLine($"{Name} is sleeping.");
        }

        // Concrete method
        public void Eat()
        {
            Console.WriteLine($"{Name} is eating.");
        }
    }

    public class Dog : Animal
    {
        public Dog(string name) : base(name)
        {
        }

        public override void MakeSound()
        {
            Console.WriteLine($"{Name} barks!");
        }

        public override void Sleep()
        {
            Console.WriteLine($"{Name} is sleeping like a dog.");
        }
    }

    class Program
    {
        static void Main()
        {
            // Create an instance of the derived class
            Dog myDog = new Dog("Buddy");
            Console.WriteLine($"My dog's name is {myDog.Name}.");
            myDog.MakeSound();  // Overridden abstract method
            myDog.Sleep();      // Overridden virtual method
            myDog.Eat();        // Inherited concrete method
        }
    }
}
