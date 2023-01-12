class ProductComHash
{
    public string Name { get; set; }
    public double Price { get; set; }

    public ProductComHash(string name, double price)
    {
        Name = name;
        Price = price;
    }

    public override bool Equals(object obj)
    {
        if (obj == null)
        {
            return false;
        }
        if (!(obj is ProductComHash))
        {
            return false;
        }
        ProductComHash other = obj as ProductComHash;
        return (Name.Equals(other.Name) && Price == other.Price);
    }

    public override int GetHashCode()
    {
        return Name.GetHashCode() + Price.GetHashCode();
    }
}