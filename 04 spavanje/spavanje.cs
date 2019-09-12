using System;

class Program
{
    //функција која за дате сате и минуте враћа колико је сати прошло од поноћи
    static int u_minute(int sati, int minuti)
        {
            return sati * 60 + minuti;
        }


    static void Main(string[] args)
    {
	int h, m, hh, mm;
        int minuti_spavanja;
	
	    //учитавање променљивих
            h = int.Parse(Console.ReadLine());
            m = int.Parse(Console.ReadLine());
            hh = int.Parse(Console.ReadLine());
            mm = int.Parse(Console.ReadLine());
            
 		//одређивање дужине спавања у минутима
		minuti_spavanja = u_minute(hh, mm) - u_minute(h, m);

	    //провера да ли је довољно спавао и испис одговарајуће поруке
            if (minuti_spavanja >= 135)
                Console.WriteLine("ДОВОЉНО ЈЕ СПАВАО");
            else
                Console.WriteLine("НИЈЕ ДОВОЉНО СПАВАО");
           
    }
}
