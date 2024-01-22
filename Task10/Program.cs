int b = 0;
int c = 1;

int a = Convert.ToInt32(Console.ReadLine());
System.Console.Write(b + " " + c + " ");
void Fib(int a)
{

    if (a - 2 == 0)
    {
        return;
    }
    else
    {
        int d = b + c;
        System.Console.Write(d + " ");
        b = c;
        c = d;
        Fib(a - 1);
    }
}

Fib(a);