/* 
	Необходимо суммировать все нечётные целые числа в диапазоне,
	который введёт пользователь с клавиатуры.
*/

#include <iostream>
#include <locale.h>
using namespace std;
void main()
{
	setlocale(LC_ALL, "RUS");
	int start, stop, sum = 0;
	cout << "Введите начало диапазона" << endl;
	cin >> start;
	cout << "Введите конец диапазона" << endl;
	cin >> stop;
	for (start;start <= stop; start++)
		{
		if(start % 2 != 0 && start % start == 0)
			{
			sum += start;
			cout << start << endl;
			}
		}
}