// Передача строк в функцию
using System;
using static System.Console;

Clear();
void Method21(string msg, int count) {
	int i = 0;
	while (i < count) {
		WriteLine(msg);
		i ++;
	}
}

Method21(msg: "Текст", count: 4);
Method21(count: 4, msg: "новый текст");
Method21("strange text", 4);
