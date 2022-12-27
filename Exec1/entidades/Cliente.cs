class Cliente {
    private string _nome;
    private string _cpf;

    public Cliente(string nome) {
        _nome = nome;
        _cpf = "";
    }

    public string Nome { get => _nome; set => _nome = value; }
    public string Cpf { get => _cpf; set => _cpf = value; }
}