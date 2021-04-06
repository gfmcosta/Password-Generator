using System;

namespace Password_Generator
{

    class Program
    {
        static public void Menu()
        {
            Console.Title = "Password Generator v1.0";
            string resposta;
            Console.WriteLine("Password Generator");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("Menu");
            Console.WriteLine("");
            Console.WriteLine("1 - Password Random");
            Console.WriteLine("2 - Password App/Site");
            Console.WriteLine("3 - Show Passwords");
            Console.WriteLine("4 - Add Passwords");
            Console.WriteLine("5 - Edit Passwords");
            Console.WriteLine("6 - Delete Passwords");
            Console.WriteLine("7 - Exit");

            Console.WriteLine("");
            Console.Write("Answer: ");
            resposta = Console.ReadLine();

            switch (resposta)
            {
                case "1":
                    Console.Clear();
                    PasswordRandomGenerator();
                    break;
                case "2":
                    Console.Clear();
                    PasswordAppSite();
                    break;
                case "3":
                    Console.Clear();
                    //fazer sub
                    MostrarPasswords();
                    break;
                case "4":
                    Console.Clear();
                    //add
                    break;
                case "7":
                    Environment.Exit(0);
                    break;
                default:
                    Console.Clear();
                    Console.WriteLine("You haven't selected any option. Do you want to return to the Menu? (Y,N)");
                    String rp;
                    rp = Console.ReadLine();
                    if (rp == "Y" || rp == "y")
                    {
                        Console.Clear();
                        System.Diagnostics.Process.Start(System.AppDomain.CurrentDomain.FriendlyName);
                        Environment.Exit(0);
                    }
                    else
                    {
                        Environment.Exit(0);
                    }
                    break;
            }
        }
        static public void MostrarPasswords()
        {
            
        }
        static public void AdicionarPasswords()
        {

        }
        static public string Shuffle(string str)
        {
            char[] array = str.ToCharArray();
            Random rng = new Random();
            int n = array.Length;
            while (n > 1)
            {
                n--;
                int k = rng.Next(n + 1);
                if (n % 2 == 0)
                {
                    array[k] = Char.ToUpper(array[k]);
                }
                else
                {
                    array[k] = Char.ToLower(array[k]);
                }

                var value = array[k];
                array[k] = array[n];
                array[n] = value;
            }
            return new string(array);
        }
        static public void PasswordAppSite()
        {
            String rl;
            String App;
            String final;
            Console.Title = "Password Generator v1.0 - PasswordAppSite";
            Console.WriteLine("PasswordAppSite");
            Console.WriteLine("");
            Console.WriteLine("Select the App/Site");
            Console.Write("Answer: ");
            App = Console.ReadLine();
            Console.WriteLine();
            App = App.ToUpper();
            Console.WriteLine("Enter your password");
            Console.Write("Your password: ");
            rl = Console.ReadLine();
            Console.WriteLine();
            char[] array = App.ToCharArray();
            final = array[0].ToString();
            final += rl;
            final += array[App.Length-1].ToString();
            Console.Write("Password generated: "+ final);
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Do you want to return to the Menu? (Y,N)");
            String rp;
            rp = Console.ReadLine();
            if (rp == "Y" || rp == "y")
            {
                Console.Clear();
                System.Diagnostics.Process.Start(System.AppDomain.CurrentDomain.FriendlyName);
                Environment.Exit(0);
            }
            else
            {
                Environment.Exit(0);
            }



        }
        static public void PasswordRandomGenerator()
        {
            String rl;
            Console.Title = "Password Generator v1.0 - PasswordRandomGenerator";
            Console.WriteLine("PasswordRandomGenerator");
            Console.WriteLine("");
            Console.WriteLine("Enter a word if you prefer or press Enter");
            Console.WriteLine("");
            Console.Write("Your Password: ");
            rl = "";
            ConsoleKeyInfo info = Console.ReadKey(true);
            while (info.Key != ConsoleKey.Enter)
            {
                if (info.Key != ConsoleKey.Backspace)
                {
                    rl += info.KeyChar;
                    info = Console.ReadKey(true);
                }
                else if (info.Key == ConsoleKey.Backspace)
                {
                    if (!string.IsNullOrEmpty(rl))
                    {
                        rl = rl.Substring
                        (0, rl.Length - 1);
                    }
                    info = Console.ReadKey(true);
                }
            }
            for (int i = 0; i < rl.Length; i++)
                Console.Write("*");
                Console.WriteLine();
            if (rl == "" || rl==null)
            {
                //nao tem palavra
                while (rl.Length <= 10)
                {
                    Random rnd = new Random();
                    char randomLetter = (char)rnd.Next('a', 'z');
                    rl += randomLetter;
                }
                Random rnd2 = new Random();
                int n = (int)rnd2.Next(0, 9);
                rl += n;
                n = (int)rnd2.Next(0, 9);
                rl += n;
                rl += "%";
                rl += "%";
                rl = Shuffle(rl);
                Console.Write("Password generated: " + rl);
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine("Do you want to return to the Menu? (Y,N)");
                String rp;
                rp = Console.ReadLine();
                if (rp == "Y" || rp == "y")
                {
                    Console.Clear();
                    System.Diagnostics.Process.Start(System.AppDomain.CurrentDomain.FriendlyName);
                    Environment.Exit(0);
                }
                else
                {
                    Environment.Exit(0);
                }
            }
            else
            {
                //se tem palavra
                if (rl.Length >= 10)
                {
                    Random rnd2 = new Random();
                    int n = (int)rnd2.Next(0, 9);
                    rl += n;
                    n = (int)rnd2.Next(0, 9);
                    rl += n;
                    rl += "%";
                    rl += "%";
                    rl = Shuffle(rl);
                    Console.Write("Password generated: " + rl);
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine("Do you want to return to the Menu? (Y,N)");
                    String rp;
                    rp = Console.ReadLine();
                    if (rp == "Y" || rp == "y")
                    {
                        Console.Clear();
                        System.Diagnostics.Process.Start(System.AppDomain.CurrentDomain.FriendlyName);
                        Environment.Exit(0);
                    }
                    else
                    {
                        Environment.Exit(0);
                    }
                }
                else
                {
                    while (rl.Length <= 10)
                    {
                        Random rnd = new Random();
                        char randomLetter = (char)rnd.Next('a', 'z');
                        rl += randomLetter;
                    }
                    Random rnd2 = new Random();
                    int n = (int)rnd2.Next(0, 9);
                    rl += n;
                    n = (int)rnd2.Next(0, 9);
                    rl += n;
                    rl += "%";
                    rl += "%";
                    rl = Shuffle(rl);
                    Console.Write("Password generated: " + rl);
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine("Do you want to return to the Menu? (Y,N)");
                    String rp;
                    rp = Console.ReadLine();
                    if (rp == "Y" || rp == "y")
                    {
                        Console.Clear();
                        System.Diagnostics.Process.Start(System.AppDomain.CurrentDomain.FriendlyName);
                        Environment.Exit(0);
                    }
                    else
                    {
                        Environment.Exit(0);
                    }


                }

            }
        }
        static void Main(string[] args)
        {
            Menu();
        }
        

    }
}
