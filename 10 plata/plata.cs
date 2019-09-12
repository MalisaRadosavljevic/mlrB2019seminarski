using System;

class Program
{
    static void Main(string[] args)
    {
	int O, P;
        double Plata; //плата након оцењивања
     
            //учитавање оцене и основне плате
            O=int.Parse(Console.ReadLine());
            P=int.Parse(Console.ReadLine());

            //ако је наставник изузетан
            if (O == 10)
            {
		Plata = P + P*0.15;
                Console.WriteLine("Изузетан");
                Console.WriteLine(Plata.ToString("0.000"));
            }

            //ако је наставник јако лош
            else if (O <= 3)
            {
                Plata = P - P * 0.15;
                Console.WriteLine("Јако лош");
                Console.WriteLine(Plata.ToString("0.000"));
            }

            //ако је наставник просечан или одличан
            else
            {
                Plata = P + P*(double)O/100;

                //ако је наставник просечан
                if(O==4 || O == 5)
                {
                    Console.WriteLine("Просечан");
                    Console.WriteLine(Plata.ToString("0.000"));
                }

                //ако је наставник одличан
                else
                {
                    Console.WriteLine("Одличан");
                    Console.WriteLine(Plata.ToString("0.000"));
                }
            }
           
    }
}
