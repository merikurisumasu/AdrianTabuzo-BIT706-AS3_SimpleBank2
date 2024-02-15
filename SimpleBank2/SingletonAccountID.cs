using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleBank2
{
    [Serializable]
    public class SingletonAccountID
    {
        private int nextAccountID;
        private static SingletonAccountID myInstance;

        public static int NextAccountID
        {
            get
            {
                myInstance.nextAccountID++;
                return myInstance.nextAccountID;
            }
        }

        public static SingletonAccountID getInstance()
        {
            if (myInstance == null)
            {
                myInstance = new SingletonAccountID();
            }

            return myInstance;
        }

        public static void setInstance(SingletonAccountID s)
        {
            myInstance = s;
        }

        private SingletonAccountID() { }
    }
}
