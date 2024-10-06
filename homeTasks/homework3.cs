int[] numbers = {2,45,22,9,0,15,7};
int result = 0;
for(int i=0; i < numbers.Length; i++)
{
    //Console.WriteLine(numbers[i]);
    if(numbers[i]>=0 && numbers[i] < 10)
    {
        result+=1;
    }

}
Console.WriteLine( " Bu arrayda" +" "+ result+" "+" reqem var.");