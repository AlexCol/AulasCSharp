

Account acc = new Account();
acc.meuMetodo();

SubAccount sacc = new SubAccount();
sacc.meuMetodo();

//upcasting
Account acc2 = new SubAccount();
acc2.meuMetodo();

if (acc2 is SubAccount) {
    //downcasting
    SubAccount sacc2 = (SubAccount)acc2;
    sacc2.meuMetodo();
    System.Console.WriteLine("Entrou");
} else {
    System.Console.WriteLine("Não entrou");
}


