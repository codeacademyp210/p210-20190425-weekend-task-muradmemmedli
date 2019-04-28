using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classhomework
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person();
            Employee employee = new Employee();
            Client client = new Client();
            Product product = new Product();
            Order order = new Order();
            var id = person.GetNum();

          
            


            do
            {
                Console.WriteLine("Secim edin: I - ishci yaratmaq M - mushteri yaratmaq P - mehsul yaratmaq O - sifarish yaratmaq");
                char input = Console.ReadKey().KeyChar;
                if (input != 'i' && input != 'm' && input != 'o' && input != 'p' && input != 'I' && input != 'M' && input != 'O' && input != 'P')
                {
                    Console.WriteLine("Zehmet olmasa duzgun herf secin");
                }
                switch (input)
                {
                    case 'i': case 'I':
                        Console.WriteLine();
                        Console.WriteLine("Please enter your name:");
                        employee.Name = Console.ReadLine();
                        Console.WriteLine("Please enter your surname:");
                        employee.Surname = Console.ReadLine();
                        Console.WriteLine("Please enter your birthday:");
                        employee.Birthday = Console.ReadLine();
                        Console.WriteLine("Please enter your card ID:");
                        employee.Card_ID = Console.ReadLine();
                        Console.WriteLine("Please enter your position:");
                        employee.Position = Console.ReadLine();
                        Console.WriteLine("Please enter your salary:");
                        employee.Salary = Console.ReadLine();
                        Console.WriteLine("Ishci yaradildi." + id+ "-" + employee.Name + " " + employee.Surname+" "+employee.Birthday);
                        break;
                    case 'm': case 'M':
                        Console.WriteLine();
                        Console.WriteLine("Please enter your name:");
                        client.Name = Console.ReadLine();
                        Console.WriteLine("Please enter your surname:");
                        client.Surname = Console.ReadLine();
                        Console.WriteLine("Please enter your birthday:");
                        client.Birthday = Console.ReadLine();
                        Console.WriteLine("Please enter your card ID:");
                        client.Card_ID = Console.ReadLine();
                        Console.WriteLine("Please enter your client ID:");
                        client.Client_ID = Console.ReadLine();
                        Console.WriteLine("Please enter your address:");
                        client.Address = Console.ReadLine();
                        Console.WriteLine("Please enter your phone:");
                        client.Phone = Console.ReadLine();
                        Console.WriteLine("Ishci yaradildi." + id + "-" + client.Name + " " + client.Surname);
                        break;
                    case 'p':case 'P':
                        Console.WriteLine();
                        Console.WriteLine("Please enter your name:");
                        product.Name = Console.ReadLine();
                        Console.WriteLine("Please enter your color:");
                        product.Color = Console.ReadLine();
                        Console.WriteLine("Please enter your price:");
                        product.Price = Console.ReadLine();
                        Console.WriteLine("Ishci yaradildi." + id + "-" + product.Name + " " + product.Color + " " + product.Price + "AZN" );
                        break;
                    case 'o':case 'O':
                        Console.WriteLine();
                        Console.WriteLine("Please enter your count:");
                        order.Count = Console.ReadLine();
                        Console.WriteLine("Sifarish yaradildi:\r\n" + id + "-" + product.Name + client.Name + "terefinden sifarish olundu.\r\n" + "Sayi:" + order.Count + " " + "Cemi mebleg:" + Convert.ToInt32(product.Price) * Convert.ToInt32(order.Count) + "AZN" + "\r\nSifarishi qebul eden ishci:" + " " + employee.Name + " " + employee.Surname + " " + employee.Position);
                        break;
                        
                }   
            } while (true);  
        }   
    }
    class Person
    {
        public static int num = 1;

        public void Count()
        {
            num++;
        }
        public int GetNum()
        {
            return num;
        }
        public int ID { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Birthday { get; set; }
        public string Card_ID { get; set; }
    }
    class Employee : Person
    {      
        public string Position { get; set; }
        public string Salary { get; set; }
    }
    class Client : Person
    {        
        public string Client_ID { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
    }
    class Product
    {       
        public string Name { get; set; }
        public string Color { get; set; }
        public string Price { get; set; }
    }
    class Order
    {   
        public Client client { get; set; }
        public Product product { get; set; }
        public string Count { get; set; }
        public string TotalPrice { get; set; }
    }
}
