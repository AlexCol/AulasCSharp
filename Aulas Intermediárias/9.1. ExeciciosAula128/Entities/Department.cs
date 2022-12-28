namespace Entities;

class Department {
    private string _name = new String("");

    public Department(){
    }

    public Department(string name) {
        Name = name;
    }
    public string Name { get => _name; set => _name = value; }
}