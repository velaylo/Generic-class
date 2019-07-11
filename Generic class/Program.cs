using System;

namespace Generic_class
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter array size: ");
            int arraySize = Convert.ToInt32(Console.ReadLine());

            GenericClass<int> genericClass = new GenericClass<int>(arraySize);
            int[] array = new int[arraySize];
            Console.WriteLine("Enter array elements: ");
            for (int i = 0; i < arraySize; i++)
            {
                array[i] = Convert.ToInt32(Console.ReadLine());
            }
            genericClass.ArrayFill(array);
            genericClass.ArraySize();
            Console.WriteLine($"Array element with index 3 is {genericClass.GettingElementByIndex(3)}");
            Console.WriteLine($"Array: ");
            for(int i = 0; i < arraySize; i++)
            {
                Console.Write($"{genericClass.tTypeArray[i]}  ");
            }
            Console.WriteLine();

            genericClass.RemoveElementFromArray(3);
            Console.WriteLine($"NewArray without element with third index: ");
            for (int i = 0; i < arraySize-1; i++)
            {
                Console.Write($"{genericClass.newTTypeArray[i]}  ");
            }
            Console.WriteLine();
            genericClass.NewArraySize();
            
            Console.ReadKey();
        }
    }


    class GenericClass<T>
    {
        public T[] tTypeArray;
        public T[] newTTypeArray;

        public void ArrayFill(T[] element)
        {            
            for(int i = 0; i < tTypeArray.Length; i++)
            {
                tTypeArray[i] = element[i];
            }
        }

        public void ArraySize()
        {
            Console.WriteLine($"Array size is {tTypeArray.Length}");
        }

        public void NewArraySize()
        {
            Console.WriteLine($"New array size is {newTTypeArray.Length}");
        }

        public T GettingElementByIndex(int index)
        {
            return tTypeArray[index];
        }

        public void RemoveElementFromArray(int index)
        {
            for (int i = 0,g=0; g < tTypeArray.Length; i++,g++)
            {
                  if (g==index)
                {
                    i--;
                    continue;
                }
                else
                {
                     newTTypeArray[i] = tTypeArray[g];
                }
            }
        }

        public GenericClass(int size)
        {
            tTypeArray = new T[size];
            newTTypeArray = new T[size - 1];
        }
    }
}
