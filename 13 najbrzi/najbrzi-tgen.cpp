#include "tgen.hpp"

int rand_seed = 0;
int test_count = 10;
string naziv_zadatka = "najbrzi";

void gen_test(int i, ostream &tin) {


int t_1 = random_value(10, 60);
int t_2 = random_value(10, 60);
int t_3 = random_value(10, 60);

tin << t_1 << endl;
tin << t_2 << endl;
tin << t_3 << endl;
}
