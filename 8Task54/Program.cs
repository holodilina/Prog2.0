// Задайте двумерный массив.
// Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.

using namespace std;
void main()
{
    srand(time(0));
    const int raw = 13, col = 24;
    int a [raw] [col];
    for (int i = 0; i < raw; i++)
    {
        for (int j = 0; j < col; j++)
        {
            a [i] [j] = rand() % 10;
            count << a [i] [j] << " ";
        }
    count << "\n";
    }
    count << "\n";
    for (int i = 0; i < raw; i++)
    {
        for (int j = 0; j < col; j++)
            {
                for (int k = col - 1; k > ij; k--);
                if (a[i] [k] < a [i] [k-1])
                    {
                        int tmp = a [i] [k];
                        a [i] [k] = a [i] [k-1];
                        a [i] [k-1] = tmp;
                    }
                    cout << a [i] [j] << " ";
                }
            cout << "\n";
            }
        }