1. OfType<T>() method used to filter elements of a collection based on their type. It returns only the elements of the specified type T from a sequence, ignoring elements of any other type. This is particularly useful in scenarios where you are working with collections of objects of different types (e.g., collections of object or non-generic collections).

Syntax:

var result = collection.OfType<T>();
T is the type of element you want to filter from the collection.
Example:
1. Filtering Elements of a Specific Type:
Consider a list containing various types of data, and you only want to retrieve elements of a specific type, such as integers.


List<object> mixedList = new List<object> { 1, "apple", 2, "banana", 3.5, true, 3 };

// Get only the integer values from the list
var integers = mixedList.OfType<int>();

foreach (var number in integers)
{
    Console.WriteLine(number);  // Output: 1, 2, 3
}
In this example, OfType<int>() filters the list and returns only the elements of type int, ignoring other types like string, double, or bool.

------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

2. Working with Non-Generic Collections:
OfType<T>() is particularly useful for filtering non-generic collections, such as ArrayList.

ArrayList arrayList = new ArrayList { 1, "apple", 2.5, DateTime.Now, 42 };

// Get only the integer values from the ArrayList
var integers = arrayList.OfType<int>();

foreach (var number in integers)
{
    Console.WriteLine(number);  // Output: 1, 42
}
