/*
	Вычислить суммы отрицательных элементов массивов X(N), Y(M), Z(K). (N, M, K<=60).
	Использовать подпрограмму-функцию.
*/

#include <iostream>
#include <locale.h>
#include <iomanip>
using namespace std;
void arrayNew(int N, int M[])
{
	int i;
	for (i = 0; i < N; i++)
	{
		M[i] = 10 - rand() % 30;
		cout << setw(6) << M[i];
	}
	cout << endl;
	cout << endl;
		
}


int arraySum(int num, int A[])
{
	int i;
	int S=0;
	for (i = 0; i < num; i++)
		if (A[i] < 0)
			S += A[i];
	return S;
}


void main() 
{
	setlocale(0, "");
	srand(time(0));
	int n, m, k, x[60], y[60], z[60], s=0, sum1, sum2, sum3;
	cout << "Введите n,m,k ";
	cin >> n >> m >> k;
	arrayNew(n, x);
	arrayNew(m, y);
	arrayNew(k, z);
	sum1 = arraySum(n, x);
	sum2 = arraySum(m, y);
	sum3 = arraySum(k, z);
	cout << "Cумма отриц.элементов массива x = " << sum1 << endl;
	cout << "Cумма отриц.элементов массива y = " << sum2 << endl; 
	cout << "Cумма отриц.элементов массива z = " << sum3 << endl;
}