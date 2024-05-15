using System.Reflection.Metadata.Ecma335;
using System.Threading.Channels;

namespace C_Lesson_5
{
    internal class Program
    {
        static void Main(string[] args)
        {

            /*Shop laptops = new Shop(3);

            laptops[0] = new Laptop
            {
                Vendor = "Samsung",
                Price = 5200
            };
            laptops[1] = new Laptop
            {
                Vendor = "Asus",
                Price = 8200
            };
            laptops[2] = new Laptop
            {
                Vendor = "Lenovo",
                Price = 15200
            };
            Console.WriteLine(laptops[1].ToString());*/

            Employee emploee1 = new Employee("Иванов Иван", new DateTime(1995, 5, 12), "+79125485468", "ivanov@mail.ru",
                "Программист", 50000);
            Employee emploee2 = new Employee("Петров Петр", new DateTime(1997, 5, 15), "+79125487778", "petrov@mail.ru",
               "Программист", 45000);
            Console.WriteLine(emploee1.ToString());
            Console.WriteLine(emploee1.ToString());
            emploee2.Salary = emploee2 + 5000.0m;
            emploee2.Salary=emploee1.Salary;
            Console.WriteLine(emploee1.Equals(emploee2));



        }
    }

    public class A
    {
        public A(int Abc, float Bbc)
        {
            this.Abc = Abc;
            this.Bbc = Bbc;
        }
        public float Bbc { get; set; }
        public int Abc { get; set; }

        public static float operator +(A a, float b) { return a.Abc + b; }

        public static bool operator >(A a, A b)
        {
            if (a.Abc > b.Abc) return true;
            else return false;
        }

        public static bool operator <(A a, A b)
        {
            if (b.Abc > a.Abc) return true;
            else return false;
        }

        public static A operator ++(A a) { a.Abc++; return a; }
        public static A operator --(A a) { a.Abc--; return a; }
        public static A operator -(A a) { a.Abc = -a.Abc; return a; }

        public static bool operator true(A a) { return a.Abc > 0; }
        public static bool operator false(A a) { return a.Abc == 0; }
        public static A operator &(A a, A b) { return a; }
        //public static implicit operator Point (A a) { } // неявное преобразование
        //public static explicit operator Point(A a) { }  // явное преобразование
    }

    public class Point
    {
        public double X { get; set; }
        public double Y { get; set; }
        public Point() { }
        public static Point operator &(Point a, Point b)
        {
            if ((a.X != 0 && a.Y != 0) && (b.X != 0 && b.Y != 0))
            {
                return b;
            }
            return new Point();
        }
        public static bool operator true(Point p)
        {
            return p.X != 0 || p.Y != 0 ? true : false;
        }

        public static bool operator false(Point p)
        {
            return p.X == 0 && p.Y == 0 ? false : true;
        }
    }

  

  
    class Rectangle 
    {
        public int Wight { get; set; }
        public int Height { get; set; }
        public Rectangle(int wight, int height)
        {
            Wight = wight;
            Height = height;
        }

        public static implicit operator Rectangle(Square s) 
        {
            return new Rectangle(s.Lenght * 2,s.Lenght);
        }
    }

    class Square 
    {
        public int Lenght { get; set; }
    }

    public class Laptop
    {
        public string Vendor { get; set; }
        public double Price { get; set; }

        public override string ToString()
        {
            return $"{Vendor} {Price}";
        }
    }

    public class Shop
    {
        Laptop[] laptopArr;

        public Shop(int size)
        {
            laptopArr = new Laptop[size];
        }
        public Laptop this[int index]
        {
            
            get
            {
                if (index >= 0 && index < laptopArr.Length)
                {
                    return laptopArr[index];
                }
                throw new IndexOutOfRangeException();
            }
            set
            {
                laptopArr[index] = value;
            }
        }
    }


}
