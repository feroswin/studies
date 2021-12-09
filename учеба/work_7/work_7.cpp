#include <iostream>
#include <locale.h>
#include <conio.h>
using namespace std;
void main() 
{
	setlocale(0, "");
	int i, N;
	cout << "Введите кол-во студентов";
	cin >> N;
	struct student
	{
		char fam[15];
		int grup;
		char data[15];
	};
	student stud[20];
	for (i = 0; i < N; i++)
	{
		cout << " Студент " << i + 1;
		cout << "\nФамилия: ";
		cin >> stud[i].fam;
		cout << "\nГруппа: ";
		cin >> stud[i].grup;
		cout << "\nДата: ";
		cin >> stud[i].data;
		cout << endl;
	}
	for (i=0;i<N;i++)
		if (stud[i].fam[0] == 'В')
		{
			cout << "\nФамилия ", stud[i].fam;
			cout << "  Группа  ", stud[i].grup;
			cout << "  Дата  ", stud[i].data;
		}
}