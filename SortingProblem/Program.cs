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

            ShowArray(ArrayDown); //выводим оба отсортированных массива в консоль
            ShowArray(ArrayUp);
                        
            ArrayDown = SortArrayDesc(ArrayForSort); //вызываем методы отдельно, всё работает как надо
            ShowArray(ArrayDown);
            ArrayUp = SortArrayAsc(ArrayForSort); 
            ShowArray(ArrayUp);


            static void SortArray(in int[] array, out int[] sorteddesc, out int[] sortedasc)
            {
                sorteddesc = SortArrayDesc(array);
                sortedasc = SortArrayAsc(array);
            }//метод, вызывающий следующие два метода

            static int[] SortArrayDesc(int[] array)
            {
                foreach (int el in array)
                {
                    for (byte i = 0; i < array.Length - 1; i++)
                    {
                        if (array[i] < array[i + 1])
                        {
                            int temp = array[i];
                            array[i] = array[i + 1];
                            array[i + 1] = temp;
                        }
                    }
                }
                return array;
            } //метод, сортирующий по убыванию

            static int[] SortArrayAsc(int[] array)
            {
                foreach (int el in array)
                {
                    for (byte i = 0; i < array.Length - 1; i++)
                    {
                        if (array[i] > array[i + 1])
                        {
                            int temp1 = array[i];
                            array[i] = array[i + 1];
                            array[i + 1] = temp1;
                        }
                    }
                }
                return array;
            } //метод, сортирующий по возрастанию
            
        }
    }
}



