using System;

namespace FoodiesDelight
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // 1. Gather initial order details
            Console.WriteLine("Enter the order id:");
            int id = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the dish name:");
            string dish = Console.ReadLine();

            Console.WriteLine("Enter the order time:");
            string time = Console.ReadLine();

            // 2. Process Placement
            Order userOrder = new Order(id, dish, time);
            Restaurant invoker = new Restaurant();
            
            ICommand placeCmd = new PlaceOrder(userOrder);
            invoker.AddCommand(placeCmd);
            invoker.ProcessCommand();

            // 3. Process Cancellation
            Console.WriteLine("Enter the order id to cancel:");
            int cancelId = Convert.ToInt32(Console.ReadLine());

            if (cancelId == userOrder.id)
            {
                ICommand cancelCmd = new CancelOrder(userOrder);
                invoker.AddCommand(cancelCmd);
                invoker.ProcessCommand();
            }
        }
    }
}
