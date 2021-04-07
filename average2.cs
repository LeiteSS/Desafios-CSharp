using System; 

class URI {

    static void Main(string[] args) { 
        float numA, numB, numC, med;
        string A, B, C;

        A = Console.ReadLine();
        B = Console.ReadLine();
        C = Console.ReadLine();

        numA = (float) Convert.ToDouble(A);
        numB = (float) Convert.ToDouble(B);
        numC = (float) Convert.ToDouble(C);

        med = (((numA*2)+(numB*3)+(numC*5))/(2+3+5));

        Console.WriteLine("MEDIA = {0:0.0}", med);
    }

}