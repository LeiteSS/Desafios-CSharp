using System; 

class URI {

    static void Main(string[] args) { 
        int a, b, x;
        string numA, numB;

        numA = Console.ReadLine();
        numB = Console.ReadLine();

        a = Convert.ToInt32(numA);
        b = Convert.ToInt32(numB);

        x = a+b;

        Console.WriteLine("X = {0}", x);
    }

}