1.Last():
Returns the last element in a collection or the last element that matches a condition.
Throws an exception if the collection is empty or no element satisfies the condition.

Syntax:

var lastElement = collection.Last();
var lastMatchingElement = collection.Last(x => x.SomeCondition);
-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
2.LastOrDefault():
Returns the last element in a collection or the last element that matches a condition.
Returns the default value (null for reference types or 0 for numeric types) if the collection is empty or no element satisfies the condition.
Syntax:

var lastElement = collection.LastOrDefault();
var lastMatchingElement = collection.LastOrDefault(x => x.SomeCondition);
