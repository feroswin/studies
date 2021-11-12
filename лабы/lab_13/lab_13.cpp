/*
	Заполнить файл N действительными числами, полученными с помощью генератора
	случайных чисел. Найти сумму минимального и максимального элементов этого файла
*/

#include <iostream>
#include <fstream>
#include <locale.h>
#include <ctime>
using namespace std;
void main()
{
	setlocale(0, "");
	int i, n;
	float c, max=0, min=0;
	srand(time(0));
	ofstream fp("vse.txt");
	cout << "Введите количество чисел n";
	cin >> n;
	cout << "Заполнение файла" << endl;
	for (i = 0; i < n; i++)
	{
		c = 10 - rand() % 30 / 2.;
		fp << c << " ";
		cout << c << endl;
	}
	fp.close();
	cout << endl;
	ifstream fp1("vse.txt");
	while (fp1 >> c)
	{
		if (c > max)
			max = c;
		if (c < min)
			min = c;
	}
	cout << "Минимальный элемент = " << min << endl;
	cout << "Максимальный элемент = " << max << endl;
	cout << "Cумма макисального и минимального элементов = " << min + max << endl;
}
