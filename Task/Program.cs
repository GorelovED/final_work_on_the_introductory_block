Console.Write("Сколько элементов Вы хотите ввести? ");
int size = Convert.ToInt32(Console.ReadLine());

string[] arrayOne = new string[size];
for (int i = 0; i < size; i++)
{
    Console.WriteLine($"Введите {i+1}-й элемент: ");
    string element = Convert.ToString(Console.ReadLine());
    arrayOne[i] = element;
}

string[] arrayTwo = new string[size];
int len = 3;
int pos = 0;

for (int j = 0; j < size; j++)
{
    if (arrayOne[j].Length <= len)
    {
        arrayTwo[pos] = arrayOne[j];
        pos++;
    }
}

Console.WriteLine($"[{string.Join(", ", arrayTwo)}] -> [{string.Join(", ",arrayTwo )}]");
