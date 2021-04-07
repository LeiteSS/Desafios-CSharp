using System; 

class URI {

    static void Main(string[] args) { 
        int numA, numB, numC, numD, res;
        string A, B, C, D;

        A = Console.ReadLine();
        B = Console.ReadLine();
        C = Console.ReadLine();
        D = Console.ReadLine();

        numA = Convert.ToInt32(A);
        numB = Convert.ToInt32(B);
        numC = Convert.ToInt32(C);
        numD = Convert.ToInt32(D);

        res = (numA * numB) - (numC * numD);

        Console.WriteLine("DIFERENCA = {0}", res);
    }

}