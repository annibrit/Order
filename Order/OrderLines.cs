
using Order.Archetype;

namespace Order
{
    public class OrderLines : Archetypes<OrderLine>
    {
        public static OrderLines Instance
        { get; } = new OrderLines();
    }
}
