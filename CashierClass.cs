using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicQueuingCashier
{
    public static class CashierClass
    {
        public static Queue<string> CashierQueue = new Queue<string>();
        public static string GetNextInQueue()
        {
            if (CashierQueue.Count > 0)
            {
                return CashierQueue.Dequeue();
            }
            return null;
        }

        /*private int x;
        public static string getNumberInQueue = "";
        public static Queue<string> CashierQueue;
        public CashierClass()
        {
            x = 10000;
            CashierQueue = new Queue<string>();
        }
        public string CashierGeneratedNumber(string CashierNumber)
        {
            x++;
            CashierNumber = CashierNumber + x.ToString();
            return CashierNumber;
        }*/
    } 
}
