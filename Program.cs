using System;

namespace Dictionary
{
    class Program
    {
        static void Main(string[] args)
        {

            MyDictionary<int, string> productCategories = new MyDictionary<int, string>();
            productCategories.Add(0, "Home Textile");
            productCategories.Add(1, "Fashion");
            productCategories.Add(2, "Lightning");
            productCategories.Add(3, "Furniture");

            productCategories.ToList();

        }
    }
}
