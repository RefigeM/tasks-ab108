//Methodlar yaradirsiz. Methoda ad gonderende adi ekrana cixardir(Sabir), ad ve soyad gonderende soyadi adi ekrana cixardir(Guliyev Sabir), ad, soyad ve ata adı göndərildikdə adin baş hərfi nöqtə soyad ata adi ekrana cixardirsiz(S.Guliyev Mehti). Methodlarin adi eyni olmalıdır.
namespace task_c
{
    internal class Program
    {
        static void Main()
        {
            personalInf("Sabir");

            personalInf("Sabir", "Guliyev");

            personalInf("Sabir", "GUliyev","Mehti");
        }
        static void personalInf(string name)
        {
            Console.WriteLine($"{name}");
        }
        static void personalInf(string name,string surname)
        {
            Console.WriteLine($"{surname} {name}");
        }
        static void personalInf(string name, string surname, string patronymic)
        {
            for (int i = 0; i < 1; i++) {
                Console.WriteLine(name[i] + ". " + surname +" "+ patronymic);
            }
        }
    }
}
