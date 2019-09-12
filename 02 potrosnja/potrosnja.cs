using System;

class Program
{
    static void Main(string[] args)
    {
	int kapacitet,S;
        double potrosnja;
		
	    //учитавање капацитета резервоара и пређеног пута са пуним резервоаром
            kapacitet = int.Parse(Console.ReadLine());
            S = int.Parse(Console.ReadLine());

		//израчунавање потрошње
                potrosnja= ((double)kapacitet/S)*100;

	    //испис потрошње заокружен на три децимале
            Console.WriteLine(potrosnja.ToString("0.000"));
           
    }
}
