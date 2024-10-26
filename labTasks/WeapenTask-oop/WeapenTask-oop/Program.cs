namespace WeapenTask_oop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Weapen weapon = new Weapen(50,40,20,"auto");
         
            int click = int.Parse(Console.ReadLine());
            switch (click)
            {
                case 0:
                    Console.WriteLine("0 - İnformasiya almaq üçün\r\n1 - Shoot metodu üçün\r\n2 - Fire metodu üçün\r\n3 - GetRemainBulletCount metodu üçün\r\n4 - Reload metodu üçün\r\n5 - ChangeFireMode metodu üçün\r\n6 - Proqramdan dayandırmaq üçün\r\nqısayoldur.\r\n"); break;
                case 1:
                    weapon.Shoot();
                    break;
                case 2:
                    weapon.Fire();
                    break;
                case 3:
                    weapon.GetRemainBulletCount();
                    break;
                case 4:
                    weapon.Reload();
                    break;
                case 5:
                    weapon.ChangeFireMode();
                    break;
                case 6:
                    Console.WriteLine("program dayandi");
                    break;

                default:
                    Console.WriteLine("Duzgun code daxil edilmedi!\n");

                    Console.WriteLine("0 - İnformasiya almaq üçün\r\n1 - Shoot metodu üçün\r\n2 - Fire metodu üçün\r\n3 - GetRemainBulletCount metodu üçün\r\n4 - Reload metodu üçün\r\n5 - ChangeFireMode metodu üçün\r\n6 - Proqramdan dayandırmaq üçün\r\nqısayoldur.\r\n");
                    break;

            }
        }
    }
}
