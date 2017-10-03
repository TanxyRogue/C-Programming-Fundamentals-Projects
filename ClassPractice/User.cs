using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassPractice;

namespace ClassPractice
{
    class User
    {
        //Static Variables
        static int IdCounter= 0;

        //Instance Variables
        public string UserName { get; }
        private string PassCode;
        private int IdNumber { get; }

        //Constructors
        public User(string UserName,string PassCode )
        {
            this.PassCode = PassCode;
            this.UserName = UserName;
            IdCounter++;
            IdNumber = IdCounter;

            Console.Clear();
            Console.WriteLine($"User {this.UserName} created!!!!");
            Console.WriteLine($"UserName: {this.UserName}\nPasscode: {this.PassCode}");
            Console.ReadKey();
        }

        //Operator Overloading
        public static bool operator==(User user1 , User user2)
        {
            bool currentState = false;

            if ((user1.UserName == user2.UserName)&&(user1.IdNumber == user2.IdNumber))
                currentState = true;

            return currentState;
        }
        public static bool operator !=(User user1, User user2)
        {
            bool currentState = true;

            if ((user1.UserName == user2.UserName) && (user1.IdNumber == user2.IdNumber))
                currentState = false;

            return currentState;
        }

        //Instance Methods
    }
}
