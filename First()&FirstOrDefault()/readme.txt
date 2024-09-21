1.First():
  Returns the first element in a collection or the first element that matches a condition.
  Throws an exception if the collection is empty or no element satisfies the condition.
  Syntax:
  var firstElement = collection.First();
  var firstMatchingElement = collection.First(x => x.SomeCondition);
---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
2.FirstOrDefault():
Returns the first element in a collection or the first element that matches a condition.
Returns the default value (null for reference types or 0 for numeric types) if the collection is empty or no element satisfies the condition.
Syntax:

var firstElement = collection.FirstOrDefault();
var firstMatchingElement = collection.FirstOrDefault(x => x.SomeCondition);
