using System;
using System.Collections.Generic;
using System.Linq;



class Program
{
    static void Main()
    {

        /* Count Vowels & Consonants */

        string input = "Hello World";
        char[] vowels = { 'a', 'e', 'i', 'o', 'u', 'A', 'E', 'I', 'O', 'U' };

        int vowelsCount=input.Count(x=>vowels.Contains(x));

        int consonants=input.Count(c => Char.IsLetter(c) && !vowels.Contains(c));

        Console.WriteLine("Vowels Count: "+vowelsCount);
        Console.WriteLine("Conconants Count: "+consonants);

        /*-----------   Reverse String  --------------*/
        string orignial = "Hello World";
        string reversed = new string(orignial.Reverse().ToArray());
        Console.WriteLine(reversed);

        /* Find Second Largest  */

        int[] arr = { 23, 51, 23, 12, 44, 56 };

        int result=arr.OrderByDescending(x => x).Skip(1).Take(1).FirstOrDefault();
         Console.WriteLine(result);

        //Find the sixth highest element unsorted array
        int[] arrr = { 233, 51, 23, 12, 44, 56 ,34,12};
        //56,51,44,34,23,23,12
        var sixthHighestElement = arrr.OrderByDescending(x => x).Distinct().Skip(5).FirstOrDefault();
        int index = Array.IndexOf(arrr, sixthHighestElement);
       Console.WriteLine(index);

        //Check all charactos in str1 are present in str2 
        string str1 = "ABCD";
        string str2 = "DCBA";

        bool ContainsAll = str1.All(c => str2.Contains(c));

        //Find duplicate numbers in list

        List<int> numbers = new List<int> { 1, 2, 3, 4, 2, 3, 4, 5, 6, 3, 7 };

        var duplicates=numbers.GroupBy(x=>x).Where(g=>g.Count() > 1).Select(g=>g.Key);
        foreach(int i in duplicates)
        {
            Console.WriteLine($"{i}");
        }

        //number of occurences
        List<int> numberss = new List<int> { 1, 2, 3, 4, 5, 6, 8, 2, 3, 4, 5, 6, 9 };

        var numberOfOccurences = numberss.GroupBy(x => x).Select(g => new { number = g.Key, Count = g.Count() });

        foreach(var i in numberOfOccurences)
        {
            Console.WriteLine(i.number +" "+i.Count);
        }

        //Find unique charactors in string

        string input2 = "Hello World";
        
        var uniqueChars=input2.GroupBy(c=>c)
                               .Where(g=>g.Count()==1)
                               .Select(g=>g.Key);

        Console.WriteLine("Unique Chars"+string.Join(",",uniqueChars));
        Console.ReadKey();

    }
}