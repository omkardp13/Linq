The ElementAt() method in LINQ is used to retrieve an element at a specific index from a collection. It works on collections that implement IEnumerable<T> and allows you to access an element by its zero-based index. If the index is out of bounds, ElementAt() will throw an exception.

Syntax:

var element = collection.ElementAt(index);
