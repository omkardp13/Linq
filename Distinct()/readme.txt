Distinct() method in LINQ is used to remove duplicate elements from a collection, returning only distinct or unique elements. 
            It uses the default equality comparer to compare the elements (i.e., it compares elements based on their default equality, such as Equals() for simple types).

Syntax:
                                                                           
var result = collection.Distinct();
The Distinct() method returns a collection that contains only unique elements from the original collection.
Examples:
                                                                           
1. Remove Duplicates from a List of Integers:

List<int> numbers = new List<int> { 1, 2, 2, 3, 4, 4, 5 };

// Remove duplicates
var distinctNumbers = numbers.Distinct();

foreach (var number in distinctNumbers)
{
    Console.WriteLine(number);  // Output: 1, 2, 3, 4, 5
}
Here, the duplicate 2 and 4 are removed, and the resulting collection contains only distinct integers.

                                                                           
2. Remove Duplicates from a List of Strings:
csharp
Copy code
List<string> fruits = new List<string> { "apple", "banana", "apple", "orange", "banana" };

// Remove duplicates
var distinctFruits = fruits.Distinct();

foreach (var fruit in distinctFruits)
{
    Console.WriteLine(fruit);  // Output: apple, banana, orange
}
In this example, the repeated occurrences of "apple" and "banana" are removed.

                                                                           -------
  Distinct() with Custom Types:
                                                                           
When using Distinct() with custom types (e.g., classes), it works only if the custom type implements equality comparison (either by overriding Equals() and GetHashCode() or implementing IEqualityComparer<T>).

3. Using Distinct() with Custom Types:
Consider a class Person where we want to remove duplicates based on the Name property.

csharp
Copy code
class Person
{
    public string Name { get; set; }
    public int Age { get; set; }

    public override bool Equals(object obj)
    {
        if (obj is Person otherPerson)
        {
            return this.Name == otherPerson.Name;
        }
        return false;
    }

    public override int GetHashCode()
    {
        return this.Name.GetHashCode();
    }
}

List<Person> people = new List<Person>
{
    new Person { Name = "John", Age = 30 },
    new Person { Name = "John", Age = 25 },
    new Person { Name = "Jane", Age = 40 }
};

// Remove duplicates based on the Name property
var distinctPeople = people.Distinct();

foreach (var person in distinctPeople)
{
    Console.WriteLine($"{person.Name}, {person.Age}");
    // Output: John, 30
    //         Jane, 40
}
In this case, two Person objects with the name "John" are considered duplicates, even though their ages differ. The result retains only one instance of "John" based on the overridden Equals() method.

Distinct() with Custom Comparer:
If you want more control over how elements are compared (for example, when comparing a specific property), you can use the Distinct() method with an IEqualityComparer<T>.

4. Using a Custom Comparer:
csharp
Copy code
class PersonComparer : IEqualityComparer<Person>
{
    public bool Equals(Person x, Person y)
    {
        return x.Name == y.Name;
    }

    public int GetHashCode(Person obj)
    {
        return obj.Name.GetHashCode();
    }
}

List<Person> people = new List<Person>
{
    new Person { Name = "John", Age = 30 },
    new Person { Name = "John", Age = 25 },
    new Person { Name = "Jane", Age = 40 }
};

// Remove duplicates using a custom comparer
var distinctPeople = people.Distinct(new PersonComparer());

foreach (var person in distinctPeople)
{
    Console.WriteLine($"{person.Name}, {person.Age}");
    // Output: John, 30
    //         Jane, 40
}
Here, a custom comparer PersonComparer is used to ensure that Distinct() compares only by the Name property and not other properties like Age.
  
