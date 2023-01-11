using System;
using System.Globalization;
using Course.Entities;
using Course.Services;

namespace Course {
    class Program {
        static void Main(string[] args) {

            Console.WriteLine("Enter contract data");
            Console.Write("Number: ");
            int contractNumber = int.Parse(new String(Console.ReadLine()));
            Console.Write("Date (dd/MM/yyyy): ");
            DateTime contractDate = DateTime.ParseExact(new String(Console.ReadLine()), "dd/MM/yyyy", CultureInfo.InvariantCulture);
            Console.Write("Contract value: ");
            double contractValue = double.Parse(new String(Console.ReadLine()), CultureInfo.InvariantCulture);
            Console.Write("Enter number of installments: ");
            int months = int.Parse(new String(Console.ReadLine()));

            Contract myContract = new Contract(contractNumber, contractDate, contractValue);

            ContractService contractService = new ContractService(new PaypalService());
            contractService.ProcessContract(myContract, months);

            Console.WriteLine("Installments:");
            foreach (Installment installment in myContract.Installments) {
                Console.WriteLine(installment);
            }
        }
    }
}
