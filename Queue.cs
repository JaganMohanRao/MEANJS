using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;

namespace AddQueue
{
    public class Queue
    {
        private List<string> Users = new List<string>();
        
        public Queue()
        {
            
            TimerCallback tmCallback = RemoveSpecificItem;
            Timer timer = new Timer(RemoveSpecificItem, "Wait 1.5 Seconds", 1500, 1500);
            
        }

        private void RemoveSpecificItem(object state)
        {
            Console.WriteLine(Users.Count.ToString());

            if (Users.Count > 0)
            {

                Users.RemoveAt(0);
                Console.WriteLine("Removed the User at first index ");

            }

        }
          
        public void AddUsers(string strAddUser)
        {
            
            Users.Add(strAddUser);
            Console.WriteLine("User Added:{0}", strAddUser);
            
        }

        public void RemoveUsers(string strUser)
        {
            if (Users.Count > 0)
            {
                Users.Remove(strUser);
                Console.WriteLine("Removed the User :  {0}", strUser);
            }
        }

        
    }
}
