using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Costumer costumer1 = new Costumer();
            costumer1.CostumerId = 1;
            costumer1.CostumerName = "İsmail";
            costumer1.CostumerSurname = "Korkmaz";

            Costumer costumer2 = new Costumer();
            costumer2.CostumerId = 2;
            costumer2.CostumerName = "Şule";
            costumer2.CostumerSurname = "Korkmaz";

            Costumer costumer3 = new Costumer();
            costumer3.CostumerId = 3;
            costumer3.CostumerName = "Beyza";
            costumer3.CostumerSurname = "Korkmaz";

            Costumer[] costumers = new Costumer[]{costumer1, costumer2, costumer3};

            foreach (var costum in costumers)
            {
                Console.WriteLine(costum.CostumerId);
                Console.WriteLine(costum.CostumerName);
                Console.WriteLine(costum.CostumerSurname);
                Console.WriteLine("-----------------------");

            }
            Console.WriteLine("+++Costumer add+++");

            CostumerManager costumerManager = new CostumerManager();
            costumerManager.CostumerAdd(costumer1);
            costumerManager.CostumerAdd(costumer2);
            costumerManager.CostumerAdd(costumer3);
            Console.WriteLine("+++Costumer Delete+++");
            costumerManager.CostumerDel(costumer3);

            costumerManager.CostumerList(costumer3);


            Console.WriteLine("The End");
        }
    }
}
