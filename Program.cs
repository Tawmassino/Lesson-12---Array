using System.Drawing;
using System.Text;
using System.Threading.Channels;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Lesson_12___Array
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region Task1


            //#region Top
            //Console.WriteLine("--------------------");
            //int[] TopTask = { 4, 8, 15, 16, 23, 42 };
            ////TopTask.GetLength;
            //int topArrayNumber = ArrayTop(TopTask);
            //Console.WriteLine("the top number is simply " + TopTask.Max() + " and also " + topArrayNumber);
            //Console.WriteLine("--------------------");
            //#endregion



            //#region ArraySum
            //Console.WriteLine("--------------------");
            //int[] sumTask = { 4, 8, 15, 16, 23, 42 };
            //int sum = ArraySum(sumTask);

            //Console.WriteLine("The sum of the array is " + ArraySum(sumTask) + " or simply " + sumTask.Sum());
            //Console.WriteLine("--------------------");
            //#endregion



            //#region SquareArray
            //int[] originalInts = { 4, 8, 15, 16, 23, 42 };
            //SquaredArray(originalInts);
            //foreach (int i in originalInts)
            //{
            //    Console.WriteLine($"The squared array is {i}");
            //}
            //#endregion

            //#region ReversedTask
            //Console.WriteLine("--------------------");
            //int[] arejus = { 4, 8, 15, 16, 23, 42 };
            //ReversedArray(arejus);
            //Console.WriteLine("--------------------");
            //#endregion


            #endregion



            //--task 2

            #region Task2

            //#region stringToChar
            ////char[] sakinys = Console.ReadLine().ToCharArray();//TIKTU LABAI GERAI, BET NE UZDUOCIAI, NES TEN REIKIA METODO
            //Console.WriteLine("--------------------");
            //Console.WriteLine("write a sentence");
            //string sakinys = Console.ReadLine();
            //StringToChar(sakinys);
            //#endregion

            //#region firstLetter
            //Console.WriteLine("--------------------");
            //FirstLetter(sakinys);
            ////  Console.WriteLine(FirstLetter);
            //#endregion

            //#region lastLetter
            //Console.WriteLine("--------------------");
            //lastLetter(sakinys);
            //// Console.WriteLine(lastLetter);
            //#endregion

            #endregion


            #region Task3
            Console.WriteLine("Task 3 begin");
            int[] numbersTask3 = { 42, 8, 15, 108, 16, 23, 4 };

            int[] array = new int[] { 5, 7, 2, 3, 9 };

            Array.Sort(numbersTask3, (x, y) => y.CompareTo(x));

            Console.WriteLine(System.String.Join(", ", numbersTask3));

            #endregion

            int[] array2 = new int[7];
            AddElementToArray(array2);



        }



        // ========================================= METHODS ========================================= \\ //metodai turi buti programoje


        public static int[] RemoveElementFromArray(int[] nums)// ok???
        {
            if (nums.Length <= 1)
            {
                // If the array has only one element or is empty, return an empty array or the same array.
                return new int[0];
            }

            int[] lesserArray = new int[nums.Length - 1];

            // Copy all elements from the original array to the new array except the last one.
            for (int i = 0; i < lesserArray.Length; i++)
            {
                lesserArray[i] = nums[i];
            }

            return lesserArray;

        }


        public static void AddElementToArray(int[] nums)
        {
            int[] array = new int[10];
        }

        public static void lastLetter(string stringas)
        {
            char[] ArrayInMethod = stringas.ToUpper().ToCharArray();
            Console.ForegroundColor = ConsoleColor.Red;
            char last = ArrayInMethod[ArrayInMethod.Length - 1];
            Console.WriteLine(last);
            Console.ResetColor();
        }


        public static void FirstLetter(string stringas)
        {
            char[] ArrayInMethod = stringas.ToUpper().ToCharArray();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(ArrayInMethod[0]);
            Console.ResetColor();
        }

        public static void StringToChar(string stringas)
        {
            StringBuilder stringiklis = new StringBuilder();//susikuriam bilderi
            stringiklis.Append("{");//pridedame kad bilderis pradzioje teksta pradetu taip

            char[] ArrayInMethod = stringas.ToCharArray();

            for (int i = 0; i < ArrayInMethod.Length; i++)
            {
                //string c = "'" + ArrayInMethod[i] + "'";//veikia su string paprastai
                //Console.Write(c);

                //bet pasibandom su bilderiu
                //cikle kiekvienai raidei prides po kazka
                stringiklis.Append("'");
                stringiklis.Append(ArrayInMethod[i]);
                stringiklis.Append("'");

                // Check if it's not the last character before appending a comma
                if (i < ArrayInMethod.Length - 1)
                {
                    stringiklis.Append(",");
                }
            }

            stringiklis.Append("}");//pridedame kad bilderis pabaigoje teksta uzbaigtu taip
            Console.WriteLine(stringiklis.ToString());
        }

        public static void ReversedArray(int[] nums)
        {
            for (int i = nums.Length - 1; i >= 0; i--)

            //for (int i = 0; i < nums.Length; i--)
            {
                Console.WriteLine(nums[i]);
            }
        }

        public static void SquaredArray(int[] nums)
        {
            for (int i = 0; i < nums.Length; i++)
            { nums[i] *= nums[i]; }

            //foreach (int number in nums) { number = number * number; }//gerai bet foreach neduoda taip,
            //reikia paprasto for
            //return nums;
        }

        public static int ArraySum(int[] nums)
        {
            int sum = 0;
            for (int i = 0; i < nums.Length; i++)
            { sum += nums[i]; }
            return sum;
        }

        public static int ArrayTop(int[] nums)
        {
            if (nums.Length == 0)
            {
                // Handle the case where the array is empty.
                throw new InvalidOperationException("The array is empty.");
            }
            int topNumber = nums[0];// Initialize with the first element.

            for (int i = 1; i < nums.Length; i++)
            {
                if (nums[i] > topNumber)
                {
                    topNumber = nums[i]; // Update if a larger number is found.
                }
            }
            return topNumber;
        }
    }
}
