#include "tgen.hpp"

int rand_seed = 0;
int test_count = 10;
string naziv_zadatka = "popravka_auta";

void gen_test(int i, ostream &tin) {

int S = random_value(1, 40000);
int k = random_value(1, 10);
int n = random_value(k, 30);

tin << S << endl;
tin << k << endl;
tin << n << endl;

for (int i = 0; i < n; ++i)
    {
        int x = random_value(1, 5000);
        tin << x << endl;
    }

}
