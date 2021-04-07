using System; 

class URI {

    static void Main(string[] args) { 

        int a, b, SOMA;
        string numA, numB;

        numA = Console.ReadLine();
        numB = Console.ReadLine();

        a = Convert.ToInt32(numA);
        b = Convert.ToInt32(numB);

        SOMA = a+b;

        Console.WriteLine("SOMA = {0}", SOMA);

    }

}