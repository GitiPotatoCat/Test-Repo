using static System.Console;

namespace FruitExample
{
    public class FruitExample
    {
        static void Main()
        {
            List<string> fruits = new List<string> { "Avocado", "PineApple", "Orange", "Mango", "Pomegranate" };

            WriteLine(fruits);
            for (int i = 0; i < fruits.Count; i++)
            {
                WriteLine("{0}: {1}", i, fruits[i]);
            }


            // Adding new item in the list
            fruits.Add("Apple");
            WriteLine("\nAfter Adding new fruit:");
            WriteLine(fruits);
            for (int i = 0; i < fruits.Count; i++)
            {
                WriteLine("{0}: {1}", i, fruits[i]);
            }
        }
    }
}