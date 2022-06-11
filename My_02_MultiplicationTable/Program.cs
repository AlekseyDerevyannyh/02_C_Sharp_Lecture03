// Программа вывода таблицы умножения с использованием цикла for
using System;
using static System.Console;

Clear();
for (int i = 2; i < 10; i ++) {
	for (int j = 2; j < 10; j ++) {
		WriteLine($"{i} * {j} = {i * j}");
	}
}
