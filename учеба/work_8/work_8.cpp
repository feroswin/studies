#include <iostream>
#include <iomanip>
#include <locale.h>
#include <ctime>
using namespace std;
void Array(int n, int X[])
{
	srand(time(0));
	int i;
	for (i = 0; i < n; i++)
	{
		X[i] = rand() % 70;
		cout << setw(6) << X[i];
	}
	cout << endl;
}
void Sort(int n, int X[])
{
	int i, j, p;
	for (i = 0; i < n; i++)
	{
		for (j = 0; j < n-i; j++)
		{
			p = X[i];
			X[i] = X[n - i-1];
			X[n - i-1] = p;
		}
	}
	cout << "Изменный массив" << endl;
	for (i = 0; i < n; i++)
		cout << setw(6) << X[i];
}
int main() 
{
	setlocale(0, "");
	int i, n, a[100];
	for (i = 1; i <= 3; i++)
	{
		cout << "\n Введите кол-во элементов массива";
		cin >> n;
		Array(n, a);
		Sort(n, a);

	}
}