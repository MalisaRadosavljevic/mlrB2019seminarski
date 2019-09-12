using System;

class Program
{

	//функција која сортира низ целих бројева у растућем поретку
        static void sortiraj_rastuce(int [] niz, int n)
        {
            int i, j;
            int min;
            int pom;         
	   /* У свакој итерацији ове петље проналази се најмањи елемент
            међу елементима niz[i], niz[i+1],...,niz[n-1], и поставља се на
            позицију i, док се елемент на позцији i премешта на позицију
            min, на којој се налазио најмањи од наведених елемената*/
            for (i = 0; i < n - 1; i++)
            {
                /* Унутрашња петља проналази позицију min, на којој се налази
                   најмањи од елемената niz[i], niz[i+1],...,niz[n-1]. */
                min = i;
                for (j = i + 1; j < n; j++)
                    if (niz[j] < niz[min])
                        min = j;
                /* Замена елемената на позицијама i и min. Ово се ради само
                   ако су i и min различити, иначе је непотребно */
                if (min != i)
                {
                    pom = niz[i];
                     niz[i] = niz[min];
                    niz[min] = pom;
                   
                }
            }
        }

    static void Main(string[] args)
    {
	int n,k,S,suma_k=0 ;
        int[] cene = new int[200];

            S = int.Parse(Console.ReadLine());
            k = int.Parse(Console.ReadLine());
            n = int.Parse(Console.ReadLine());

                //учитамо цене у низ
            for (int i = 0; i < n; i++)
                cene[i]= int.Parse(Console.ReadLine());

            //сортирамо низ цена у растућем поретку
            sortiraj_rastuce(cene,n);

            //саберемо првих к најнижих цена
            for (int i = 0; i < k; i++)
                suma_k += cene[i];

            //уколико је сума првих к мања од понуђене суме S
            if (suma_k <= S)
                Console.WriteLine("МОГУЋЕ");

            //уколико је сума првих к veћa од понуђене суме S
            else
            {
                Console.WriteLine("НИЈЕ МОГУЋЕ");
                Console.WriteLine(suma_k);
            }
           
    }
}
