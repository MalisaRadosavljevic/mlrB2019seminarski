using System;

class Program
{
    static void Main(string[] args)
    {
	double r,H,V;

	    //учитавање полупречника и висине ваљка
            r = double.Parse(Console.ReadLine());
            H = double.Parse(Console.ReadLine());

		//израчунавање запремине
                V = r * r * H*Math.PI;
	    
	    //испис запремине заокружен на три децимале
            Console.WriteLine(V.ToString("0.000"));
           
    }
}
