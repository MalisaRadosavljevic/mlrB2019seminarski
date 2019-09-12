#include "tgen.hpp"

int rand_seed = 0;
int test_count = 10;
string naziv_zadatka = "potrosnja";

void gen_test(int i, ostream &tin) {

int kapacitet = random_value(20,100);
int S= random_value(800,1200);

tin << kapacitet  << endl;
tin << S  << endl;
}
