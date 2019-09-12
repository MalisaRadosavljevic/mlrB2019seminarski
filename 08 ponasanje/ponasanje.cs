using System;

class Program
{
    static void Main(string[] args)
    {
 	int p,o;
     
            //уносимо понашање ученика
            p = int.Parse(Console.ReadLine());

            //ако се ученик добро понаша исписујемо "ПОХВАЛИТИ"
            if (p > 5)
		 Console.WriteLine("ПОХВАЛИТИ");

            //ако се ученик лоше понаша онда је потребно учитати и оцену са контролног 
            else
            {
                //учитавање оцене са контролног
               o = int.Parse(Console.ReadLine());
                
               if(o<4)
                 Console.WriteLine("ИСПИТАТИ");
               else
                 Console.WriteLine("ИЗБАЦИТИ");
            }

           
    }
}
