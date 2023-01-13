class MyMain
{
    public static void main(string[] args)
    {
        Action a = MyFunctions.ImprimeOi;
        a += MyFunctions.ImprimeTchau;

        a();
    }
}