using System.Globalization;

class UsedProduct : Product
{
    private DateTime _manufacturedDate;

    public UsedProduct(string name, double price, DateTime manufacturedDate) : base(name, price)
    {
        ManufacturedDate = manufacturedDate;
    }

    public DateTime ManufacturedDate { get => _manufacturedDate; set => _manufacturedDate = value; }

    public override string PriceTag()
    {
        return $"{Name} (used) $ {Price.ToString("F2", CultureInfo.InvariantCulture)} (Manufacture date: {ManufacturedDate.ToString("dd/MM/yyyy")})";
    }
}