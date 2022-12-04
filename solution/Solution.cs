// Написать программу, которая из имеющегося массива строк формирует новый массив из строк, 
// длина которых меньше, либо равна 3 символам.
// Первоначальный массив можно ввести с клавиатуры либо задать на старте выполнения алгоритма. 
//Примеры:
//[“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
//[“1234”, “1567”, “-2”, “computer science”] → [“-2”]
//[“Russia”, “Denmark”, “Kazan”] → []

string[] array = {"This", "is", "your", "first", "final", "project"};
int n = 3;
string[] result = RetutnNewArrayLessThanN(array, n);
Console.WriteLine($"[{string.Join(", ", array)}] -> [{string.Join(", ", result)}]");

//Для начала сосчитаем, какая длина будет у искомого массива
int FindLenght(string[] input, int n)
{
    int count = 0;
    for (int i = 0; i < input.Length; i++)
    {
        if (input[i].Length <= n)
        {
            count++;
        }
    }
    return count;
}

//Далее запишем функцию, которая вернет искомый массив
string[] RetutnNewArrayLessThanN(string[] input, int n)
{
    string[] output = new string[FindLenght(input, n)];
    for (int i = 0, j = 0; i < input.Length; i++)
    {
        if (input[i].Length <= n)
        {
            output[j] = input[i];
            j++;
        }
    }
    return output;
}


//string[] AskArray() {
//Write("Введите значения через пробел: ");
//return ReadLine().Split(" ");
//}
