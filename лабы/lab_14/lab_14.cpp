/*
	Распечатать фамилии тех учеников класса, которые являются хорошистами и
	отличниками по итогам года. Также указать, насколько их средний балл отличается от
	среднего балла класса.
*/

#include <iostream>
#include <locale.h>
#include <conio.h>
#include <iomanip>
#include <math.h>
using namespace std;
void main()
{
	setlocale(LC_ALL, ".1251");
	int i, n;
	float sum=0, sr_students;
	cout << " Введите кол-во студентов n ";
	cin >> n;
	struct student {
		char fam[30];
		int ocenka1;
		int ocenka2;
		int ocenka3;
		float arifm;
	};
	student stud[30];
	for (i = 0; i < n; i++)
	{
		cout << endl;
		cout << " Студент " << i + 1 << endl;
		cout << "\n Фамилия: ";
		cin >> stud[i].fam;
		cout << "Оценка по математики: ";
		cin >> stud[i].ocenka1;
		cout << "Оценка по физике: ";
		cin >> stud[i].ocenka2;
		cout << "Оценка по информатике: ";
		cin >> stud[i].ocenka3;																// Заполнили поля структуры
		stud[i].arifm = (stud[i].ocenka1 + stud[i].ocenka2 + stud[i].ocenka3) / 3.;			// Вычисление ср.арифметического каждого ученика
	}							
	cout << endl;
	for (i = 0; i < n; i++)
		sum += stud[i].arifm;
	sr_students = sum / n;			
	cout << "Средний балл класса " << sr_students << endl;									// Нашли среднее арифеметическое всех учеников

	for (i = 0; i < n; i++)
	{
		if (stud[i].ocenka1 == 5 && stud[i].ocenka2 == 5 && stud[i].ocenka3 == 5)			// Проверяем является ли студент отличником или хорошистом
			cout << "Отличником является " << stud[i].fam 
			<< ". Средний балл ученика равен " << setw(3) << setprecision(3) << stud[i].arifm
			<< ". Он отличается от среднего балла класса на " 
			<< setw(3) << setprecision(3) << fabs(sr_students-stud[i].arifm) << endl;
		else if ((stud[i].ocenka1 > 3 && stud[i].ocenka1 <=5) && (stud[i].ocenka2 > 3 && stud[i].ocenka2 <= 5) && (stud[i].ocenka3 > 3 && stud[i].ocenka3 <= 5))
			cout << "Хорошистом является " << stud[i].fam
			<< ". Средний балл ученика равен " << setw(3) << setprecision(3) << stud[i].arifm
			<< ". Он отличается от среднего балла класса на "
			<< setw(3) << setprecision(3) << fabs(sr_students - stud[i].arifm) << endl;
	}
}