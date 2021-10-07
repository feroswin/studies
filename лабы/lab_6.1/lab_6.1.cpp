#include <iostream>
#include <locale.h>
#define _USE_MATH_DEFINES
#include <math.h>
using namespace std;
void main()
{
	setlocale(LC_ALL, "RUS");
	float a = 0, b = M_PI, y=0, h, x;
	int n;
	cout << "Введите n" << endl;
	cin >> n;
	h = (b - a) / n;
	for (x = a + h; x < b; x += h)
		y += (M_PI - x) * sin(x);
	y *= h;
	cout << "y= " << y << endl;
}