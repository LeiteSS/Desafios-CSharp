using System; 

class URI {

    static void Main(string[] args) { 
        double numA, numB, med;
        string A, B;

        A = Console.ReadLine();
        B = Console.ReadLine();

        numA = Convert.ToDouble(A);
        numB = Convert.ToDouble(B);

        med = (((numA*3.5)+(numB*7.5))/(3.5+7.5));

        Console.WriteLine("MEDIA = {0:0.00000}" + med);
    }

}