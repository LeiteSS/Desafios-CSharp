using System; 

class URI {

    static void Main(string[] args) { 
        float salary, total_value_sold, total;
        string employer_name, sSalary, sTota_Sold;

        employer_name = Console.ReadLine();
        sSalary = Console.ReadLine();
        sTota_Sold = Console.ReadLine();

        salary = (float) Convert.ToDouble(sSalary);
        total_value_sold = (float) Convert.ToDouble(sTota_Sold);

        total = salary + (total_value_sold * 0.15);

        Console.WriteLine("TOTAL = R$ {0:0.00}", total);
    }

}