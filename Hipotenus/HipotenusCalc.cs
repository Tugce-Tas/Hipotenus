namespace Hipotenus;

public class HipotenusCalc
{ public void Hip() {
        int a, b;
        double c;
 	
        Console.Write("Kenar uzunluğu: ");
        a = Convert.ToInt16(Console.ReadLine());
	
        Console.Write("Diğer kenar uzunluğu: ");
        b = Convert.ToInt16(Console.ReadLine());
	
        c = Math.Sqrt(a*a + b*b);
        Console.WriteLine("Hipotenüs: " + c);
    }

}