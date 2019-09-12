#include "tgen.hpp"

int rand_seed = 0;
int test_count = 10;
string naziv_zadatka = "ponasanje";

void gen_test(int i, ostream &tin) {

int p = random_value(1, 10);
int o = random_value(1, 5);

tin<< p << endl;
tin<< o << endl;


}
