class SubAccount : Account
//class SubAccount : SealedAcount //nao funciona pois a SealedAccount é sealed
{

    public sealed override void meuMetodo() //usando sealed impede que uma subclasse dessa classe faça orverride novamente
    {
        System.Console.WriteLine("Sub");
    }

}