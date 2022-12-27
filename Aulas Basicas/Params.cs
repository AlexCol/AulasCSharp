class Params {
    public double Somar(params double[] valores) {
        double soma = 0;
        foreach (double valor in valores) {
            soma += valor;
        }
        return soma;
    }
}