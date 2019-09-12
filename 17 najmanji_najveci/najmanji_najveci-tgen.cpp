#include "tgen.hpp"

int rand_seed = 0;
int test_count = 10;
string naziv_zadatka = "najmanji_najveci";

void gen_test(int i, ostream &tin) {

int n = random_value(1, 10);
tin<< n << endl;

for (int i = 0; i < n; ++i)
    {
        int k = random_value(0, 9);
        tin << k << endl;

}
