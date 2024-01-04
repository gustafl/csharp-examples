namespace Interface
{
    /**
     * An interface is used to define a contract that classes must adhere to.
     * It only specifies method and property signatures but doesn't provide any
     * implementation. All members declared in an interface must be implemented
     * by the implementing class.
     * 
     * Interface members have no access modifiers - they are implicitly public.
     * Their implementation must also be public.
     * 
     * By convention, interface names start with a capital I.
     */

    public interface IAnimal
    {
        string Name { get; }
        int Age { get; set; }

        void MakeSound();
        void Sleep();
        void Eat();
    }

    public interface IPet
    {
        void Play();
    }

    public class Dog : IAnimal, IPet
    {
        public string Name { get; }
        public int Age { get; set; }

        public Dog(string name)
        {
            Name = name;
        }

        public void MakeSound()
        {
            Console.WriteLine($"{Name} barks!");
        }

        public void Sleep()
        {
            Console.WriteLine($"{Name} is sleeping.");
        }

        public void Eat()
        {
            Console.WriteLine($"{Name} is eating.");
        }

        public void Play()
        {
            Console.WriteLine($"{Name} is playing.");
        }
    }


    class Program
    {
        static void Main()
        {
            // Create an instance of the implementing class
            Dog myDog = new Dog("Buddy");
            Console.WriteLine($"My dog's name is {myDog.Name}.");
            myDog.MakeSound();
            myDog.Sleep();
            myDog.Eat();
            myDog.Play();
        }
    }
}
