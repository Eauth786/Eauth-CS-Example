using System;
using System.Threading;
using System.Security;

namespace Eauth_CS_Console_Example
{
    class Program
    {
        static void Main(string[] args)
        {
            string input;
            string username;
            string password;
            string invitecode;
            Console.WindowWidth = 45;
            Console.Title = " ";
            Load();
            void Load()
            {
                Console.ForegroundColor = ConsoleColor.DarkCyan;
                Console.WriteLine("███████╗░█████╗░██╗░░░██╗████████╗██╗░░██╗");
                Console.WriteLine("██╔════╝██╔══██╗██║░░░██║╚══██╔══╝██║░░██║");
                Console.WriteLine("█████╗░░███████║██║░░░██║░░░██║░░░███████║");
                Console.WriteLine("██╔══╝░░██╔══██║██║░░░██║░░░██║░░░██╔══██║");
                Console.WriteLine("███████╗██║░░██║╚██████╔╝░░░██║░░░██║░░██║");
                Console.WriteLine("╚══════╝╚═╝░░╚═╝░╚═════╝░░░░╚═╝░░░╚═╝░░╚═╝");
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.WriteLine("█-Establishing connection with eauth...");
                eauth.init();
                Console.Title = eauth.ApplicationName;
                Console.WriteLine("[ 1 ] Login       |       [ 2 ] Register");
                Console.WriteLine();
                input = Console.ReadLine();
                switch (input)
                {

                    case "1":
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.DarkCyan;
                        Console.WriteLine("███████╗░█████╗░██╗░░░██╗████████╗██╗░░██╗");
                        Console.WriteLine("██╔════╝██╔══██╗██║░░░██║╚══██╔══╝██║░░██║");
                        Console.WriteLine("█████╗░░███████║██║░░░██║░░░██║░░░███████║");
                        Console.WriteLine("██╔══╝░░██╔══██║██║░░░██║░░░██║░░░██╔══██║");
                        Console.WriteLine("███████╗██║░░██║╚██████╔╝░░░██║░░░██║░░██║");
                        Console.WriteLine("╚══════╝╚═╝░░╚═╝░╚═════╝░░░░╚═╝░░░╚═╝░░╚═╝");
                        Console.ForegroundColor = ConsoleColor.Gray;
                        Console.WriteLine("█-Establishing connection with eauth...");
                        Console.WriteLine("█-Username:");
                        Console.ForegroundColor = ConsoleColor.Red;
                        username = Console.ReadLine();
                        Console.ForegroundColor = ConsoleColor.Gray;
                        Console.WriteLine("█-Password:");
                        Console.ForegroundColor = ConsoleColor.Red;
                        string login_pass = null;
                        ConsoleKeyInfo login_key;
                        do
                        {
                            login_key = Console.ReadKey(true);

                            if (login_key.Key != ConsoleKey.Backspace)
                            {
                                login_pass += login_key.KeyChar;
                                Console.Write("*");
                            }
                            else
                            {
                                Console.Write("\b \b");
                                char[] pas = login_pass.ToCharArray();
                                string temp = "";
                                for (int i = 0; i < login_pass.Length - 1; i++)
                                {
                                    temp += pas[i];
                                }
                                login_pass = temp;
                            }
                        }
                        while (login_key.Key != ConsoleKey.Enter);
                        password = login_pass.Substring(0, (login_pass.Length - 1));
                        Console.WriteLine();
                        eauth.signin(username, password);
                        Console.WriteLine();
                        Console.Clear();
                        if (eauth.login)
                        {
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine(eauth.Loggedmessage);
                            Console.WriteLine();
                            Console.ForegroundColor = ConsoleColor.Gray;
                            Console.WriteLine("Username: " + eauth.Username);
                            Console.WriteLine("Rank: " + eauth.Rank);
                            Console.WriteLine("Create Date: " + eauth.Createdate);
                            Console.WriteLine("Expire Date: " + eauth.Expiredate);
                            Console.WriteLine("Hardware ID: " + eauth.HardwareID);
                            //Console.WriteLine("Variable: " + eauth.grabvariable("your variable id here"));
                            Thread.Sleep(2500);
                            Console.Clear();
                            Load();
                        }
                        break;

                    case "2":
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.DarkCyan;
                        Console.WriteLine("███████╗░█████╗░██╗░░░██╗████████╗██╗░░██╗");
                        Console.WriteLine("██╔════╝██╔══██╗██║░░░██║╚══██╔══╝██║░░██║");
                        Console.WriteLine("█████╗░░███████║██║░░░██║░░░██║░░░███████║");
                        Console.WriteLine("██╔══╝░░██╔══██║██║░░░██║░░░██║░░░██╔══██║");
                        Console.WriteLine("███████╗██║░░██║╚██████╔╝░░░██║░░░██║░░██║");
                        Console.WriteLine("╚══════╝╚═╝░░╚═╝░╚═════╝░░░░╚═╝░░░╚═╝░░╚═╝");
                        Console.ForegroundColor = ConsoleColor.Gray;
                        Console.WriteLine("█-Establishing connection with eauth...");
                        Console.WriteLine("█-Username:");
                        Console.ForegroundColor = ConsoleColor.Red;
                        username = Console.ReadLine();
                        Console.ForegroundColor = ConsoleColor.Gray;
                        Console.WriteLine("█-Password:");
                        Console.ForegroundColor = ConsoleColor.Red;
                        string register_pass = null;
                        ConsoleKeyInfo register_key;
                        do
                        {
                            register_key = Console.ReadKey(true);

                            if (register_key.Key != ConsoleKey.Backspace)
                            {
                                register_pass += register_key.KeyChar;
                                Console.Write("*");
                            }
                            else
                            {
                                Console.Write("\b \b");
                                char[] pas = register_pass.ToCharArray();
                                string temp = "";
                                for (int i = 0; i < register_pass.Length - 1; i++)
                                {
                                    temp += pas[i];
                                }
                                register_pass = temp;
                            }
                        }
                        while (register_key.Key != ConsoleKey.Enter);
                        password = register_pass.Substring(0, (register_pass.Length - 1));
                        Console.WriteLine();
                        Console.ForegroundColor = ConsoleColor.Gray;
                        Console.WriteLine("█-License Key:");
                        Console.ForegroundColor = ConsoleColor.Red;
                        invitecode = Console.ReadLine();
                        eauth.signup(username, password, invitecode);
                        Console.WriteLine();
                        Console.Clear();
                        if (eauth.register)
                        {
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine(eauth.Registeredmessage);
                            Thread.Sleep(1000);
                            Console.Clear();
                            Load();
                        }
                        break;

                    default:
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Invalid input...");
                        Thread.Sleep(1000);
                        Console.Clear();
                        Load();
                        break;
                }
            }
            Console.ReadKey();
        }
        private static SecureString passwordChar()
        {
            SecureString passwordchar = new SecureString();
            ConsoleKeyInfo Keyinfo;
            do
            {
                Keyinfo = Console.ReadKey(true);
                if (!char.IsControl(Keyinfo.KeyChar))
                {
                    passwordchar.AppendChar(Keyinfo.KeyChar);
                    Console.WriteLine("*");
                }
                else if (Keyinfo.Key == ConsoleKey.Backspace && passwordchar.Length > 0)
                {
                    passwordchar.RemoveAt(passwordchar.Length - 1);
                    Console.Write("\b \b");
                }
            }
            while (Keyinfo.Key != ConsoleKey.Enter);
            {
                return passwordchar;
            }
        }
    }
}
