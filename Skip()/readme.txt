1.Skip() method used to bypass a specified number of elements in a collection and return the remaining elements. 
       It is often used in combination with Take() for scenarios like pagination, where you want to skip a certain number of elements and then take a specified number from the remainder.

Syntax:
var result = collection.Skip(n);
n is the number of elements you want to skip.
It returns a new collection that excludes the first n elements from the source collection.

-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

2. SkipWhile():
This method skips elements from the collection as long as the specified condition is true. As soon as the condition is false, it stops skipping and returns the remaining elements.

Syntax:

var result = collection.SkipWhile(x => condition);
Example:

List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

// Skip elements while they are less than 5
var skippedWhile = numbers.SkipWhile(n => n < 5);
