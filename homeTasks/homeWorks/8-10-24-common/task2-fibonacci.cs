int num = 0;
int fib = 1;

int index = 0;
while (true)
{
    Console.WriteLine(num + " ");

    fib = fib + num;
    num = fib - num;

    index++;
    if (index == 100)
    {
        break;
    }
}