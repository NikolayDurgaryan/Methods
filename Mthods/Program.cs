using System;

namespace Mthods
{
    class Program
    {
        //Զանգվածի մաքսիմալ արժեք
        static int MaxValueOfArray(int[] arrayOfValue,bool firstMax=true)
        {
            int maxValue = arrayOfValue[0];
            if(firstMax)
            {
                for (int i = 0; i < arrayOfValue.Length; i++)
                {
                    if (maxValue < arrayOfValue[i])
                    {
                        maxValue = arrayOfValue[i];
                    }
                }
            }
            else
            {
                for (int i = 0; i < arrayOfValue.Length; i++)
                {
                    if (maxValue <= arrayOfValue[i])
                    {
                        maxValue = arrayOfValue[i];
                    }
                }
            }

            return maxValue;
        }
        //Զանգվածի մինիմալ արժեք
        static int MinValueOfArray(int[] arrayOfValue,bool firstMin=true)
        {
            int minValue = arrayOfValue[0];
            if(firstMin)
            {
                for (int i = 0; i < arrayOfValue.Length; i++)
                {
                    if (minValue > arrayOfValue[i])
                    {
                        minValue = arrayOfValue[i];
                    }
                }
            }
            else
            {
                for (int i = 0; i < arrayOfValue.Length; i++)
                {
                    if (minValue >= arrayOfValue[i])
                    {
                        minValue = arrayOfValue[i];
                    }
                }
            }

            return minValue;
        }
        //Զանգվածում նշված արժեքի քանակը
        static int CountValue(int[] arrayOfValue, int value)
        {
            int count = 0;
            for (int i = 0; i < arrayOfValue.Length; i++)
            {
                if (arrayOfValue[i] == value)
                {
                    count++;
                }
            }
            return count;
        }
        //դրական կամ բացասական արժեքների քանակը---դրական
        static int CountValues(int[] arrayOfValue, bool positive = true)
        {
            int count = 0;
            if (positive)
            {
                for (int i = 0; i < arrayOfValue.Length; i++)
                {
                    if (arrayOfValue[i] > 0)
                    {
                        count++;
                    }
                }
            }
            else
            {
                for (int i = 0; i < arrayOfValue.Length; i++)
                {
                    if (arrayOfValue[i] < 0)
                    {
                        count++;
                    }
                }
            }
            return count;
        }
        //պատահականությամբ նոր զանգված
        static int[] ArrayInRandom(int arrayLength = 10)
        {
            int[] newArray = new int[arrayLength];
            var random = new Random();
            Console.Write("Your array is    ");
            for (int i = 0; i < newArray.Length; i++)
            {
                newArray[i] = random.Next(-10000, 10000);
                Console.Write(newArray[i] + "   ");
            }

            return newArray;
        }
        //Նոր զանգված Consol-ից
        static int[] ArrayFromConsole(int arrayLength = 10)
        {
            int[] newArray = new int[arrayLength];
            for (int i = 0; i < newArray.Length; i++)
            {
                Console.WriteLine("Please type a number");
                if (int.TryParse(Console.ReadLine(), out int parsedValues))
                {
                    newArray[i] = parsedValues;
                    Console.WriteLine($"Index {i} is {parsedValues}");
                }
                else
                {
                    Console.WriteLine(string.Format("It isn`t number\nYour array in index-{0} is 0", i));
                }
            }
            return newArray;
        }
        //զանգվածի բոլոր արժեքների գումարը
        static int SumValues(int[] arrayOfValues)
        {
            int sum = 0;
            for (int i = 0; i < arrayOfValues.Length; i++)
            {
                sum += arrayOfValues[i];
            }
            return sum;
        }
        //զույգ կամ կենտ ինդեքսներով արժեքների գումարը-----զույգ
        static int SumValusByIndex(int[] arrayOfValues, bool Iseven = true)
        {
            int sum = 0;
            if (Iseven)
            {
                for (int i = 2; i < arrayOfValues.Length; i += 2)
                {
                    sum += arrayOfValues[i];
                }
            }
            else
            {
                for (int i = 1; i < arrayOfValues.Length; i += 2)
                {
                    sum += arrayOfValues[i];
                }
            }
            return sum;
        }
        //Զույգ կամ կենտ արժեքների գումարը-----զույգ
        static int SumByValues(int[] arrayOfValues, bool IsEven = true)
        {
            int sum = 0;
            if (IsEven)
            {
                for (int i = 0; i < arrayOfValues.Length; i++)
                {
                    if (arrayOfValues[i] % 2 == 0)
                    {
                        sum += arrayOfValues[i];
                    }
                }
            }
            else
            {
                for (int i = 0; i < arrayOfValues.Length; i++)
                {
                    if (arrayOfValues[i] % 2 != 0)
                    {
                        sum += arrayOfValues[i];
                    }
                }
            }
            return sum;
        }
        //դրական կամ բացասական արժեքների գումարը
        static int SumValuesByAgg(int[] arrayOfValues, bool IsPositive = true)
        {
            int sum = 0;
            if (IsPositive)
            {
                for (int i = 0; i < arrayOfValues.Length; i++)
                {
                    if (arrayOfValues[i] > 0)
                    {
                        sum += arrayOfValues[i];
                    }
                }
            }
            else
            {
                for (int i = 0; i < arrayOfValues.Length; i++)
                {
                    if (arrayOfValues[i] < 0)
                    {
                        sum += arrayOfValues[i];
                    }
                }
            }
            return sum;
        }
        static int ProdValuesByIndex(int[] arrayOfValues, bool isEven = true)
        {
            int product = 1;
            if (isEven)
            {
                for (int i = 2; i < arrayOfValues.Length; i += 2)
                {
                    product *= arrayOfValues[i];
                }
            }
            else
            {
                for (int i = 1; i < arrayOfValues.Length; i++)
                {
                    product *= arrayOfValues[i];
                }
            }
            return product;
        }
        //BubleSort
        static int[] ToBubleSort(int[] arrayOfValues)
        {
            int forChange = 0;
            for (int i = 0; i < arrayOfValues.Length - 1; i++)
            {
                for (int k = 0; k < arrayOfValues.Length - 1; k++)
                {
                    if (arrayOfValues[k] > arrayOfValues[k + 1])
                    {
                        forChange = arrayOfValues[k];
                        arrayOfValues[k] = arrayOfValues[k + 1];
                        arrayOfValues[k + 1] = forChange;
                    }
                }
            }
            return arrayOfValues;
        }
        //ToInsertSort
        static int[] ToInsertSort(int[] arrayOfValues)
        {
            int minValue = 0;
            int minValueIndex = 0;
            int forChange = 0;
            for (int i = 0; i < arrayOfValues.Length; i++)
            {
                minValue = arrayOfValues[i];
                minValueIndex = i;
                for (int k = i; k < arrayOfValues.Length; k++)
                {
                    if (minValue > arrayOfValues[k])
                    {
                        minValueIndex = k;
                        minValue = arrayOfValues[k];
                    }
                }
                forChange = arrayOfValues[i];
                arrayOfValues[i] = arrayOfValues[minValueIndex];
                arrayOfValues[minValueIndex] = forChange;
            }
            return arrayOfValues;
        }
        static int CountProductsOfValue(int[] arrayOfValues,int Value)
        {
            int count = 0;
            for(int i=Value;i<arrayOfValues.Length;i+=Value)
            {
                count++;
            }
            return count;

        }
        static int SumIndexToIndex(int[] arrayOfValues, int startIndex, int endIndex)
        {
            int sum = 0;
            if ((startIndex <= endIndex) && (startIndex >= 0 && startIndex <= arrayOfValues.Length - 1) && (endIndex >= 0 && endIndex <= arrayOfValues.Length - 1))
            {

                for (; startIndex <= endIndex; startIndex++)
                {
                    sum += arrayOfValues[startIndex];
                }
            }
            else
            {
                Console.WriteLine("Sorry but you don`t Know What is array\nI give you number 0");
            }
            
            return sum;
        }
        static int ProductOfArraysAv(int[] arrayOfValues1, int[] arrayOfValues2)
        {
            int average1 = SumValues(arrayOfValues1) / arrayOfValues1.Length;
            int average2 = SumValues(arrayOfValues2) / arrayOfValues2.Length;
            return average1 * average2;
        }
        static int[] DeleteValueFromArr(int[] arrayOfValues,int value)
        {
            int count = CountValue(arrayOfValues, value);
            int k = 0;
            int[] newArray=new int[arrayOfValues.Length-count];

            for(int i=0;i<arrayOfValues.Length;i++)
            {
                if(arrayOfValues[i]!=value)
                {
                    newArray[k] = arrayOfValues[i];
                    k++;
                }
            }
            return newArray;
        }

