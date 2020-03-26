using System;

namespace example_modularization
{
    class Program
    {
        static void Main(string[] args)
        {
            //Step 1
            string [] groceryListItems = {"Nuts", "Fish", "Lentils", "Whole Grains", "Beans", "Olive Oil", "Eggs", "Yogurt"};
            double [] groceryListItemsPrice = {.75, 3.00, 2.00, 1.00, 1.75, 7.49, 4.00, 1.29};
            int userInput;

            outputList(groceryListItems);
            userInput = userSelection();
            outputPrice(userInput, groceryListItems, groceryListItemsPrice);
        }
        //Step 2

        public static void outputList(string [] groceryList){
            for(int x=0; x < groceryList.Length; x++){
                Console.WriteLine($"Enter {x} for {groceryList[x]}");
            }
        }

        //Step 3
        public static int userSelection(){
            int userInput;
            Console.WriteLine("Input a grocery list item");
            userInput=Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"You enter item number {userInput}");

            return userInput;

        }
        //Extra
        public static void outputPrice(int userInput, string [] names, double [] price){
            Console.WriteLine($"You enter item {userInput} {names[userInput]} for price of {price[userInput].ToString("c")}");

        }
    }
}
