namespace _23_10_24_indexer
{
    public class ListInt
    {
        private int[] array;

        public ListInt(int size)
        {
            array = new int[size];
        }

        public int this[int index]
        {
            get
            {
                if (index < 0 || index >= array.Length)
                    return 0;
                return array[index];
            }
            set
            {
                if (index < 0 || index >= array.Length) return;
                array[index] = value;
            }
        }

        public void Add(int num)
        {
            int[] newArray = new int[array.Length + 1];

            for (int i = 0; i < array.Length; i++)
            {
                newArray[i] = array[i];
            }

            newArray[array.Length] = num;

            array = newArray;
        }
        public void Add(params int[] nums)
        {
            int[] newArray2 = new int[array.Length + nums.Length];
            for (int i = 0; i < array.Length; i++)
            {
                newArray2[i] = array[i];
                for (int j = 0; j < nums.Length; j++)
                {
                    newArray2[array.Length + j] = nums[j];
                }

            }
            array = newArray2;
        }
        public int Pop()
        {
            if (array.Length == 0) throw new InvalidOperationException("arrayda elemnt yoxdur."); ;


            int lastElement = array[array.Length - 1];
            int[] newArray3 = new int[array.Length - 1];
            for (int i = 0; i < array.Length - 1; i++)
            {
                newArray3[i] = array[i];
            }
            return lastElement;
        }
        public int Sum()
        {
            int sum = 0;
            for (int i = 0; i < array.Length; i++)
            {
                sum += array[i];
            }
            return sum;
        }
        public int IndexOf(int num)
        {
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == num) return i;
            }
            return -1;
            
        }
        public int LastIndexOf(int num)
        {
            for (int i = array.Length-1; i >=0; i--)
            {
                if (array[i] == num) return i;
            }
            return -1;
        }
        //public int Insert(int num, int index)
        //{
        //    int[] newArray4 = new int[array.Length +1];
        //    for (int i = 0; i < array.Length; i++){
        //        if (i == index) newArray4[i] = num;
        //        newArray4[i]=array[i];  
        //        }
        //    array = newArray4;
        //    return num;
              
            


        //}

    }
}

