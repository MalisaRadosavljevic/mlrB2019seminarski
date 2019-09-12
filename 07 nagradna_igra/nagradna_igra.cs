using System;

class Program
{
    static void Main(string[] args)
    {
	int m,n;
     
	    //учитавање променљивих 
            m = int.Parse(Console.ReadLine());
            n = int.Parse(Console.ReadLine());
          
        //ако је Јелена сакуписа више чепова од Нине 
	if(20*m>10*n)
            Console.WriteLine("Јелена");
	//ако је Нина сакупила више чепова од Јелене
	else if(20*m<10*n)
            Console.WriteLine("Нина");
	//ако су сакупиле једнак број чепова
	else
            Console.WriteLine("НЕРЕШЕНО");
           
    }
}
