int number = 435; 
int finalNum = 0;
int a = number;
int countD = 0;

while (a > 0)
{
    a /= 10;  
    countD++;
}
int[] arr = new int[countD];
a = number;
for (int i = 0; i < arr.Length; i++)
{
    arr[i] = a % 10;
    a /= 10;
}
for (int j = 0; j < arr.Length; j++)
{
    for (int i = 0; i < arr.Length - 1; i++)
    {
        if (arr[i] < arr[i + 1])
        {
            arr[i] = arr[i] + arr[i + 1]; 
            arr[i + 1] = arr[i] - arr[i + 1];
            arr[i] = arr[i] - arr[i + 1];
        }
    }
}
for (int i = 0; i < arr.Length; i++)
{
    finalNum = finalNum * 10;
    finalNum = finalNum + arr[i];
}
Console.WriteLine(number + " Ededinin reqemlerinden duzele bilecek en boyuk eded " + finalNum);
