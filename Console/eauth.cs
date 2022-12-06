using Newtonsoft.Json;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Net;
using System.Text;
using System;
using System.Threading;
using Microsoft.Win32;

namespace Eauth_CS_Console_Example
{
    class eauth
    {
        public const string ApplicationKey = ""; //requied
        public const string AccountKey = ""; //required

        static string tashfir(string sifr)
        {
            var bytes = System.Text.Encoding.UTF8.GetBytes(sifr);
            using (var hash = System.Security.Cryptography.SHA512.Create())
            {
                var hashedInputBytes = hash.ComputeHash(bytes);
                var hashedInputStringBuilder = new System.Text.StringBuilder(128);
                foreach (var b in hashedInputBytes)
                    hashedInputStringBuilder.Append(b.ToString("x2"));
                return hashedInputStringBuilder.ToString();
            }
        }
        static string wahid(string altashfir)
        {
            altashfir = altashfir.Replace("0", "-QZ-");
            altashfir = altashfir.Replace("1", "-SA-");
            altashfir = altashfir.Replace("2", "-IF-");
            altashfir = altashfir.Replace("3", "DE-");
            altashfir = altashfir.Replace("4", "-EE-");
            altashfir = altashfir.Replace("5", "-JJ-");
            altashfir = altashfir.Replace("6", "-GG-");
            altashfir = altashfir.Replace("7", "MP-");
            altashfir = altashfir.Replace("8", "-WI-");
            altashfir = altashfir.Replace("9", "-ZF-");
            altashfir = altashfir.Replace("a", "-XC-");
            altashfir = altashfir.Replace("b", "-YU-");
            altashfir = altashfir.Replace("c", "-OL-");
            altashfir = altashfir.Replace("d", "MV-");
            altashfir = altashfir.Replace("e", "-RS-");
            altashfir = altashfir.Replace("f", "-EV-");
            altashfir = altashfir.Replace("g", "-WZ-");
            altashfir = altashfir.Replace("h", "DP-");
            altashfir = altashfir.Replace("i", "-IJ-");
            altashfir = altashfir.Replace("j", "-KN-");
            altashfir = altashfir.Replace("k", "-CA-");
            altashfir = altashfir.Replace("l", "-TW-");
            altashfir = altashfir.Replace("m", "-BI-");
            altashfir = altashfir.Replace("n", "-JH-");
            altashfir = altashfir.Replace("o", "-MW-");
            altashfir = altashfir.Replace("p", "-IS-");
            altashfir = altashfir.Replace("q", "-LA-");
            altashfir = altashfir.Replace("r", "-ME-");
            altashfir = altashfir.Replace("s", "-EP-");
            altashfir = altashfir.Replace("t", "-ON-");
            altashfir = altashfir.Replace("u", "-WK-");
            altashfir = altashfir.Replace("v", "-NB-");
            altashfir = altashfir.Replace("w", "-BA-");
            altashfir = altashfir.Replace("x", "-RE-");
            altashfir = altashfir.Replace("y", "-IN-");
            altashfir = altashfir.Replace("z", "-LU-");
            return altashfir;
        }
        static string aithnayn(string tabadal)
        {
            tabadal = tabadal.Replace("-QZ-", "0");
            tabadal = tabadal.Replace("-SA-", "1");
            tabadal = tabadal.Replace("-IF-", "2");
            tabadal = tabadal.Replace("DE-", "3");
            tabadal = tabadal.Replace("-EE-", "4");
            tabadal = tabadal.Replace("-JJ-", "5");
            tabadal = tabadal.Replace("-GG-", "6");
            tabadal = tabadal.Replace("MP-", "7");
            tabadal = tabadal.Replace("-WI-", "8");
            tabadal = tabadal.Replace("-ZF-", "9");
            tabadal = tabadal.Replace("-XC-", "a");
            tabadal = tabadal.Replace("-YU-", "b");
            tabadal = tabadal.Replace("-OL-", "c");
            tabadal = tabadal.Replace("MV-", "d");
            tabadal = tabadal.Replace("-RS-", "e");
            tabadal = tabadal.Replace("-EV-", "f");
            tabadal = tabadal.Replace("-WZ-", "g");
            tabadal = tabadal.Replace("DP-", "h");
            tabadal = tabadal.Replace("-IJ-", "i");
            tabadal = tabadal.Replace("-KN-", "j");
            tabadal = tabadal.Replace("-CA-", "k");
            tabadal = tabadal.Replace("-TW-", "l");
            tabadal = tabadal.Replace("-BI-", "m");
            tabadal = tabadal.Replace("-JH-", "n");
            tabadal = tabadal.Replace("-MW-", "o");
            tabadal = tabadal.Replace("-IS-", "p");
            tabadal = tabadal.Replace("-LA-", "q");
            tabadal = tabadal.Replace("-ME-", "r");
            tabadal = tabadal.Replace("-EP-", "s");
            tabadal = tabadal.Replace("-ON-", "t");
            tabadal = tabadal.Replace("-WK-", "u");
            tabadal = tabadal.Replace("-NB-", "v");
            tabadal = tabadal.Replace("-BA-", "w");
            tabadal = tabadal.Replace("-RE-", "x");
            tabadal = tabadal.Replace("-IN-", "y");
            tabadal = tabadal.Replace("-LU-", "z");
            return tabadal;
        }
        public const string URL = "https://www.eauth.gq/api/";
        public static readonly WebClient authreq = new WebClient();
        public static string Username = null;
        public static string Password = null;
        public static string Createdate = null;
        public static string HardwareID = null;
        public static string Expiredate = null;
        public static string Rank = null;
        public static string Status = null;
        public static string ApplicationName = null;
        public static string Loggedmessage = null;
        public static string Registeredmessage = null;
        public static string Pausedmessage = null;
        public static string initresult = null; public static bool initB = false;
        public static string loginresult = null;
        public static string registerresult = null;
        public static string varresult = null;
        public static void init()
        {
            try
            {
                WebClient cs_web = new WebClient();
                cs_web.DownloadString(URL);
            }
            catch
            {
                Environment.Exit(0);
            }
            string hwid = null;
            string location = @"SOFTWARE\Microsoft\Cryptography";
            string h_name = "MachineGuid";
            using (RegistryKey localMachineX64View = RegistryKey.OpenBaseKey(RegistryHive.LocalMachine, RegistryView.Registry64))
            {
                using (RegistryKey regkey = localMachineX64View.OpenSubKey(location))
                {
                    if (regkey == null)
                        Environment.Exit(0);
                    object m_Guid = regkey.GetValue(h_name);
                    if (m_Guid == null)
                        Environment.Exit(0);
                    hwid = m_Guid.ToString();
                }
            }
            using (authreq)
            {
                NameValueCollection appData = new NameValueCollection()
                {
                    { "s0rt", wahid("init") },
                    { "111110", wahid(eauth.ApplicationKey) },
                    { "001011", wahid(eauth.AccountKey) },
                    { "011001", wahid(hwid) }
                };
                initresult = Encoding.UTF8.GetString(authreq.UploadValues(URL, appData));
            }
            if (aithnayn(initresult) == "incorrect_application_details")
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Incorrect application details!");
                Thread.Sleep(1000);
                Environment.Exit(0);
            }
            else if (aithnayn(initresult) == "down")
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Eauth is down at the moment, come back later!");
                Thread.Sleep(1000);
                Environment.Exit(0);
            }
            else if (aithnayn(initresult) == "banned_user")
            {
                Environment.Exit(0);
            }
            else if (aithnayn(initresult) == null)
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Oops, something went wrong!");
                Thread.Sleep(1000);
                Environment.Exit(0);
            }
            List<init_a> json_decode = JsonConvert.DeserializeObject<List<init_a>>(initresult);
            foreach (var app_info in json_decode)
            {
                Status = aithnayn(app_info.STATUS);
                ApplicationName = aithnayn(app_info.APPNAME);
                Loggedmessage = aithnayn(app_info.LOGGED);
                Registeredmessage = aithnayn(app_info.REGISTERED);
                Pausedmessage = aithnayn(app_info.PAUSED);
            }
            if (Status != "1")
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(Pausedmessage);
                Thread.Sleep(1000);
                Environment.Exit(0);
            }
            else
            {
                initB = true;
            }
        }
        public static void signin(string username, string password)
        {
            try
            {
                WebClient cs_web = new WebClient();
                cs_web.DownloadString(URL);
            }
            catch
            {
                Environment.Exit(0);
            }
            if (!initB)
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Unable to take action, make sure you've init in beginning");
                Thread.Sleep(1000);
                Environment.Exit(0);
            }
            login = false;
            string name = username;
            string pass = password;
            string hwid = null;
            string location = @"SOFTWARE\Microsoft\Cryptography";
            string h_name = "MachineGuid";
            using (RegistryKey localMachineX64View = RegistryKey.OpenBaseKey(RegistryHive.LocalMachine, RegistryView.Registry64))
            {
                using (RegistryKey regkey = localMachineX64View.OpenSubKey(location))
                {
                    if (regkey == null)
                        Environment.Exit(0);
                    object m_Guid = regkey.GetValue(h_name);
                    if (m_Guid == null)
                        Environment.Exit(0);
                    hwid = m_Guid.ToString();
                }
            }
            using (authreq)
            {
                string hPass = tashfir(pass);
                NameValueCollection loginData = new NameValueCollection()
                {
                    { "s0rt", wahid("l0gin") },
                    { "username", wahid(name) },
                    { "passw0rd", wahid(hPass) },
                    { "hwid", wahid(hwid) },
                    { "appkey", wahid(eauth.ApplicationKey) },
                    { "acckey", wahid(eauth.AccountKey) }
                };
                loginresult = Encoding.UTF8.GetString(authreq.UploadValues(URL, loginData));
            }
            if (aithnayn(loginresult) == "incorrect_login_details")
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Incorrect login details!");
                Thread.Sleep(1000);
                Environment.Exit(0);
            }
            else if (aithnayn(loginresult) == "incorrect_user_details")
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Incorrect login details!");
                Thread.Sleep(1000);
                Environment.Exit(0);
            }
            else if (aithnayn(loginresult) == "hwid_does_not_match")
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Hwid doesn't match!");
                Thread.Sleep(1000);
                Environment.Exit(0);
            }
            else if (aithnayn(loginresult) == "subscription_has_expired")
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Your subscription has expired!");
                Thread.Sleep(1000);
                Environment.Exit(0);
            }
            List<deserializeclass> json_decode = JsonConvert.DeserializeObject<List<deserializeclass>>(loginresult);
            foreach (var user_info in json_decode)
            {
                Username = aithnayn(user_info.NAME);
                Rank = aithnayn(user_info.RANKUSER);
                Createdate = aithnayn(user_info.CREATEDATE);
                Expiredate = aithnayn(user_info.EXPIREDATE);
                HardwareID = hwid;
            }
            login = true;
        }
        public static void signup(string username, string password, string invitecode)
        {
            try
            {
                WebClient cs_web = new WebClient();
                cs_web.DownloadString(URL);
            }
            catch
            {
                Environment.Exit(0);
            }
            if (!initB)
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Unable to take action, make sure you've init in beginning");
                Thread.Sleep(1000);
                Environment.Exit(0);
            }
            register = false;
            string name = username;
            string pass = password;
            string invite = invitecode;
            string hwid = null;
            string location = @"SOFTWARE\Microsoft\Cryptography";
            string h_name = "MachineGuid";
            using (RegistryKey localMachineX64View = RegistryKey.OpenBaseKey(RegistryHive.LocalMachine, RegistryView.Registry64))
            {
                using (RegistryKey regkey = localMachineX64View.OpenSubKey(location))
                {
                    if (regkey == null)
                        Environment.Exit(0);
                    object m_Guid = regkey.GetValue(h_name);
                    if (m_Guid == null)
                        Environment.Exit(0);
                    hwid = m_Guid.ToString();
                }
            }
            using (authreq)
            {
                string hPass = tashfir(pass);
                NameValueCollection registerData = new NameValueCollection()
                {
                    { "s0rt", wahid("register") },
                    { "username", wahid(name) },
                    { "passw0rd", wahid(hPass) },
                    { "invite", wahid(invite) },
                    { "hwid", wahid(hwid) },
                    { "appkey", wahid(eauth.ApplicationKey) },
                    { "acckey", wahid(eauth.AccountKey) }
                };
                registerresult = Encoding.UTF8.GetString(authreq.UploadValues(URL, registerData));
            }
            if (aithnayn(registerresult) == "name_already_used")
            {
                Console.Clear();
                Console.WriteLine("Name already used!");
                Thread.Sleep(1000);
                Environment.Exit(0);
            }
            else if (aithnayn(registerresult) == "incorrect_register_details")
            {
                Console.Clear();
                Console.WriteLine("Incorrect register details!");
                Thread.Sleep(1000);
                Environment.Exit(0);
            }
            else if (aithnayn(registerresult) == "key_not_found")
            {
                Console.Clear();
                Console.WriteLine("Key not found!");
                Thread.Sleep(1000);
                Environment.Exit(0);
            }
            else if (aithnayn(registerresult) == "maximum_users")
            {
                Console.Clear();
                Console.WriteLine("The Application reached maximum users, it's time for an upgrade!");
                Thread.Sleep(1000);
                Environment.Exit(0);
            }
            register = true;
        }
        public static string grabvariable(string varid)
        {
            try
            {
                WebClient cs_web = new WebClient();
                cs_web.DownloadString(URL);
            }
            catch
            {
                Environment.Exit(0);
            }
            if (!initB)
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Unable to take action, make sure you've init in beginning");
                Thread.Sleep(1000);
                Environment.Exit(0);
            }
            using (authreq)
            {
                NameValueCollection registerData = new NameValueCollection()
                {
                    { "s0rt", wahid("var") },
                    { "varid", wahid(varid) },
                    { "appkey", wahid(eauth.ApplicationKey) },
                    { "acckey", wahid(eauth.AccountKey) }
                };
                varresult = Encoding.UTF8.GetString(authreq.UploadValues(URL, registerData));
            }
            if (aithnayn(varresult) == "var_not_found")
            {
                varresult = ">_<";
            }
            else if (aithnayn(varresult) == "incorrect_application_details")
            {
                Environment.Exit(0);
            }
            return aithnayn(varresult);
        }
        public class init_a
        {
            public string STATUS { get; set; }
            public string APPNAME { get; set; }
            public string LOGGED { get; set; }
            public string REGISTERED { get; set; }
            public string PAUSED { get; set; }
        }
        public class deserializeclass
        {
            public string NAME { get; set; }
            public string CREATEDATE { get; set; }
            public string RANKUSER { get; set; }
            public string EXPIREDATE { get; set; }
        }
        public static bool login = false;
        public static bool register = false;
    }
}
