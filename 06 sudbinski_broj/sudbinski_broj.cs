using System;

class Program
{
    static void Main(string[] args)
    {
	int d,m,g,suma=0; //сума ће представљати збир цифара датума рођења па је иницијализујемо на неутрал за сабирање
        int d0, d1, m0, m1, g0, g1, g2, g3;
            
	    //учитавање датума рођења
            d = int.Parse(Console.ReadLine());
            m = int.Parse(Console.ReadLine());
            g = int.Parse(Console.ReadLine());

		//одвајање цифара дана рођења
		d0 = (d / 1) % 10;
		d1 = (d / 10) % 10;

		//одвајање цифара месеца рођења
		m0 = (m / 1) % 10;
		m1 = (m / 10) % 10;

		//одвајање цифара године рођења
		g0 = (g / 1) % 10;
		g1 = (g / 10) % 10;
		g2 = (g / 100) % 10;
		g3 = (g / 1000) % 10;

		//рачунање суме одвојених цифара датума рођења
		suma = d0 + d1 + m0 + m1 + g0 + g1 + g2 + g3;
	
	    //сабирамо цифре броја све док не добијемо једноцифрен број
	    while(suma>=10){
		int c0=suma%10;
		int c1=(suma/10)%10;
		
		suma=c0+c1;
	    }

                 Console.WriteLine(suma);

           
    }
}
