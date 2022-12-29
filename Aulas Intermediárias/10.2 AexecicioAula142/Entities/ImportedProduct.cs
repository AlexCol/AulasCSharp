using System.Globalization;

class ImportedProduct : Product
{
    private double _customsFee;

    public ImportedProduct(string name, double price, double customsFee) : base(name, price)
    {
        CustomsFee = customsFee;
    }

    public double CustomsFee { get => _customsFee; set => _customsFee = value; }

    public override string PriceTag()
    {
        return $"{Name} $ {TotalPrice().ToString("F2", CultureInfo.InvariantCulture)} (Customs fee: $ {CustomsFee.ToString("F2", CultureInfo.InvariantCulture)})";
    }

    public double TotalPrice() {
        return Price + CustomsFee;
    }
}