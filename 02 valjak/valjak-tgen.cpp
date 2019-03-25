#include "tgen.hpp"

int rand_seed = 0;
int test_count = 10;
string naziv_zadatka = "valjak";

void gen_test(int i, ostream &tin) {
	tin << random_value(1, 10) << endl;
	tin << random_value(1, 10) << endl;
}
