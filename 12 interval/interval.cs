using System;

class Program
{
    static void Main(string[] args)
    {
	int n, a, b;
        double x,proizvod = 1; // производ иницијализујемо на неутрал за множење
        bool indikator = false; /* индикатор нам служи да проверимо да ли се неки број налази у траженом интервалу 
                                   и на почетку претпоставимо да немамо бројева у траженом интервалу*/
            
            n = int.Parse(Console.ReadLine());
            a = int.Parse(Console.ReadLine());
            b = int.Parse(Console.ReadLine());

            //користимо петљу да учитамо n броја
            for(int i = 1; i <= n; i++)
            {
                //у свакој итерацији петље учитамо један број
                x= double.Parse(Console.ReadLine());

                //ако је учитани број у траженом интервалу онда га додамо у производ
                if(x>=a && x <= b)
                {
                    proizvod *= x;

                    //променимо вредност индикатора
                    if (indikator == false)
                        indikator = true;
                }
            }

            //ако немамо ниједан  број у траженом интервалу
            if (indikator == false)
                Console.WriteLine("НЕМА БРОЈЕВА У ДАТОМ ИНТЕРВАЛУ");
            
            else
                Console.WriteLine(proizvod.ToString("0.000"));
           
    }
}
