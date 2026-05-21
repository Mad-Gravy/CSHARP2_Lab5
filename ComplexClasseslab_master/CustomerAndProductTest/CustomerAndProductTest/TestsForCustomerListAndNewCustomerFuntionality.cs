using System;
using CustomerProductClasses;

namespace CustomerProductTests
{
    class Program
    {
        //static void Main(string[] args)
        //{
        //    TestCustomerListConstructor();
        //    TestCustomerListAddMethods();
        //    TestCustomerListRemoveMethod();
        //    TestCustomerListIndexers();
        //    TestCustomerListOperators();
        //    TestCustomerListToString();

        //    Console.WriteLine("All tests complete.");
        //    Console.ReadLine();
        //}

        static void TestCustomerListConstructor()
        {
            CustomerList cl = new CustomerList();

            Console.WriteLine("Testing CustomerList Constructor");
            Console.WriteLine("Expecting count of 0: " + cl.Count);
            Console.WriteLine();
        }

        static void TestCustomerListAddMethods()
        {
            CustomerList cl = new CustomerList();

            Customer c1 = new Customer(
                1,
                "joe@email.com",
                "Joe",
                "Smith",
                "555-1234"
            );

            cl.Add(c1);

            Console.WriteLine("Testing Add(Customer)");
            Console.WriteLine("Expecting count of 1: " + cl.Count);

            cl.Add(
                2,
                "bob@email.com",
                "Bob",
                "Jones",
                "555-5678"
            );

            Console.WriteLine("Testing Add(id, email, firstName, lastName, phone)");
            Console.WriteLine("Expecting count of 2: " + cl.Count);

            Console.WriteLine();
        }

        static void TestCustomerListRemoveMethod()
        {
            CustomerList cl = new CustomerList();

            Customer c1 = new Customer(
                1,
                "joe@email.com",
                "Joe",
                "Smith",
                "555-1234"
            );

            cl.Add(c1);

            Console.WriteLine("Testing Remove(Customer)");
            Console.WriteLine("Count before remove (expecting 1): " + cl.Count);

            cl.Remove(c1);

            Console.WriteLine("Count after remove (expecting 0): " + cl.Count);
            Console.WriteLine();
        }

        static void TestCustomerListIndexers()
        {
            CustomerList cl = new CustomerList();

            Customer c1 = new Customer(
                1,
                "joe@email.com",
                "Joe",
                "Smith",
                "555-1234"
            );

            Customer c2 = new Customer(
                2,
                "bob@email.com",
                "Bob",
                "Jones",
                "555-5678"
            );

            cl.Add(c1);
            cl.Add(c2);

            Console.WriteLine("Testing int indexer");
            Console.WriteLine("Expecting Bob: " + cl[1].FirstName);

            Console.WriteLine();

            Console.WriteLine("Testing string indexer");
            Console.WriteLine("Expecting Joe: " + cl["joe@email.com"].FirstName);

            Console.WriteLine();

            Console.WriteLine("Testing int indexer set");
            cl[0] = c2;

            Console.WriteLine("Expecting Bob: " + cl[0].FirstName);

            Console.WriteLine();
        }

        static void TestCustomerListOperators()
        {
            CustomerList cl = new CustomerList();

            Customer c1 = new Customer(
                1,
                "joe@email.com",
                "Joe",
                "Smith",
                "555-1234"
            );

            Console.WriteLine("Testing + operator");

            cl = cl + c1;

            Console.WriteLine("Expecting count of 1: " + cl.Count);

            Console.WriteLine();

            Console.WriteLine("Testing - operator");

            cl = cl - c1;

            Console.WriteLine("Expecting count of 0: " + cl.Count);

            Console.WriteLine();
        }

        static void TestCustomerListToString()
        {
            CustomerList cl = new CustomerList();

            Customer c1 = new Customer(
                1,
                "joe@email.com",
                "Joe",
                "Smith",
                "555-1234"
            );

            cl.Add(c1);

            Console.WriteLine("Testing ToString()");
            Console.WriteLine("Expecting customer information:");
            Console.WriteLine(cl.ToString());

            Console.WriteLine();
        }
    }
}