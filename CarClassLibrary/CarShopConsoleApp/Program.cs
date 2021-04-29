using CarClassLibrary;
using System;

namespace CarShopConsoleApp
{
    class Program
    {
        static void Main(string [] args)
        {
            Store s = new Store();

            Console.WriteLine("Welcome to the car store. First you must create some car inventory. Then you may add some cars to the shpping car. Finally you may checkout which will give you a total value of the shpping cart.");

            int action = chooseAction();

            while (action != 0)
            {
                Console.WriteLine("You chose " + action);

                switch (action)
                {
                    // Add car to stock.
                    case 1:
                        Console.WriteLine("You chose to add a new car to the inventory");

                        string carMake = "";
                        string carModel = "";
                        decimal carPrice = 0;
                        bool isNew = true;
                        int miles = 0;

                        Console.WriteLine("What is the car make? Ford, Nissan, etc.");
                        carMake = Console.ReadLine();

                        Console.WriteLine("What is the car model? Mustang, Optima, etc.");
                        carModel = Console.ReadLine();

                        Console.WriteLine("How much does the car cost?");
                        try
                        {
                            carPrice = decimal.Parse(Console.ReadLine());
                        }
                        catch (FormatException)
                        {
                            Console.WriteLine("Please enter valid integers only.");
                            carPrice = decimal.Parse(Console.ReadLine());
                        }


                        Console.WriteLine("Is the car new? (y/n)");
                        string response = Console.ReadLine();
                        if (response != "y")
                            isNew = false;


                        Console.WriteLine("How many miles are on the car?");
                        try
                        {
                            miles = int.Parse(Console.ReadLine());
                        }
                        catch (FormatException)
                        {
                            Console.WriteLine("Please enter valid integers only.");
                            miles = int.Parse(Console.ReadLine());
                        }

                        Car newCar = new Car(carMake, carModel, carPrice, isNew, miles);
                        s.CarList.Add(newCar);

                        printInventory(s);
                        break;

                    // Add car to cart.
                    case 2:
                        Console.WriteLine("You chose to add a car to your shopping cart");
                        printInventory(s);
                        Console.WriteLine("Which item would you like to buy? (number)");
                        try
                        {
                            int carChosen = int.Parse(Console.ReadLine());
                            s.ShoppingList.Add(s.CarList [carChosen]);
                            printShoppingCart(s);
                        }
                        catch
                        {
                            Console.WriteLine("Car # not found. Please try again.\n");
                        }

                        break;

                    // Checkout.
                    case 3:
                        printShoppingCart(s);
                        Console.WriteLine($"The total cost of your items is ${s.Checkout()}");
                        break;
                    default:
                        break;
                }
                action = chooseAction();
            }

        }

        private static void printShoppingCart(Store s)
        {
            Console.WriteLine("Cars you have chosen to buy: ");

            for (int i = 0; i < s.ShoppingList.Count; i++)
            {
                Console.WriteLine($"Car # {i} - {s.ShoppingList[i]}");

            }
        }

        private static void printInventory(Store s)
        {
            for(int i = 0; i < s.CarList.Count; i++)
            {
                Console.WriteLine($"Car # {i} - {s.CarList[i]}");
            }
        }

        static public int chooseAction()
        {
            int choice = 0;
            Console.WriteLine("Choose an action:\n(0) to quit\n(1) to add a new car to the inventory\n(2) add car to cart\n(3) checkout");

            choice = int.Parse(Console.ReadLine());
            return choice;
        }
    }
}
