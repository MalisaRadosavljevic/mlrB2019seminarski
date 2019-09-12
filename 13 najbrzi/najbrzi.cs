using System;

class Program
{
    static void Main(string[] args)
    {
	int t_1,t_2,t_3;
        int indikator,min; /*у променљивој indikator чувамо редни број такмичара,
                             а у променљивој min најбоље време*/

            t_1 = int.Parse(Console.ReadLine());
            t_2 = int.Parse(Console.ReadLine());
            t_3 = int.Parse(Console.ReadLine());

            //претпоставимо да је Аца најбржи
            min = t_1;
            indikator = 1;

            //уколико је Јова бржи од Аце
            if (t_2 < min)
            {
                min = t_2;
                indikator = 2;
            }
            //уколико је Мики бржи од Аце и Јове
            else if (t_3 < min)
            {
                min = t_3;
                indikator = 3;

            }

            if (indikator == 1)
                Console.WriteLine("Aца");
            else if(indikator==2)
                Console.WriteLine("Јова");
            else
                Console.WriteLine("Мики");
           
    }
}
