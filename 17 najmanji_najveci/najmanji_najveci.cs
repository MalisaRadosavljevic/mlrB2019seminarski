using System;

class Program
{
	//функција која сортира низ целих бројева у растућем поретку
        static void sortiraj_rastuce(int[] niz, int n)
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

	//функција која сортира низ целих бројева у опадајућем поретку
        static void sortiraj_opadajuce(int[] niz, int n)
        {
            int i, j;
            int max;
            int pom;         
	   /* У свакој итерацији ове петље проналази се највећи елемент
            међу елементима niz[i], niz[i+1],...,niz[n-1], и поставља се на
            позицију i, док се елемент на позцији i премешта на позицију
            max, на којој се налазио највећи од наведених елемената*/
            for (i = 0; i < n - 1; i++)
            {
                /* Унутрашња петља проналази позицију max, на којој се налази
                  највећи од елемената niz[i], niz[i+1],...,niz[n-1]. */
                max = i;
                for (j = i + 1; j < n; j++)
                    if (niz[j] > niz[max])
                        max = j;
                /* Замена елемената на позицијама i и max. Ово се ради само
                   ако су i и max различити, иначе је непотребно */
                if (max != i)
                {
                    pom = niz[i];
                    niz[i] = niz[max];
                    niz[max] = pom;

                }
            }
        }

    static void Main(string[] args)
    {

	int n,najveci=0,najmanji=0;
        int[] cifre = new int[10]; //направимо низ у коме ћемо чувати цифре

            n = int.Parse(Console.ReadLine());
            
            //учитамо цифре у низ
            for(int i=0;i<n;i++)
                cifre[i] = int.Parse(Console.ReadLine());

            //сортирамо цифре у опадајућем поретку
            sortiraj_opadajuce(cifre, n);


            for (int i = 0; i < n - 1; i++)
                //формирамо највећи број са првих n-1 цифра
                najveci = (najveci + cifre[i]) * 10;

            //последњу цифру само додамо у збир
            najveci = najveci + cifre[n - 1];

            Console.WriteLine(najveci);

            //сортирамо цифре у растућем поретку
            sortiraj_rastuce(cifre,n);

            for (int i = 0; i < n-1; i++)
                //уколико су почетне цифре нула нема потребе да их пошемо
                if(cifre[i]!=0)
                    //формирамо најмањи број са првих n-1 цифра
                    najmanji = (najmanji +cifre[i])*10;

            //последњу цифру само додамо у збир
            najmanji = najmanji + cifre[n - 1];

                Console.WriteLine(najmanji);

           
    }
}
