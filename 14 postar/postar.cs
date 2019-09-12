using System;

class Program
{
	//фукција која проверава да ли је број прост
        static bool prost_broj(int x)
        {
            //на почетку претпоставимо да је бој прост
            bool prost = true;

            
            for(int i = 2; i < x; i++)
                //проверавамо да ли постоји неки делилац нашег броја
                if (x % i == 0)
                {
                    //ако делилац постоји онда број није прост
                    prost = false;
                    break;
                }

            return prost;
        }

    static void Main(string[] args)
    {
	int n,zbir=0; // у променљивој zbir чувамо број кућа у улици са простим бројем

            n = int.Parse(Console.ReadLine());

            for (int i = 2; i <= n; i++)
                //проверавамо да ли је редни број куће прост
                if (prost_broj(i))
                    //ако је редни број куће прост поштар треба са обиђе ту кућу
                    zbir ++;

            Console.WriteLine(zbir);
           
    }
}
