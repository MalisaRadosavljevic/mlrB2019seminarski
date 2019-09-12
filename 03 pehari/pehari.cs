using System;

class Program
{
    static void Main(string[] args)
    {
	int m,n,br_polica;

	    //учитавање капацитета полице и број пехара које ређамо           
            m = int.Parse(Console.ReadLine());
            n = int.Parse(Console.ReadLine());
	    
		//израчунавање броја потребних полица
		br_polica=(m+n-1)/m;
               
	     //испис броја потребних полица за ређање n пехара
             Console.WriteLine(br_polica);
           
    }
}
