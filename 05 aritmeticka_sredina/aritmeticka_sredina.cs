using System;

class Program
{
    static void Main(string[] args)
    {
	int broj,c0,c1,c2,c3;
        double aritmeticka_sredina;

	    //учитавање четвороцифреног броја
            broj = int.Parse(Console.ReadLine());

		//одвајање цифара четвороцифреног броја
		c0 = (broj / 1) % 10;
		c1 = (broj / 10) % 10;
            	c2 = (broj / 100) % 10;
            	c3 = (broj / 1000) % 10;

		//рачунање аритметичке средине
           	aritmeticka_sredina = (double)(c0 + c1 + c2 + c3) / 4;

	    //испис аритметичке средине заокружен на три децимале
            Console.WriteLine(aritmeticka_sredina.ToString("0.000"));
           
    }
}
