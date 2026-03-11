using System;

namespace FoodiesDelight
{
    public class CancelOrder : ICommand
    {
        private Order order;

        public CancelOrder(Order order)
        {
            this.order = order;
        }

        public void Execute()
        {
            Console.WriteLine($"Order id: {order.id} for {order.dishName} is canceled");
        }
    }
}
