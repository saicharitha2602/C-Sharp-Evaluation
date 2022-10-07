namespace Evaluation_Q4
{
    public abstract class Bird
    {
        private string name;
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public abstract void eat();
        public void fly()
        {
            Console.WriteLine("Bird  is flying");
        }

    }
    public class Parrot : Bird
    {
        public override void eat()
        {
            Console.WriteLine("Parrot is eating");
        }
        public new void fly()
        {
            Console.WriteLine("Parrot is Flying");
        }
    }
    public class Crow : Bird
    {
        public override void eat()
        {
            Console.WriteLine("Crow is eating");
        }
        public new void fly()
        {
            Console.WriteLine("Crow is Flying");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter type of bird");
            string bird = Console.ReadLine();
            switch (bird)
            {
                case "parrot":
                    Parrot p = new Parrot();
                    Console.WriteLine("Enter name of bird");
                    string bird_name1 = Console.ReadLine();
                    p.Name = bird_name1;
                    Console.WriteLine(p.Name);
                    p.fly();
                    p.eat();
                    break;

                case "crow":
                    Crow c = new Crow();
                    Console.WriteLine("Enter name of bird");
                    string bird_name2 = Console.ReadLine();
                    c.Name = bird_name2;
                    Console.WriteLine(c.Name);
                    c.fly();
                    c.eat();
                    break;

            }
        }
    }
}
