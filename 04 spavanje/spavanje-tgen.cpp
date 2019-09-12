#include "tgen.hpp"

int rand_seed = 0;
int test_count = 10;
string naziv_zadatka = "spavanje";

void gen_test(int i, ostream &tin) {

int h = random_value(0,24);
int m = random_value(0,60);
int hh = random_value(0,24);
int mm = random_value(0,60);

tin << h << endl;
tin << m << endl;
tin << hh << endl;
tin << mm << endl;
}
