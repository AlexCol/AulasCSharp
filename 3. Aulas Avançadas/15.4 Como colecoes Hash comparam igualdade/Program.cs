Console.WriteLine("Prodct analyzes-----------");
HashSet<Product> a = new HashSet<Product>();
a.Add(new Product("TV", 900.00));
a.Add(new Product("Notebook", 1200.00));

Product prod = new Product("Notebook", 1200.00);
/*
!retorna falso, pois Product não implementa equals e nem gethashconde, então ele comparada o valor referencia, como o
!objeto na lista é diferente do objeto novo criado (apesar dos mesmos dados), a referencia difere
*/
Console.WriteLine("New obj inside list?: " + a.Contains(prod));
Console.WriteLine();
Console.WriteLine();


//*--------------------------------------------------------------------------------------------
//!--------------------------------------------------------------------------------------------
//?--------------------------------------------------------------------------------------------

Console.WriteLine("ProductComHash analyzes-----------");
HashSet<ProductComHash> a2 = new HashSet<ProductComHash>();
a2.Add(new ProductComHash("TV", 900.00));
a2.Add(new ProductComHash("Notebook", 1200.00));

ProductComHash prodComHash = new ProductComHash("Notebook", 1200.00);
/*
!retorna true, pois ProductComHash implementa equals e gethashconde, então ele comparada o valor dessas funções e 
!objeto na lista é o objeto novo criado (pois tem os mesmos dados, que são comparados)
*/
Console.WriteLine("New obj inside list?: " + a2.Contains(prodComHash));
Console.WriteLine();
Console.WriteLine();

//*--------------------------------------------------------------------------------------------
//!--------------------------------------------------------------------------------------------
//?--------------------------------------------------------------------------------------------


Console.WriteLine("ProductComHash analyzes-----------");
HashSet<Point> b = new HashSet<Point>();
b.Add(new Point(3, 4));
b.Add(new Point(5, 10));

/*
!retorna true, pois Point é struct, então é analisado 'valor' e não referencia, pois structs são analisados conforme valores
*/
Point point = new Point(3, 4);
Console.WriteLine("New obj inside list?: " + a2.Contains(prodComHash));