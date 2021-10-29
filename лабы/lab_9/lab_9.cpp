/*	
	Заполнить матрицу случайными числами. Отобразить левую половину матрицы на правую
	зеркально симметрично относительно вертикальной оси.
*/

#include <iostream>
#include <iomanip>
#include <ctime>
using namespace std;
void main()
{
	setlocale(0, "");
	int i, j, a[15][15], k, st, n, m;
	srand(time(0));
	cout << endl;
	cout << " Введите кол-во строк ";
	cin >> n;
	cout << "\n Введите кол-во столбцов ";
	cin >> m;
	for (i = 0; i < n; i++)
	{ 
		for (j = 0; j < m; j++)
		{
			a[i][j] = rand() % 100;
			cout << setw(6) << a[i][j];
		}
		cout << endl;
		cout << endl;
	}
	k = m / 2;
	for (i = 0; i < n; i++)
	{
		st = 0;
		for (j = k,st=1; j < m; j++)
		{
			a[i][j] = a[i][j - st];
			st+=2;
		}
		cout << endl;
	}
	cout << "\tНовая матрица" << endl;
	cout << endl;
	for (i = 0; i < n; i++)
	{
		for (j = 0; j < m; j++)
			cout << setw(6) << a[i][j];
		cout << endl;
		cout << endl;
	}
}
