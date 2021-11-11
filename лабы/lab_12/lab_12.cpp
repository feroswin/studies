/*
	Вычислить суммы отрицательных элементов массивов X(N), Y(M), Z(K). (N, M, K<=60).
	Использовать подпрограмму-функцию.
*/

#include <iostream>
#include <locale.h>
#include <iomanip>
using namespace std;
void arrayNew(int kol, int M[])
{
	int i;
	for (i = 0; i < kol; i++)
	{
		M[i] = 10 - rand() % 30;
		cout << setw(6) << M[i];
	}
	cout << endl;
	cout << endl;
		
}


int arraySum(int S, int num, int A[] )
{
	int i;
	for (i = 0; i < num; i++)
		if (A[i] < 0)
			S += A[i];
	return S;
}


void main() 
{
	setlocale(0, "");
	srand(time(0));
	int n, m, k, x[60], y[60], z[60], s=0, sum;
	cout << "Введите n,m,k";
	cin >> n >> m >> k;
	arrayNew(n, x);
	arrayNew(m, y);
	arrayNew(k, z);
	sum = arraySum(arraySum(arraySum(s, n, x), m, y), k, z);
	cout << sum;
}