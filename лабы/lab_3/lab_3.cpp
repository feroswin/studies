#include <iostream>
#include <locale.h>
using namespace std;
void main() 
{
	setlocale(LC_ALL, "RUS");
	float x, y;
	cout << "Введите x,y";
	cin >> x >> y;
	if ((x <= 0 && y <= 0 && y >= -x - 6)||(x >= 0 && y >= 0 && y <= -x + 6))
		cout << "Точка попадает в закрашенную область";
	else
		cout << "Точка не попадает в закрашенную область";
}