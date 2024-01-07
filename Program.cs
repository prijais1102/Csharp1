namespace Assignment1a
{
    internal class Program
    {
        static void Main(string[] args)
        {   //1
            Console.WriteLine("Hello");
            //2
            int a, b;
            Console.WriteLine("Enter two nos.");
            a = int.Parse(Console.ReadLine());
            b = int.Parse(Console.ReadLine());

            int sum = Add(a, b);
            Console.WriteLine($"sum is {sum}");
            int diff = Sub(a, b);
            Console.WriteLine($"diff is {diff}");
            int prod = Mul(a, b);
            Console.WriteLine($"prod is {prod}");
            int quo = Div(a, b);
            Console.WriteLine($"quo is {quo}");
            //3
            Console.WriteLine("1.Add/n 2.Sub/n 3.Mul/n 4.Div");
            Console.WriteLine("Enter your choice:");
            int ch = int.Parse(Console.ReadLine());
            switch (ch)
            {
                case 1: Console.WriteLine(a + b); break;
                case 2: Console.WriteLine(a - b); break;
                case 3: Console.WriteLine(a * b); break;
                case 4: Console.WriteLine(a / b); break;
                default: Console.WriteLine("Wrong choice");break;

            }
            //4
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Priya");
            }
            //5
            Even();
            //6
            Odd();
            //7
            Console.WriteLine("\nEnter a no.");
            int n=int.Parse(Console.ReadLine());
            Table(n);
            //8
            for(int  i = 100;i > 5;i -= 3)
            {
                Console.WriteLine(i);
            }
            //9
            int first,second,third;
            Console.WriteLine("Enter three nos.");
            first = int.Parse(Console.ReadLine());
            second = int.Parse(Console.ReadLine());
            third = int.Parse(Console.ReadLine());
            Console.WriteLine("Display integer variables in one line");
            Console.WriteLine($"{first} {second} {third}");
            //10
            Console.WriteLine("Display integer variables in separate lines");
            Console.WriteLine(first);
            Console.WriteLine(second);
            Console.WriteLine(third);    


        }
        static void Even()
        {
            Console.WriteLine("Even nos. b/w 1 to 10");
            Console.WriteLine("Using for loop");
                for (int j = 1; j <= 10; j++)
                {
                    if (j % 2 == 0)
                        Console.Write(j + " ");
                }
                Console.WriteLine("\nUsing while loop");
                int k = 1;
                while (k <= 10)
                {
                    if (k % 2 == 0)
                    {
                        Console.Write(k + " ");
                    }
                    k++;
                }
                Console.WriteLine("\nUsing do-while loop");
                int l = 1;
                do
                {
                    if (l % 2 == 0)
                        Console.Write(l + " ");
                    l++;

                } while (l <= 10);
        }
            static void Odd()
            {
                Console.WriteLine("\nOdd nos. b/w 1 to 10");
                Console.WriteLine("\nUsing for loop");
                for (int j = 1; j <= 10; j++)
                {
                    if (j % 2 != 0)
                        Console.Write(j + " ");
                }
                Console.WriteLine("\nUsing while loop");
                int k = 1;
                while (k <= 10)
                {
                    if (k % 2 != 0)
                    {
                        Console.Write(k + " ");
                    }
                    k++;
                }
                Console.WriteLine("\nUsing do-while loop");
                int l = 1;
                do
                {
                    if (l % 2 != 0)
                        Console.Write(l + " ");
                    l++;

                } while (l <= 10);
            }
        static void Table(int n)
        {
            Console.WriteLine($"Table of{n}");
            Console.WriteLine("Using for loop");
            for(int i = 1; i <= 10; i++)
            {
                Console.WriteLine(n + "* "+i+"="+(n*i));
            }
            Console.WriteLine("Using while loop");
            int j = 1;
            while(j <= 10)
            {
                Console.WriteLine(n + "* " + j + "=" + (n * j));
                j++;
            }
            Console.WriteLine("Using do-while loop");
            int k = 1;
            do
            {
                Console.WriteLine(n + "* " + k + "=" + (n * k));
                k++;

            }while (k <= 10);

        }

        static int Add(int a, int b)
        {
            return a + b;
        }
        static int Sub(int a, int b)
        {
            return a - b;
        }
        static int Mul(int a, int b)
        {
            return a * b;
        }
        static int Div(int a, int b)
        {
            return a / b;
        }


    }

    }