        static void Main(string[] args)
        {
            //211
            int[] caseArray = ArrayInRandom();
            Console.WriteLine();
            Console.WriteLine("211 -----> " + SumValuesByAgg(caseArray) / CountValues(caseArray));
            //214
            Console.WriteLine("214 -----> " + SumValuesByAgg(caseArray, false) / CountValues(caseArray, false));
            //215
            Console.WriteLine("215 -----> " + SumValusByIndex(caseArray));
            //216
            Console.WriteLine("216 -----> " + ProdValuesByIndex(caseArray));
            //219
            Console.WriteLine("219 -----> " + CountProductsOfValue(caseArray, 100));
            //221
            Console.WriteLine("221 -----> " + SumIndexToIndex(caseArray, 3, 0));
            //251
            Console.WriteLine("251 -----> " + MaxValueOfArray(caseArray));
            //252
            Console.WriteLine("252 -----> " + MinValueOfArray(caseArray));
            //257
            Console.WriteLine("258 -----> " + MaxValueOfArray(caseArray, false));
            //260
            Console.WriteLine("260 -----> " + MinValueOfArray(caseArray, false));
            //2-array
            int[] caseArray2 = ArrayFromConsole();
            //261
            Console.WriteLine("261 -----> "+ProductOfArraysAv(caseArray, caseArray2));
            //271
            Console.WriteLine("271 -----> " + CountValue(caseArray, 256));
            //277
            foreach(int y in DeleteValueFromArr(caseArray2, 236))
            {
                Console.Write(y+"   ");
            }

        }

    }
}
