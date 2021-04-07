using System; 

class URI {

    static void Main(string[] args) { 
        int product_cod1, product_cod2, product_unit1, product_unit2;
        double product_price1, product_price2, total;

        string[] prod1 = Console.ReadLine().Split(' ');
        product_cod1 = int.Parse(prod1[0]);
        product_unit1 = int.Parse(prod1[1]);
        product_price1 = double.Parse(prod1[2]);

        string[] prod2 = Console.ReadLine().Split(' ');
        product_cod2 = int.Parse(prod2[0]);
        product_unit2 = int.Parse(prod2[1]);
        product_price2 = double.Parse(prod2[2]);

        total = (product_price1*product_unit1) + (product_price2*product_unit2);

        Console.WriteLine("VALOR A PAGAR: R$ {0:0.00}", total);
    }

}
