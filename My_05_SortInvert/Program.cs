// Программа сортировки одномерного массива от большего к меньшему
using System;
using static System.Console;

Clear();
int[] array = new int[10];

void Random (int[] array) {
	for (int i = 0; i < array.Length; i ++) {
		array[i] = new Random().Next(1, 10);
	}
}
void PrintArray (int[] array) {
	for (int i = 0; i < array.Length; i ++) {
		Write($"{array[i]} ");
	}
}
void SortArray (int[] array) {
	for (int i = 0; i < array.Length - 1; i ++) {
		int j_max = i;
		for (int j = i + 1; j < array.Length; j ++) {
			if (array[j] > array[j_max])	j_max = j;
		}
		int tmp = array[i];
		array[i] = array[j_max];
		array[j_max] = tmp;
	}
}

Random(array);
PrintArray(array);
WriteLine();
SortArray(array);
PrintArray(array);
