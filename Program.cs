using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace AddQueue
{
    
    public class Program
    {
        
        static void Main(string[] args)
        {
            string[] strAddValues = new string[] { "This is String 1", "This is String 2", "This is String 3" };

            Queue queueobjects = new Queue();
            
            for(int i=0;i<strAddValues.Length;i++)
                queueobjects.AddUsers(strAddValues[i]);

            
            Console.ReadKey();
        }
    }


}



   
