namespace abstarct
{
    internal class Program
    {

      
        static void Main(string[] args)
        {
            Dog dog = new Dog();
            dog.Sleep();
            dog.Run();
        }
    }
    abstract class Animal
    {
        public abstract void Run();
        public void Sleep()
        {
            Console.WriteLine("Sleeping");
        }
    }
    class Dog : Animal
    {
        public override void Run()
        {
            Console.WriteLine("run");
        }
    }
}
