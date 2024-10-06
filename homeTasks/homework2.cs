
int a = int.Parse(Console.ReadLine());
//int a = 56;
int digit;
int result = 0;
while (a > 0)
{
    digit = a % 10;
    a = a / 10;
    result += 1;

}
//Console.WriteLine(result);
Console.WriteLine("Bu  eded" +" "+ result +" " +"reqemlidir.");
