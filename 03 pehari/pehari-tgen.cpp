#include "tgen.hpp"

int rand_seed = 0;
int test_count = 10;
string naziv_zadatka = "pehari";

void gen_test(int i, ostream &tin) {

int m = random_value(1,100);
int n = random_value(1,10000);

tin << m << endl;
tin << n << endl;


}
