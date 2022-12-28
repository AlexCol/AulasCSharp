using Entities;
using Enums;

namespace implementacoes;
class Principal {
    public static void executar() {
        Order order = new Order {
            Id = 1080,
            Moment = DateTime.Now,
            Status = OrderStatus.PendingPayment
        };

        System.Console.WriteLine(order);

        string  txt = OrderStatus.PendingPayment.ToString();
        System.Console.WriteLine(txt);

        OrderStatus os = Enum.Parse<OrderStatus>("Delivered");
        System.Console.WriteLine((int) os);
    }
}