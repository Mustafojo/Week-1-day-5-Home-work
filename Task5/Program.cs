int cnt = 0;
int a = Convert.ToInt32(Console.ReadLine());
int[] arr = new int[a];
for (int i = 0; i < a; i++)
{
    arr[i] = Convert.ToInt32(Console.ReadLine());
}
for (int i = 0; i < a-1; i++)
{
    if(arr[i] < arr[i + 1])
    {
        cnt++;
    }
}
System.Console.WriteLine(cnt);