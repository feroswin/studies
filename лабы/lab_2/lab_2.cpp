/*Даны действительные числа а, b, с.Удвоить эти числа, если a≥b≥c, и заменить их абсолютными
значениями, если это не так.*/

#include <iostream>
#include <locale.h>
using namespace std;

int main()
{
	setlocale(LC_ALL, "RUS");
	float a, b, c;
	cout << "Введите a,b,c";
	cin >> a >> b >> c;
	if (a >= b && b >= c) {
		a *= 2;
		b *= 2;
		c *= 2;
		cout << "a=" << a << "\tb=" << b << "\tc=" << c;
	}
	else {
		a = abs(a);
		b = abs(b);
		c = abs(c);
		cout << "a=" << a << "\tb=" << b << "\tc=" << c;
	}
}

