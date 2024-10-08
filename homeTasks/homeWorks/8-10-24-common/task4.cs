string text = "sagolun salam aleykum ";
string word = "salam";
int key = 0;
int count = 0;  

for (int i = 0; i < text.Length; i++)
{
    if (text[i] == word[key])
    {
        if (key == word.Length - 1)
        {
            count++;  
            key = 0; 
        }
        else
        {
            key++;  
        }
    }
    else
    {
        if (key != 0)
        {
            i -= key;  
        }
        key = 0;  
    }
}

Console.WriteLine("salam sozu text'in daxilinde" +" "+ count+"" + "defe islenib");
