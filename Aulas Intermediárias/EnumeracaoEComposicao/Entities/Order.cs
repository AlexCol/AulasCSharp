using Enums;

namespace Entities;
class Order {
    private int _id;
    private DateTime _moment;
    private OrderStatus _status;

    public int Id { get => _id; set => _id = value; }
    public DateTime Moment { get => _moment; set => _moment = value; }
    internal OrderStatus Status { get => _status; set => _status = value; }

    public override string ToString() {
        return $"{Id}, {Moment}, {Status}";
    }
}