string text = "Mirzazada Rafiga";
char letter = 'a';
int count=0;
for(int i=0; i<text.Length; i++)
{
    if (text[i] == letter)
    {
        count += 1;
    }
}
Console.WriteLine(count);



