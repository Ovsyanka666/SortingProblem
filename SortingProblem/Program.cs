namespace Sorting
{
    class SortingProblem
    {
        static void Main()
        {
            static void ShowArray(int[] nums)
            {
                Console.Write("Ваш массив: ");
                foreach (int el in nums)
                    Console.Write(el + " ");
                Console.WriteLine();
            }

            //Используйте код метода SortArray. Сейчас этот метод сортирует массив по возрастанию значения.
            //Создайте методы SortArrayDesc и SortArrayAsc — сортировка массива от большего к меньшему и сортировка массива от меньшего к большему.

            //Метод SortArray модифицируйте так, чтобы он вызвал оба этих метода.Результаты методов SortArrayAsc и SortArrayDesc должны представлять собой массивы.

            //Метод SortArray должен иметь один входной параметр array и два выходных: sorteddesc и sortedasc.

            int[] ArrayForSort = { 4, 3, 1, 2 };
            
            SortArray(ArrayForSort, out int[] ArrayDown, out int[] ArrayUp); //вызываем метод, который сортирует и по убыванию, и по возрастанию

            ShowArray(ArrayDown);
            ShowArray(ArrayUp);
                        
          


            static void SortArray(in int[] array, out int[] sorteddesc, out int[] sortedasc)
            {
                sorteddesc = SortArrayDesc(array);
                sortedasc = SortArrayAsc(array);
            }//метод, вызывающий следующие два метода

            static int[] SortArrayDesc(int[] array)
            {
                int[] arrayDesk = new int[array.Length];
                for (int i = 0; i < array.Length; i++)
                    arrayDesk[i] = array[i];

                foreach (int el in arrayDesk)
                {
                    for (byte i = 0; i < arrayDesk.Length - 1; i++)
                    {
                        if (arrayDesk[i] < arrayDesk[i + 1])
                        {
                            int temp = arrayDesk[i];
                            arrayDesk[i] = arrayDesk[i + 1];
                            arrayDesk[i + 1] = temp;
                        }
                    }
                }
                return arrayDesk;
            } //метод, сортирующий по убыванию

            static int[] SortArrayAsc(int[] array)
            {
                int[] arrayAsk = new int[array.Length];
                for (int i = 0; i < array.Length; i++)
                    arrayAsk[i] = array[i];

                foreach (int el in arrayAsk)
                {
                    for (byte i = 0; i < arrayAsk.Length - 1; i++)
                    {
                        if (arrayAsk[i] > arrayAsk[i + 1])
                        {
                            int temp1 = arrayAsk[i];
                            arrayAsk[i] = arrayAsk[i + 1];
                            arrayAsk[i + 1] = temp1;
                        }
                    }
                }
                return arrayAsk;
            } //метод, сортирующий по возрастанию
            
        }
    }
}



