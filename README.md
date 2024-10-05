1.Filter out employees whose salary is greater than 5000 and sort them by name.

var result = employees.Where(emp => emp.Salary > 5000)
                      .OrderBy(emp => emp.Name);

-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

2.Select the names of all products that belong to a specific category.

var result = products.Where(prod => prod.Category == "SpecificCategory")
                     .Select(prod => prod.Name);

-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

3.Group customers by city and count how many customers are in each city.

var result = customers.GroupBy(cust => cust.City)
                      .Select(group => new 
                      { 
                          City = group.Key, 
                          CustomerCount = group.Count() 
                      });

-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
4.Perform an inner join between orders and customers based on customer ID.

var result = orders.Join(customers, 
                         order => order.CustomerID, 
                         customer => customer.CustomerID, 
                         (order, customer) => new 
                         {
                             OrderID = order.OrderID, 
                             CustomerName = customer.Name, 
                             OrderDate = order.OrderDate
                         });

-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

5.Find the maximum price of products in each category.


var result = products.GroupBy(prod => prod.Category)
                     .Select(group => new 
                     { 
                         Category = group.Key, 
                         MaxPrice = group.Max(prod => prod.Price) 
                     });

-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
6.Select distinct employee names from the list of employees.


var result = employees.Select(emp => emp.Name)
                      .Distinct();

-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
7.Get the total number of orders for each product in the orders list.

var result = orders.GroupBy(order => order.ProductID)
                   .Select(group => new 
                   { 
                       ProductID = group.Key, 
                       TotalOrders = group.Count() 
                   });

-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
8.Select the top 5 highest-paid employees from the employee list.

var result = employees.OrderByDescending(emp => emp.Salary)
                      .Take(5);

-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
9.Check if any employee in the list has a salary less than 3000.

bool hasLowSalary = employees.Any(emp => emp.Salary < 3000);
-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

10.Skip the first 2 pages of results (10 per page) and take the next page of employees.

var result = employees.Skip(20) // Skip the first 20 employees (2 pages of 10)
                      .Take(10); // Take the next 10 employees

-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
11.Calculate the average age of all employees.

var averageAge = employees.Average(emp => emp.Age);

-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
12.Find the second most expensive product in the product list.


var result = products.OrderByDescending(prod => prod.Price)
                     .Skip(1) // Skip the most expensive
                     .Take(1) // Take the next one (second most expensive)
                     .FirstOrDefault();

-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
13.Filter out all orders placed in the last 30 days.

var result = orders.Where(order => order.OrderDate >= DateTime.Now.AddDays(-30));

-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
14.Select only the employee IDs and corresponding names from the employee list.


var result = employees.Select(emp => new 
{ 
    EmployeeID = emp.ID, 
    Name = emp.Name 
});

-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
15.Group orders by customer and calculate the total amount spent by each customer.


var result = orders.GroupBy(order => order.CustomerID)
                   .Select(group => new 
                   { 
                       CustomerID = group.Key, 
                       TotalSpent = group.Sum(order => order.Amount) 
                   });

-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

16.Count how many distinct products have been ordered by each customer.


var result = orders.GroupBy(order => order.CustomerID)
                   .Select(group => new 
                   { 
                       CustomerID = group.Key, 
                       DistinctProductCount = group.Select(order => order.ProductID).Distinct().Count() 
                   });

-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
17.Find the first 5 employees whose names start with the letter 'J'.

var result = employees.Where(emp => emp.Name.StartsWith("J"))
                      .Take(5);

-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
18.Order employees by department and within each department, sort them by salary.

var result = employees.OrderBy(emp => emp.Department)
                      .ThenBy(emp => emp.Salary);

-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
19.Find the employee with the longest tenure in the company.


var result = employees.OrderBy(emp => emp.StartDate)
                      .FirstOrDefault(); // Assuming StartDate indicates tenure

-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
20.Check if all products in a given category have a price greater than a specific amount.

bool allProductsExpensive = products.Where(prod => prod.Category == "SpecificCategory")
                                     .All(prod => prod.Price > 100);
