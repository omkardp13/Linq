OrderBy() method in LINQ is used to sort a collection in ascending order based on a specified key. If you need to sort in descending order, you can use OrderByDescending()


var sortedCollection = collection.OrderBy(x => x.SomeProperty);  // Ascending order
var sortedCollection = collection.OrderByDescending(x => x.SomeProperty);  // Descending order

