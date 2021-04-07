using System; 

class URI {

    static void Main(string[] args) { 
        string r = Console.ReadLine();
        double radius = Convert.ToDouble(r);
        double pi = 3.14159;
        double volume = (4.0/3)*pi*(radius*radius*radius);
        Console.WriteLine("VOLUME = {0:0.000}", volume);
    }

}