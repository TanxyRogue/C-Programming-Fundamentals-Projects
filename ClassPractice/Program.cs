using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassPractice
{
    class Program
    {
        //The Main Entrance
        static void Main(string[] args)
        {
            bool response = UserYesorNoPrompt("Do You Want To Sign Up For The Service (Y or N)");
            if (response)
                UserSignUp();
            else
                ShutDown();
            
                       
        }

        //Static Methods
        
        public static void ShutDown()
        {
            Console.Clear(); Console.Beep();
            TimeSpan.FromSeconds(14);
            
            Console.WriteLine("SHUTTING DOWN!!!!!");
            Wait(1);
            Console.WriteLine("3...");
            Wait(1);
            Console.WriteLine("2..");
            Wait(1);
            Console.WriteLine("1.");
            Wait(1);
            Console.WriteLine("Shutting Down!!!!!!");
            Wait(1);
            Environment.Exit(0);
        }
        private static void Wait(int delayUnits)
        {
            var ClockBegin = DateTime.Now;

            while (!(DateTime.Now.Second - ClockBegin.Second >= delayUnits))
            {

            }
        }
        private static string GetUserNameFromUser()
        {
            //Just starting afresh
            Console.Clear();

            Start1:
            string userName;
            Console.WriteLine("Please Enter A UserName [Case Sensitive]");
            userName = Console.ReadLine();
            if (userName.Length <= 7)
            {
                Console.WriteLine();
                Console.Beep();
                Console.WriteLine("ERROR User Name Cannot be less than 7 characters long.\nTry Again");
                Console.ReadKey();
                Console.Clear();
                goto Start1;
            }
            userName = RemoveChar(userName, new[] { ' ', '.', ',' });

            Console.WriteLine("Allowed userName is " + userName);


            UserYesorNoPrompt("Do you accept UserName and Move (Y or N)");

            return userName;
        }
        private static string GetPassCode()
        {
            //Just starting afresh
            Console.Clear();

            Start1:
            string passCode;
            Console.WriteLine("Please Enter A PassCode");
            passCode = Console.ReadLine();
            if (passCode.Length != 4)
            {
                Console.WriteLine();
                Console.Beep();
                Console.WriteLine("ERROR!!!!! Pass Code mus be 4 numbers long.\nTry Again");
                Console.ReadKey();
                Console.Clear();
                goto Start1;
            }
            RemoveChar(passCode, new[] { ' ', '.', ',' });

            Console.WriteLine("Allowed passCode is " + passCode);


            UserYesorNoPrompt("Do you accept Passcode and Move (Y or N)");

            return passCode;
        }
        private static bool UserYesorNoPrompt(string prompt)
        {
            string Reply;
            bool userResponse=false;
            LoopBegin:
            Console.WriteLine(prompt);
            Reply = Console.ReadLine();
            RemoveChar(Reply, new[] { ' ', '.', ',' });

            if (Reply.Length > 1)
            {
                Console.WriteLine("Please Enter 'Y' or 'N' only");
                goto LoopBegin;
            }
            if (!(Reply.ToUpper() == "Y") && !(Reply.ToUpper() == "N"))
            {
                Console.WriteLine("Please Enter either 'Y' or 'N' ");
                goto LoopBegin;
            }
            if (Reply.ToUpper() == "Y")
                userResponse = true;
            if (Reply.ToUpper() == "N")
                userResponse = false;
            return userResponse;

        }
        private static void UserSignUp()
        {
            string _userName = GetUserNameFromUser();
            string _passCode = GetPassCode() ;
            var user1 = new User(_userName,_passCode) ;


        }
        private static string RemoveChar(string s , char[] remove)
        {
            string[] word = s.Split(remove, StringSplitOptions.RemoveEmptyEntries);
            s = "";
            foreach (var w in word)
                s += w;
            return s;
        }

    }
}
