#include "tgen.hpp"

int rand_seed = 0;
int test_count = 10;
string naziv_zadatka = "interval";

void gen_test(int i, ostream &tin) {

int n = random_value(1, 1000);
int a = random_value(-1000, 1000);
int b = random_value(a, 1000);

tin << n << endl;
tin << a << endl;
tin << b << endl;


 for (int i = 0; i < n; i++)
    {
        int k = random_value(-1000, 1000);
        tin << k << endl;
    }

}
