using System; 

class URI {

    static void Main(string[] args) { 
        int numA, numB, PROD;
        String A, B;

        A = Console.ReadLine();
        B = Console.ReadLine();

        numA = Convert.ToInt32(A);
        numB = Convert.ToInt32(B);

        PROD = numA*numB;
        Console.WriteLine("PROD = " + PROD);
    }

}