n LINQ, the Sum() method is used to compute the sum of numeric values in a collection. It can be applied directly to a collection of numbers or used with a selector to sum values from properties of objects.

Syntax:

var totalSum = collection.Sum();
var totalSum = collection.Sum(x => x.SomeNumericProperty);
