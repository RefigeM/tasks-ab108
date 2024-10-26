namespace WeapenTask_oop
{
    internal class Weapen
    {
        public int _capacityBullet;
        public int CapacityBullet { get; set; }
        public int _bulletCurrent;

        public int BulletCurrent { get; set; }

        public float _secondEndBullet;
        public int SecondEndBullet { get; set; }
        public string _fireMode;
        public string FireMode { get; set; }


        public void Shoot()
        {
            if (BulletCurrent<= CapacityBullet) 
            {
                if (BulletCurrent > 0)
                {
                    Console.WriteLine("1 gulle atildi.");
                    BulletCurrent--;
                    Console.WriteLine($"daraqda {BulletCurrent} sayda gulle qaldi.");
                }
                else
                {
                    Console.WriteLine("daraqda gulle yoxdur");
                }
            }
        }
        public void Fire()
        {
            if (BulletCurrent <= CapacityBullet)
            {

                if (FireMode == "auto")
                {
                    if (CapacityBullet != 0)
                    {
                        float bitmesan = BulletCurrent * SecondEndBullet / CapacityBullet;
                        Console.WriteLine($"daraqdaki {BulletCurrent} sayda gulle {bitmesan} saniyede bitdi");
                        BulletCurrent = 0;

                    }
                    else
                    {
                        Console.WriteLine("daraqda gulle yoxdur");
                    }
                    BulletCurrent = 0;
                }
                else
                {
                    Shoot();
                }
            }
        }
        public int GetRemainBulletCount()
        {
            if (BulletCurrent <= CapacityBullet)
            {
                Console.WriteLine($"daragin dolmasi ucun lazim olan gulle sayi{CapacityBullet - BulletCurrent}");
            }
            return CapacityBullet - BulletCurrent;



        }
        public int Reload()
        {
            if (BulletCurrent <= CapacityBullet) { 

            BulletCurrent = BulletCurrent + CapacityBullet - BulletCurrent;
            Console.WriteLine($"daraq tam dolduruldu,hazirki gulle sayi:{BulletCurrent}");
        }
            return BulletCurrent + CapacityBullet - BulletCurrent;


        }
        public string ChangeFireMode()
        {
            if (FireMode == "single")
            {
                FireMode = "auto";
                Console.WriteLine("auto mod'a kecirildi");
                return FireMode;

            }
            else
            {
                FireMode = "single";
                Console.WriteLine("single mod'a kecirildi");

            }
            return FireMode;
        }
        public Weapen(int BulletCurrent, int CapacityBullet, int SecondEndBullet, string FireMode)
        {
            this.BulletCurrent = BulletCurrent;
            this.CapacityBullet = CapacityBullet;
            this.SecondEndBullet = SecondEndBullet;
            this.FireMode = FireMode;
        }
    }
}
