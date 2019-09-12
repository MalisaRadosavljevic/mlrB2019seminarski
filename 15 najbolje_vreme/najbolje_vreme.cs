using System;

class Program
{
    static void Main(string[] args)
    {
	int n,min,indikator,t;
        
	    //учитамо колико пута је Јоца трчао
            n = int.Parse(Console.ReadLine());

            //учитамо време које је постигао приликом првог трчања
            t = int.Parse(Console.ReadLine());

            //претпоставимо да је у првом трчању био најбржи
            min = t;
            indikator = 1;

            //потребно је учитати још n-1 време које је постигао
            for (int i = 2; i <= n; i++)
            {   
                t = int.Parse(Console.ReadLine());
               
                if (t <= min)
                {    //ако је и i-том трчању био најбржи онда ажурирамо променљиве
                    min = t;
                    indikator = i;
                }

            }
            Console.WriteLine(indikator);
           
    }
}
