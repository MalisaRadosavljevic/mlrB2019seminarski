#include "tgen.hpp"

int rand_seed = 0;
int test_count = 10;
string naziv_zadatka = "plata";

void gen_test(int i, ostream &tin) {

 int O = random_value(1,10);
 int P = random_value(10000,200000);

tin << O << endl;
tin << P << endl;

}
