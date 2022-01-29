string[] array = {"Kazan", ":-)", "123","1234567", "-2"};
string temp = string.Empty;
int count = 0;
int Start = 0;
int End = 4;

for (int i = 0; i < array.Length; i++)
{
    temp = array[i];
    if (temp.Length > Start && temp.Length < End)
    {
        array[count] = temp;
        count++;
    }
}

Array.Resize(ref array, count);

if (array.Length > 0)
{
    Console.WriteLine("Новый массив: ");
    for (int i = 0; i < array.Length; i++)
    {
        Console.WriteLine($"{array[i]}");
    }
}
else
{
    Console.WriteLine("Новый массив пуст");
}
