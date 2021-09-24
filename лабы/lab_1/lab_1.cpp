#include <iostream>
#include <locale.h>
#define _USE_MATH_DEFINES
#include <math.h>
using namespace std;
void main() 
{
	setlocale(LC_ALL, "RUS");
	double z1, z2, a;
	cout << "Введите угол альфа a=";
	cin >> a;
	a = a / 180 * M_PI;
	z1 = (sin(4 * a) / (1 + cos(4 * a))) * (cos(2 * a) / (1 + cos(2 * a)));
	z2 = 1 / tan((3. / 2) * M_PI - a);
	cout << "z1=" << z1 << "\tz2=" << z2;
}