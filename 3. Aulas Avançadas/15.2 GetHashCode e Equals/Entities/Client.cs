class Client
{
    public string Name { get; set; }
    public string Email { get; set; }

    public override bool Equals(object obj)
    {
        if (obj == null)
        {
            return false;
        }
        if (!(obj is Client))
        {
            return false;
        }

        Client other = obj as Client;
        if (Name.Equals(other.Name) && Email.Equals(other.Email))
        {
            return true;
        }
        return false;
    }

    public override int GetHashCode()
    {
        return Name.GetHashCode() + Email.GetHashCode();
    }
}