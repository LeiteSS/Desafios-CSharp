using System; 

class URI {

    static void Main(string[] args) { 
        double a, b, c, volume, pi;
        pi = 3.14159;
        string[] values = Console.ReadLine().Split(' ');
        a = double.Parse(values[0]);
        b = double.Parse(values[1]);
        c = double.Parse(values[2]);
        
        double rectangled = (a*c)/2;
        double circle = pi *(c*c);
        double trapezium = ((a+b)*c)/2;
        double square = b*b;
        double rectangle = a*b;
        
        Console.WriteLine("TRIANGULO: {0:0.000}", rectangled);
        Console.WriteLine("CIRCULO: {0:0.000}", circle);
        Console.WriteLine("TRAPEZIO: {0:0.000}", trapezium);
        Console.WriteLine("QUADRADO: {0:0.000}", square);
        Console.WriteLine("RETANGULO: {0:0.000}", rectangle);
    }

}