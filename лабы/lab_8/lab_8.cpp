/*	Преобразовать одномерный массив из n целых элементов таким образом, чтобы сначала
	располагались элементы, делящиеся на 3 нацело, а потом – все остальные
*/
#include <iostream>
#include <locale.h>
#include <ctime>
#include <iomanip>
using namespace std;
void main()
{
	setlocale(LC_ALL, "RUS");
	int i, n, a[1000], j,z=0;
	srand(time(0));
	cout << " Введите кол-во элементов массива ";
	cin >> n;
	for (i = 0; i < n; i++) 
	{
		a[i] = rand() % 4;
		cout << "a[" << i << "]=" << a[i] << endl;
	}

	for (i = 0; i < n; i++)
		for (j=0; j<n-i-1; j++)
			if (a[j] % 3 != 0) 
			{
				z = a[j];
				a[j] = a[j + 1];
				a[j + 1] = z;
			}

	for ( i = 0; i < n; i++)
	{
		cout << setw(6) << a[i];
	}
}