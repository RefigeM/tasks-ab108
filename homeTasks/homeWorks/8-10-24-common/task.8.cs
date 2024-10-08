int[] arr = { 1, 23, 4, 56, 7, 89, 50, 22 };
int sumPositive = 0;
int sumNegative = 0;

for(int i=0; i<arr.Length; i++)
{
    if (i % 2 == 0)
    {
        sumPositive += arr[i];

    }
    else
    {
        sumNegative += arr[i];

    }

}


if (sumPositive == sumNegative)
{
    Console.WriteLine("cut indexde duran elementlerin cemi tek indexde duran elementlerin cemine beraberdir");


}
else if(sumPositive > sumNegative)
{
    Console.WriteLine("cut indexde duran elementlerin cemi tek indexde duran elementlerin ceminden boyukdur.");

}
else
{
    Console.WriteLine("cut indexde duran elementlerin cemi tek indexde duran elementlerin ceminden kicikdir.");

}