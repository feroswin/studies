#include <iostream>
#include <locale.h>
#include <math.h>
#include <iomanip>
using namespace std;
void main()
{
	setlocale(LC_ALL, "RUS");
	float Xn, Xk, dx, eps, x, s, f;
	int i, n;

	cout << "Введите Xn = " << endl;
	cin >> Xn;
	cout << "Введите Xk = " << endl;
	cin >> Xk;
	cout << "Введите шаг dx = " << endl;
	cin >> dx;
	cout << "Введите точность eps" << endl;
	cin >> eps;
	cout << "\n         x     S(x)       sin x       n\n";
	n = 0;
	for (x = Xn; x <= Xk; x += dx) {
		s = 1;
		for (f = 1, i = 2; fabs(f) > eps; i += 2) {
			f = f * (-x * x / (i + 1) / i);
			s += f;
			n = i;
		}
		cout << "\n " << setprecision(4) << setw(10) << x
			<< setprecision(4) << setw(10) << s
			<< setprecision(4) << setw(10) << sin(x)/x
			<< setw(10) << n;
	}
}