using System.Data;

int cnt = 0;
int a = Convert.ToInt32(Console.ReadLine());
int[] arr = new int[a];
for (int i = 0; i < a; i++)
{
    arr[i] = Convert.ToInt32(Console.ReadLine());
}
for (int i = 0; i < a; i++)
{
  
    if(arr[i] > 0)
    {
        cnt++;
    }
}
int pos = 0;
for (int i = 0; i < a; i++)
{
  
    if(arr[i] < 0)
    {
        pos++;
    }
}
int zeros = 0;
for (int i = 0; i < a; i++)
{
  
    if(arr[i] == 0)
    {
        zeros++;
    }
}
int Even = 0;
for (int i = 0; i < a; i++)
{
  
    if(arr[i] % 2 == 0)
    {
        Even++;
    }
}
int Odd = 0;
for (int i = 0; i < a; i++)
{
  
    if(arr[i] % 2 != 0)
    {
        Odd++;
    }
}
int Sum = 0;
for (int i = 0; i < a; i++)
{
    Sum += arr[i];
}

System.Console.WriteLine("Negative = " + cnt);
System.Console.WriteLine("Positive = " + pos);
System.Console.WriteLine("Zeros = " + zeros);
System.Console.WriteLine("Even = " + Even);
System.Console.WriteLine("Odd = " + Odd);
System.Console.WriteLine("Sum = " + Sum);





