using Curso;

class Main
{
    delegate double BinartNumericOperationDouble(double n1, double n2);
    delegate void BinartNumericOperationVoid(double n1, double n2);

    public static void main(string[] args)
    {
        double a = 10;
        double b = 12;

        BinartNumericOperationDouble op = CalculationService.Sum;

        System.Console.WriteLine("Main:");

        double result = op(a, b);
        System.Console.WriteLine(result);

        //!Multicast
        BinartNumericOperationVoid op2 = CalculationService.ShowSum;
        op2 += CalculationService.ShowMax;
        op2(a, b);
    }

}