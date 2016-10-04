using System;

namespace ConsoleApplication
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //#1: Print All Integers 1-255
            for(int i = 1; i <= 255; i++) {
                Console.WriteLine(i);
            }
            //#2: Print Odd Integers 1-255
            for(int i = 1; i <= 255; i++) {
                if(i % 2 != 0) {
                    Console.WriteLine(i);
                }
            }
            //#3: Print Sum of Integers 0-255, with corresponding number.
            int sum = 0;
            for(int i = 0; i <= 255; i++) {
                sum = sum + i;
                Console.WriteLine("Number: " + i + " " + "Sum: " + sum);
            }
            //#4: Iterating Through An Array
            int[] array;
            array = new int[] {1,3,5,7,9,13};

            for(int i = 0; i < array.Length; i++) {
                Console.WriteLine(array[i]);
            }
            //#5: Find Max Integer 
            int[] array;
            array = new int[] {1,3,5,7,9,13};
            int max = array[0];
            for(int i = 0; i < array.Length; i++) {
                if(array[i] > max) {
                    max = array[i];
                }
            }
            Console.WriteLine("Max: " + max);
            //#6: Find Average
            int sum = 0;
            int[] x;
            x = new int [] {1,3,5,7,9,13};
            for(int i = 0; i < x.Length; i++){
                sum += x[i];
            }
            int avg = sum / x.Length;
            Console.WriteLine("Average: " + avg);
            // #7: Create Array with All Odd Integers between 1-255
            var oddArray = new int[128];
            for (int i = 0, odd = 1; i < oddArray.Length; i++, odd += 2)
            {
                oddArray[i] = odd;
                Console.WriteLine(oddArray[i]);
            }
            Console.WriteLine(max);
            //#8: Print Integers Greater Than Y
            int[] array;
            array = new int[] {1,3,5,7,9,13};
            int y = 6;
            int count = 0;
            for(int i = 0; i < array.Length; i++) {
                if(array[i] > y) {
                    count ++;
                }
            }
            Console.WriteLine(count);
            // #9: Square Integers of Array
            int[] array;
            array = new int[] {1,3,5,7,9,13};
            for(int i = 0; i < array.Length; i++) {
                array[i] = array[i] * array[i];
                Console.WriteLine(array[i]);
            }
            #10: Eliminate Negative Numbers in Array
            int[] array;
            array = new int[] {1,-3,5,-7,9,-13};
            for(int i = 0; i < array.Length; i++) {
                if(array[i] < 0){
                    array[i] = 0;
                    Console.WriteLine(array[i]);
                }else{
                    Console.WriteLine(array[i]);
                }
            }
            // #11: Min, Max, Average of Array
            int[] array;
            array = new int[] {1,-3,5,-7,9,-13};
            int min = array[0];
            int max = array[0];
            int sum = 0;
            for(int i = 1; i < array.Length; i++) {
                if(min > array[i]) {
                    min = array[i];
                }
                if(max < array[i]) {
                    max = array[i];
                }
                sum = sum + i;
            }
            int avg = sum / array.Length;
            Console.WriteLine("Average: " + avg);
            Console.WriteLine("Min: " + min);
            Console.WriteLine("Max: " + max);
            //#12: Shifting Values in Array
            int[] array;
            array = new int[] {1,-3,5,-7,9,-13};
            for(int i = 0; i < array.Length; i++) {
                array[i] = array[i + 1];
                Console.WriteLine(array[i]);
            }
            //#13: Number To String 
            int[] array;
            array = new int[] {1,-3,5,-7,9,-13};
            for(int i = 0; i < array.Length; i++) {
                if(array[i] < 0){
                    string myString = array[i].ToString();
                    myString = "Dojo";
                    Console.WriteLine(myString);
                }else{
                    Console.WriteLine(array[i]);
                }
            }





            




            


        }
    }
}
