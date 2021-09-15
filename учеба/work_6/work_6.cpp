/*
	Домашнее задание 
	Написать простой калькулятор. Пользователь вводит значение двух переменных.
	Описать меню в консоли для математических операций сложения, вычитания, умножения, деления.
	Через оператор switch реализовать математическую операцию соответствующую пункту меню.
*/

#include <iostream>
#include <locale.h>

using namespace std;

void main()
{
	setlocale(LC_ALL, "RUS");
	float a, b;
	int choice;
	cout << "Введите a и b" << endl;
	cin >> a >> b;
	cout << "Нажмите 1 чтобы сложить числа" << endl;
	cout << "Нажмите 2 чтобы вычисть числа" << endl;
	cout << "Нажмите 3 чтобы умножить числа" << endl;
	cout << "Нажмите 4 чтобы делить числа" << endl;
	cin >> choice;
	switch (choice)
	{
		case 1:
			cout << "a + b= " << a + b << endl;
			break;
		case 2:
			cout << "a - b= " << a - b << endl;
			break;
		case 3:
			cout << "a * b= " << a * b << endl;
			break;
		case 4:
			cout << "a / b= " << a / b << endl;
			break;
	}
}