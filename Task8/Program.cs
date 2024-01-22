int a = Convert.ToInt32(Console.ReadLine());
char c = Convert.ToChar(Console.ReadLine());
int b = Convert.ToInt32(Console.ReadLine());

if( c == '+')
{
    System.Console.WriteLine(a + b);
}
else if( c == '-')
{
    System.Console.WriteLine(a - b);
}

else if( c == '*')
{
    System.Console.WriteLine(a * b);
}
else if( c == '/')
{
    System.Console.WriteLine(a / b);
}