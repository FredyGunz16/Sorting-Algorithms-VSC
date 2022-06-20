using System;

namespace Sorting_Algorithms_VSC
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] items = {1,2,3,4,5,6,7,8,9,10};
            LinearSearch(items,6);
        }    
        static bool LinearSearch(int[] items,int target)
        {

        
            for(int i = 0; i < items.Length; i++)
            {
                if (target == items[i])
                {
                    Console.WriteLine("found it");
                    return true;
                }

                
            }
            return false;
        
        }

    }
}
