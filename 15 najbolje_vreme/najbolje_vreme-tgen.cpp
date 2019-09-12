#include "tgen.hpp"

int rand_seed = 0;
int test_count = 10;
string naziv_zadatka = "najbolje_vreme";

void gen_test(int i, ostream &tin) {

int n = random_value(1, 10);

tin << n << endl;

for (int i = 0; i < n; ++i)
    {
        int t = random_value(5, 30);
        tin << t << endl;
    }

}
