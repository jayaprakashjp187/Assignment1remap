using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_1
{
    internal class FriendsNames
    {
        public  FriendsNames()
        {
            string[] name = new string[5];
            name[0] = "jayaprakash";
            name[1] = "jayy";
            name[2] = "prakash";
            name[3] = "jaya";
            name[4] = "ugesh";
            foreach (string s in name)
            {
                Console.WriteLine(s);
            }


            
        }
    }
}