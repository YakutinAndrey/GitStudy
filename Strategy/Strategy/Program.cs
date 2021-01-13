using System;

namespace Strategy
{
    class Program
    {
        static void Main(string[] args)
        {
            
            IDamage damager = null;

            while (true)
            {
                string option = Console.ReadLine();
                if (option == "1")
                    damager = new LegDamage();

                else if (option == "2")
                    damager = new HandDamage();

                else if (option == "3")
                    damager = new HeadDamage();
                else
                    break;

                damager.Kick();
               
            }
            
        
        }
    }
}
