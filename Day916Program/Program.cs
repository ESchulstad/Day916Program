using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day916Program
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            List<int> list = new List<int>();
            list.Add(1);
            list.Add(2);
            list.Add(3);
            list.Add(4);
            list.Add(5);
            


            string[] arr = new string[4];
            arr[0] = "chocolate";
            arr[1] = "vanilla";
            arr[2] = "strawberry";
            arr[3] = "lemon";

            List<string> iceCream = arr.ToList();
            Console.WriteLine(iceCream.Count);

            string[] convertedArray = iceCream.ToArray();
            

            List<string> favAnimal = new List<string>() { "cats", "elephants", "dophins", "zebras","giraffs" };
            
            foreach(string currentVal in favAnimal)
            {
                Console.WriteLine(currentVal);
            }
            */

            Dictionary<string, int> zooAnimals = new Dictionary<string, int>()
            {
                { "Lions",7 }, {"Elephants",4 }, {"Dragons",-1 }, {"Wolves",12 }
            };

            zooAnimals.Add("Bears", 2);

            Console.WriteLine(zooAnimals["Bears"]); 
            
            

        }
    }
}
