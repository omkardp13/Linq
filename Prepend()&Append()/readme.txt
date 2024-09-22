n LINQ, Prepend() and Append() are extension methods . These methods are used to add an element to the beginning or the end of a sequence, respectively, without modifying the original collection. They return a new sequence with the added element.

1.Append():
Adds a single element to the end of the sequence.
Prepend():
Adds a single element to the beginning of the sequence.
These methods are non-destructive, meaning they do not alter the original collection but instead return a new sequence.

1. Append() Example:
Adds an element to the end of a sequence.


List<int> numbers = new List<int> { 1, 2, 3 };

// Add 4 to the end
var updatedNumbers = numbers.Append(4);

foreach (var number in updatedNumbers)
{
    Console.WriteLine(number);  // Output: 1, 2, 3, 4
}
Here, the number 4 is appended to the end of the numbers list, resulting in a new sequence [1, 2, 3, 4].

------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
2. Prepend() Example:
Adds an element to the beginning of a sequence.


List<int> numbers = new List<int> { 1, 2, 3 };

// Add 0 to the beginning
var updatedNumbers = numbers.Prepend(0);

foreach (var number in updatedNumbers)
{
    Console.WriteLine(number);  // Output: 0, 1, 2, 3
}
In this case, the number 0 is prepended to the beginning of the list, resulting in a new sequence [0, 1, 2, 3].

