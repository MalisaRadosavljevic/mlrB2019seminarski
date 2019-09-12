#include "tgen.hpp"

int rand_seed = 0;
int test_count = 10;
string naziv_zadatka = "postar";

void gen_test(int i, ostream &tin) {

 int n = random_value(10, 1000);

tin << n << endl;
}
