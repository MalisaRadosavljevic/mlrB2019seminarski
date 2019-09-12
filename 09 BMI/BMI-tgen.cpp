#include "tgen.hpp"

int rand_seed = 0;
int test_count = 10;
string naziv_zadatka = "BMI";

void gen_test(int i, ostream &tin) {

double k = random_value(10,200);
double h = random_value(0.5,2.5);

tin << fixed << setprecision(2) << k << endl;
tin << fixed << setprecision(2) << h << endl;





}
