using System; 

class URI {

    static void Main(string[] args) { 
        int employer_number, worked_hours;
        float amount_received_per_hour, salary_total;
        string number, worked, amount;

        number = Console.ReadLine();
        worked = Console.ReadLine();
        amount = Console.ReadLine();

        employer_number = Convert.ToInt32(number);
        worked_hours = Convert.ToInt32(worked);
        amount_received_per_hour = (float) Convert.ToDouble(amount);

        salary_total = worked_hours*amount_received_per_hour;

        Console.WriteLine("NUMBER = {0}", employer_number);
        Console.WriteLine("SALARY = U$ {0:0.00}", salary_total);
    }

}
