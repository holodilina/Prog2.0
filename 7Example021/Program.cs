// Перебор слов (метод рекурсии)
// В некотором машинном алфавите имеются четыре буквы "а", "и", "с", и "в".
// Покажите все слова, состоящие из Т букв, которые можно построить из букв этого алфавита.

// алфавит, который хранится в массиве символов
char[] s = { 'а', 'и', 'с', 'в'};
int count = s.Length;
int n = 1;
for (int i = 0; i < count; i++)
{
    for (int j = 0; j < count; j++) // двухбуквенные слова
    {
        for (int k = 0; k < count; k++) // трехбуквенные слова
        {
        Console.WriteLine($"{n++, -5} {s[i]}");
        }
    }
}