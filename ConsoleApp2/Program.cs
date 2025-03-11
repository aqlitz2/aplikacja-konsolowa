



using System.ComponentModel.Design;

class Program
{

    static void Main(string[] args)
    {
        Console.WriteLine("Podaj a: ");
        int a = int.Parse(Console.ReadLine());
        Console.WriteLine("Podaj b: ");
        int b = int.Parse(Console.ReadLine());

        while (a != b)
        {
            if (a > b)
            {
                a -= b;
                continue;
            }
            else
            {
                b -= a;
                continue;
            }

        } Console.Write("Najwiekszy wspolny dzielnik to " + a); 
       
    
    
    
    }


}
    
       



