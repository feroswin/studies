﻿/*  В одномерном массиве, состоящем из n вещественных элементов, вычислить:
	а) номер максимального по модулю элемента массива;
	b) сумму элементов массива, расположенных после первого положительного элемента
*/

#include <iostream>
#include <locale.h>
#include <math.h>
using namespace std;
void main() 
{
	setlocale(LC_ALL, "RUS");
	int i, n, k, max = 0,k1=0;
	float a[1000], s=0;

	cout << "Введите кол-во элементов массива";
	cin >> n;
	for (i = 0; i < n; i++)
	{
		cout << "a[" << i << "]=";
		cin >> a[i];                                             /* Ввод элементов массива до n */
	}

	for(i = 0; i < n; i++)
	{	
		if (fabs(a[i]) > fabs(a[max]))
			max = i;                                           /*Номер максимального по модулю элемента массива*/
	}
	cout << "\nНомер максимального по модулю элемента массива = " << max;
	cout << "\nСумма после последнего положительного числа = " << s;
}

