1. Concat() and Union() both combine two sequences into a single sequence, but they do so in different ways. 
     
1. Concat():
   Concatenates two sequences by simply combining them end-to-end without removing any duplicates. It appends the second sequence to the first one.
   Does not perform any checks for uniqueness.

  Syntax:

  var result = sequence1.Concat(sequence2);
  
  Example:
  List<int> list1 = new List<int> { 1, 2, 3 };
  List<int> list2 = new List<int> { 3, 4, 5 };

var result = list1.Concat(list2);

foreach (var item in result)
{
    Console.WriteLine(item);  // Output: 1, 2, 3, 3, 4, 5
}
In this example:

The two lists are concatenated, and the result includes all elements, including the duplicate 3.
Key Points about Concat():
No Deduplication: It does not remove duplicates.
Order Matters: Elements from the first sequence are followed by elements from the second sequence in the resulting sequence.
Deferred Execution: Like many LINQ methods, Concat() uses deferred execution, so the actual concatenation occurs when the sequence is iterated (e.g., via foreach or ToList()).

--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------=----
2. Union():

Combines two sequences and returns only distinct elements (i.e., no duplicates).
Uses the default equality comparer for types (or a custom comparer, if provided) to ensure that duplicates are removed.
                                              
Syntax:

var result = sequence1.Union(sequence2);
Example:

List<int> list1 = new List<int> { 1, 2, 3 };
List<int> list2 = new List<int> { 3, 4, 5 };

var result = list1.Union(list2);

foreach (var item in result)
{
    Console.WriteLine(item);  // Output: 1, 2, 3, 4, 5
}
In this example:

The duplicate 3 is removed, and the result contains only distinct elements.
