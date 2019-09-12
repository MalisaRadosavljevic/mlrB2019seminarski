#include "tgen.hpp"

int rand_seed = 0;
int test_count = 10;
string naziv_zadatka = "sudbinski_broj";

void gen_test(int i, ostream &tin) {
int d = random_value(1,31);
int m = random_value(1,12);
int g = random_value(0,2500);

tin << d << endl;
tin << m << endl;
tin << g << endl;
}
