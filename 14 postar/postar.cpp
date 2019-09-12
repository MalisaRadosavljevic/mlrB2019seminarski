#include <iostream>

using namespace std;

//фукција која проверава да ли је број прост
bool prost_broj(int x){

	 //на почетку претпоставимо да је бој прост
	bool prost = true;
	
	for(int i=2; i < x; i++)

	     //проверавамо да ли постоји неки делилац нашег броја
	     if(x % i == 0){

		//ако делилац постоји онда број није прост
		prost = false;
		break;
		}
	return prost;
}

int main(){
	
	int n,zbir = 0;// у променљивој zbir чувамо број кућа у улици са простим бројем

	cin >> n;
	
	for(int i=2; i <= n; i++)

		//проверавамо да ли је редни број куће прост
		if(prost_broj(i))

			//ако је редни број куће прост поштар треба са обиђе ту кућу
			zbir++;
	
	cout << zbir << endl;

	return 0;
}