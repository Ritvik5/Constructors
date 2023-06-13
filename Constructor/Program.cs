namespace Constructor
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to view different types of constructor!!!\n");

            //-- Default constructor

            Customer obj = new Customer();
            Console.WriteLine(obj.name);

            // -- Parameterised Constructor

            Addition add = new Addition(10, 25);
            Console.WriteLine("Value of a is {0} and b is {1}.",add.a,add.b);

            //-- Copy Constructor

            Employee emp1 = new Employee("Smith", 25);

            Employee emp2 = new Employee(emp1);

            Console.WriteLine(emp2.Details);

            //-- Static Constructor

            Employee1.Salary();

            //-- Private Constructor

            Counter.currentview = 500;
            Counter.visitedCount();
            Console.WriteLine("\nThe cuurent count view is {0}",Counter.currentview);
        }
    }
}