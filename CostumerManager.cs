using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class CostumerManager
    {
        public void CostumerAdd(Costumer costumer)
        {

            Console.WriteLine("Tebrikler. Müşteri eklendi...        " + costumer.CostumerName);
        }
        public void CostumerDel(Costumer costumer)
        {
            Console.WriteLine("Tebrikler. Müşteri silindi...        "+ costumer.CostumerName);
        }

        public void CostumerList(Costumer costumer)
        {
            Console.WriteLine(costumer.CostumerId + "-----" +costumer.CostumerName + " " + costumer.CostumerSurname);
        }
        
    }
}
