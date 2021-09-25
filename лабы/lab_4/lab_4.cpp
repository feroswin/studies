#include <iostream>
#include <locale.h>
using namespace std;
void main() 
{
	setlocale(LC_ALL, "RUS");
	int a, k;
	cout << "Введите количество долларов";
	cin >> a;
	if (a >= 11 && a <= 14) {
		cout << a << " долларов";
	}
	else 
	{
		k = a % 10;
		switch (k)
		{
		case 1:
		{
			cout << a << " доллар";
			break;
		}
		case 2:
		case 3:
		case 4:
		{
			cout << a << " доллара";
			break;
		}
		case 0:
		case 5:
		case 6:
		case 7:
		case 8:
		case 9:
		{
			cout << a << " долларов";
			break;
		}
		}
	}
}