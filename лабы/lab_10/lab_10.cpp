/*
	В данной действительной квадратной матрице порядка п найти наибольший по модулю
	элемент. Поменять его местами с первым элементом матрицы
*/

#include <iostream>
#include <ctime>
#include <iomanip>
#include <locale.h>
using namespace std;
void main()
{
	setlocale(0, "");
	int i, j, n, Imax=0,Jmax=0;
	float a[10][10],b;
	srand(time(0));
	cout << "\nВведите n ";
	cin >> n;
	cout << endl;

	for (i = 0; i < n; i++)                                    // Заполнение масиива 
	{
		for (j = 0; j < n; j++)
		{
			a[i][j] = 15 - rand() % 30 / 2.;
			cout << setw(6) << a[i][j];
		}
		cout << endl;
		cout << endl;
	}

	for (i = 0; i < n; i++)                                    // Вычисление максимального по модулю элемента массива
		for (j = 0; j < n; j++)
		{
			if (fabs(a[i][j]) > fabs(a[Imax][Jmax]))             
			{
				Imax = i;
				Jmax = j;
			}
		}

	cout << endl;
	cout << " Наибольшее по модулю число " << a[Imax][Jmax];

	b = a[0][0];                                               // Перемещение максимального элемента массива на первое место
	a[0][0] = a[Imax][Jmax];
	a[Imax][Jmax] = b;

	cout << endl;
	cout << "\n\tНовая матрица";
	cout << endl;
	cout << endl;
	

	for (i = 0; i < n; i++)                                    // Вывод измененного массива
	{
		for (j = 0; j < n; j++)
			cout << setw(6) << a[i][j];
		cout << endl;
		cout << endl;
	}
}