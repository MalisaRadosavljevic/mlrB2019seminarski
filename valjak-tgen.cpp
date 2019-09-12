#include "tgen.hpp"

int rand_seed = 0;
int test_count = 10;
string naziv_zadatka = "valjak";

void gen_test(int i, ostream &tin) {

 double r = random_value(0.1, 100);
 double H = random_value(0.1, 100);

tin << fixed << setprecision(3) << r << endl;
tin << fixed << setprecision(3) << H << endl;
}
