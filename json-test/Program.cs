using System;
using System.IO;
using System.Text.Json; 

namespace json_test
{
    class Program
    {
        static void Main(string[] args)
        {

            Fighter f1 = new Fighter();
            string healthChosen = null; 

            if(File.Exists(@"FighterJSon")){

            }
            else{
                 Console.WriteLine("Choose name");

                 f1.Name =  Console.ReadLine();

                Console.WriteLine("Write what weapon they use");

                f1.WeaponUsed = Console.ReadLine();
           
                System.Console.WriteLine("What's their hp?");

                 healthChosen = Console.ReadLine();

                 bool tryParse = int.TryParse(healthChosen, out int healthInt);

                     while(tryParse != true){
                        System.Console.WriteLine("not a number. Write again");

                        healthChosen = Console.ReadLine();
                        tryParse = int.TryParse(healthChosen, out  healthInt);
                         f1.Health = healthInt; 
                    }

            }

            
            

           

           
           
            



            string jsonFile = JsonSerializer.Serialize<Fighter>(f1);

            File.WriteAllText(@"FighterJson.json", jsonFile);

            Console.ReadLine();
            
            

        }
    }
}
