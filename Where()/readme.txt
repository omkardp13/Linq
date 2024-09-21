Where()  used to filter a collection based on a specified condition or predicate. It returns all the elements from the collection that satisfy the given condition.

Syntax:

var filteredCollection = collection.Where(x => x.SomeCondition);
The method accepts a predicate (a delegate or lambda expression that returns true or false).
It returns a new collection of elements that match the condition.
Where() does not execute the query immediately; it uses deferred execution, meaning the filtering happens only when the collection is enumerated.
