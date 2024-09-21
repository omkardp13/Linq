1.Single():
  Returns the single element from the collection or the single element that matches a condition.
  Throws an InvalidOperationException if:
  No elements are found.
  More than one element matches the condition.
 
  Syntax:

  var singleElement = collection.Single();
  var singleMatchingElement = collection.Single(x => x.SomeCondition);
-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

2.SingleOrDefault():
  Returns the single element from the collection or the single element that matches a condition.
  Returns the default value (null for reference types or 0 for numeric types) if no element is found.
  Throws an InvalidOperationException if more than one element matches the condition.
  
    Syntax:
    var singleElement = collection.SingleOrDefault();
    var singleMatchingElement = collection.SingleOrDefault(x => x.SomeCondition);
