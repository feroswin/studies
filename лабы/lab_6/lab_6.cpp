#include <iostream>
#include <locale.h>
#define _USE_MATH_DEFINES
#include <math.h>
using namespace std;
void main() 
{
	setlocale(LC_ALL, "RUS");
	float a, b, h, x, s1 = 0, s2 = 0, s, res, y=0;
	int i, n;
	cout << "Введите n" << endl;
	cin >> n;
	a = 0;
	b = M_PI;
	x = a;
	h = (b - a) / 2 / n;
	for (i = 2; i <= 2 * n - 2; i += 2) 
	{
		s1 += (M_PI - x) * sin(x);
		x += 2 * h;
	}
	s1 *= 2;
	x = a;
	for (i = 1; i <= 2 * n - 1; i += 2) 
	{
		s2 += (M_PI - x) * sin(x);
		x += 2 * h;
	}
	s2 *= 4;
	s = s1 + s2;
	res = (b - a) * s / (6 * n);
	cout << "Интеграл по формуле Симпсона = " << res << endl;

	h = (b - a) / n;
	for (x = a + h; x < b; x += h)
		y += (M_PI - x) * sin(x);
	y += ((M_PI - a) * sin(a) + (M_PI - b) * sin(b))/2;
	y *= h;
	cout << "Интеграл по формуле трапеции = " << y << endl;
}
