/*
	Дана строка. Преобразовать ее, заменив точками все двоеточия (:), встречающиеся среди
	первых n/2 символов, и заменив точками все восклицательные знаки, встречающиеся
	среди символов, стоящих после n/2 символов.
*/

#include <iostream>
#include <locale.h>
#include <string.h>
using namespace std;
void main()
{
	setlocale(0, "");
	char S[100];
	int n,i,fn;
	cout << " Введите строку ";
	gets_s(S);
	n = strlen(S);
	fn = n;
	n = n / 2;
	for (i = 0; i < n; i++)
		if (S[i] == ':')
			S[i] = '.';
	for (i = fn; i > n - 1; i--)
		if (S[i] == '?')
			S[i] = '.';
	puts(S);
}