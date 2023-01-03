using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroduccionC
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello world");
            //string[] coffeTypes;
            //float[] coffeValues;

            //coffeTypes = new string[] { "expresso", "Largo", "Filtrando", "Latte" };
            //coffeValues = new float[] { 1.2f, 1.5f, 5.0f, 5.5f };

            //for (int i = 0; i < coffeTypes.Length; i++)
            //{
            //    Console.WriteLine(coffeTypes[i] + "its length is : " + coffeValues[i]);

            //}

            //List<string> tacoShoppingList = new List<string>();
            //tacoShoppingList.Add("cinco tacos");

            //tacoShoppingList.Add("cinco tacos otro");
            //tacoShoppingList.Add("cinco tacos otro2");

            //for (int i = 0; i < tacoShoppingList.Count; i++)
            //{
            //    Console.WriteLine(tacoShoppingList[i]);
            //}
            //clase 16 metodos

            float[]  pricesArray =  new float[10];
            pricesArray[0] = 1.5f;
            pricesArray[1] = 2.5f;
            pricesArray[2] = 3f;
            
            pricesArray[4] = 5f;
            Random rnd = new Random();
            Console.WriteLine("Hello world");
            Console.WriteLine($"{rnd.Next(1,10)}"); 
            
        }
    }
}
