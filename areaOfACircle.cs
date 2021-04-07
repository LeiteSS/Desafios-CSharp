using System; 

class URI {

    static void Main(string[] args) { 
        double a, r, pi;
        string numR;

        pi = 3.14159;
        numR = Console.ReadLine();

        r = Convert.ToDouble(numR);

        a = pi*(r*r);

        Console.WriteLine("A={0:0.0000}", a);
    }

}