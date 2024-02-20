// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!123aaasss333");
// 生成20个随机数，并从小到大进行排序
int[] arr = new int[20];
Random r = new Random();
    for (int i = 0; i < arr.Length; i++)
{
    arr[i] = r.Next(1, 100);
}
    Array.Sort(arr);
    foreach (int i in arr)
{
       Console.WriteLine(i);
}
int a = 5;
Console.Read();