using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Lunacat
{
    public class FinanceManager : Singleton<FinanceManager>
    {

        int balance; 
        public int Balance
        {
            get { return balance; }
        }

        public void Pay(int price)
        {
            if(balance < price)
            {
                Debug.LogWarning("No enough money.");
                return;
            }

            balance -= price;
        }

     
    }

}
