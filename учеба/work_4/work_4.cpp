/*
	Написать программу вычисления сопротивления электрической цепи,
	состоящей из двух сопротивлений.Сопротивления могут быть соединены 
	последовательно или параллельно. Ниже приведен рекомендуемый вид 
	экрана во время выполнения программы (данные, введенные пользователем, 
	выделены полужирным шрифтом).

	Вычисление сопротивления электрической цепи.
	Введите исходные данные:
	Величина первого сопротивления (Ом) -> 15
	Величина второго сопротивления (Ом)-> 27.3
	Тип соединения (1 — последовательное, 2 — параллельное) -> 2
	Сопротивление цепи: 9.68 Ом
*/

#include <iostream>
#include <locale.h>

using namespace std;

int main()
{
	setlocale(LC_ALL, "RUS");
	float resistance1, resistance2, type_connect, circuit_resistance;
	cout << "Введите первое сопротивление -> ";
	cin >> resistance1;
	cout << "\nВведите второе сопротивление -> ";
	cin >> resistance2;
	cout << "\nВыберите тип соединения (1 - последовательное, 2 - параллельное) -> ";
	cin >> type_connect;
	if (type_connect == 1) {
		circuit_resistance = resistance1 + resistance2;
		cout << "Сопротивление цепи: " << circuit_resistance << endl;
	}
	else {
		circuit_resistance = 1/(1 / resistance1 + 1 / resistance2);
		cout << "Сопротивление цепи: " << circuit_resistance << endl;
	}
	system("PAUSE");
}