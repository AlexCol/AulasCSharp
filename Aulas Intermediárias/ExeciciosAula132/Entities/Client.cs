class Client {
    private string _name;
    private string _email;
    private DateTime _birthDate;

    public Client() {
        _name = "";
        _email = "";
    }

    public Client (string name, string email, DateTime birthDate) : this() {
        Name = name;
        Email = email;
        BirthDate = birthDate;
    }

    public string Name { get => _name; set => _name = value; }
    public string Email { get => _email; set => _email = value; }
    public DateTime BirthDate { get => _birthDate; set => _birthDate = value; }
}