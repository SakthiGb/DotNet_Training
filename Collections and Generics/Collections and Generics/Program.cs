using System;
using System.Collections;
using System.Collections.Generic;

namespace Collections_and_Generics
{
    // C# includes specialized classes that store series of values or objects are called collections.

    // There are two types of collections available in C#: non-generic and generic

    //using package
    //1.Non-generic collections ------>System.Collections
    //2.generic collections ---------->System.Collections.Generic

    //Non-generic Collections       
    //ArrayList
    //SortedList
    //Stack
    //Queue
    //Hashtable

    //Generic Collections
    //List<T>
    //Dictionary<TKey,TValue>
    //SortedList<TKey, TValue>
    //Queue<T>
    //Stack<T>
    //Hashset<T>

    public class Program
    {
        public static void Main()
        {
            #region ArrayList
            //**********Non-Generic********//
            //**********ArrayList**********//
            // adding elements using ArrayList.Add() method
            Console.WriteLine("Non-Generic");
            Console.WriteLine("ArrayList");
            var arlist1 = new ArrayList();
            arlist1.Add(1);
            arlist1.Add("Bill");
            arlist1.Add(true);
            arlist1.Add(4.5);
            arlist1.Add(null);

            // adding elements using object initializer syntax
            var arlist2 = new ArrayList()
                    {
                        2, "Steve", true, 4.5, null
                    };

            //arlist1.AddRange(arlist2);
            // var firstElement = arlist[0];
            //Console.WriteLine(firstElement);
            //arlist2.Insert(1, "John");
            //arList.Remove(null); //Removes first occurance of null
            //arList.RemoveAt(4); //Removes element at index 4
            //arList.RemoveRange(0, 2);//Removes two elements starting from 1st item (0 index)
            //Console.WriteLine(arlist1.Contains("Bill")); // true

            Console.WriteLine("ArrayList 1 Elements");
            for (int i = 0; i < arlist1.Count; i++)
                Console.WriteLine(arlist1[i]);

            Console.WriteLine("ArrayList 2 Elements");
            foreach (var item in arlist2)
                Console.Write(item + ", ");
            Console.WriteLine();
            Console.WriteLine();
            #endregion

            Console.WriteLine("*********Generic and Non-Generic*********");
            Console.WriteLine("********SortedList***********");
            //Creating a SortedList of string keys, string values 
            //using collection-initializer syntax
            //A key must be unique and cannot be null.
            //A value can be null or duplicate.

            SortedList<int, string> numberNames = new SortedList<int, string>()
                                    {
                                        {4, "Four"},
                                        {3, "Three"},
                                        {2, "Two"},                                       
                                        {1, "One"}
                                    };
            SortedList<string,string> cities = new SortedList<string,string>()
                                    {
                                        {"d", "UK"},
                                        {"z", "India"},
                                        {"a", "USA"},
                                        {"t", "South Africa"}
                                    };

            //Console.WriteLine(numberNames[3]); //output: Three

            //Console.WriteLine(numberNames[10]); //run-time KeyNotFoundException

            //if (numberNames.ContainsKey(4))
            //{
            //    numberNames[4] = "null";
            //}

            //numberNames.Remove(2);//removes key 1 pair
            //numberNames.Remove(10);//removes key 1 pair, no error if not exists

            //numberNames.RemoveAt(6);//removes key-value pair from index 0 
            //numberNames.RemoveAt(10);//run-time exception: ArgumentOutOfRangeException

            foreach (KeyValuePair<int,string> citi in numberNames)
                Console.WriteLine("key: {0}, value: {1}", citi.Key, citi.Value);

            for (int i = 0; i < cities.Count; i++)
            {
                Console.WriteLine("key: {0}, value: {1}", cities.Keys[i], cities.Values[i]);
            }

            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("********Generic***********");
            Console.WriteLine("********List***********");
            //Elements can be added using the Add(), AddRange() methods or collection - initializer syntax.
            //Elements can be accessed by passing an index e.g. myList[0]. Indexes start from zero.
            //List<T> performs faster and less error-prone than the ArrayList

            var bigCities = new List<string>();
            bigCities.Add("New York");
            bigCities.Add("London");
            bigCities.Add("Mumbai");
            bigCities.Add("Chicago");
            bigCities.Add(null);

            //var bigCities = new List<string>()
            //    {
            //        "New York",
            //        "London",
            //        "Mumbai",
            //        "Chicago",
            //        null
            //    };

            //var student1 = new Student() { Id = 1, Name = "Bill" };
            //var student2 = new Student() { Id = 2, Name = "Ram" };
            //var student3 = new Student() { Id = 3, Name = "Abdul" };

            var students = new List<Student>() {
                new Student(){ Id = 1, Name="Bill"},
                new Student(){ Id = 2, Name="Steve"},
                new Student(){ Id = 3, Name="Ram"},
                new Student(){ Id = 4, Name="Abdul"}
            };

            //bigCities.Insert(1, "India");
            //bigCities.Remove(5); // removes the first 10 from a list
            //bigCities.RemoveAt(2); //removes the 3rd element (index starts from 0)
            //bigCities.Contains("Mumbai"); // returns true
            // using foreach LINQ method
            //students.ForEach(num => Console.WriteLine(num + ", "));//prints 1, 2, 5, 7, 8, 10,

            for (int i = 0; i < bigCities.Count; i++)
                Console.WriteLine(bigCities[i]);

            foreach (Student student in students)
            {
                Console.Write(student.Id + " ");
                Console.Write(student.Name + " ");
                Console.WriteLine();
            }

            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("********Generic***********");
            Console.WriteLine("********Dictionary***********");

            //Comes under System.Collections.Generic namespace.
            //Keys must be unique and cannot be null.
            //Values can be null or duplicate.
            //Values can be accessed by passing associated key in the indexer e.g. myDictionary[key]

            var valueKV = new Dictionary<int, string>();
            valueKV.Add(1, "One");
            valueKV.Add(2, "Two");
            valueKV.Add(3, "Three");

            var Cities = new Dictionary<string, string>()
            {
                {"UK", "London, Manchester, Birmingham"},
                {"USA", "Chicago, New York, Washington"},
                {"India", "Mumbai, New Delhi, Pune"},
            };

            //Cities["UK"] = "Liverpool, Bristol"; // update value of UK key
            //Cities.Remove("UK"); // removes UK 
            //cities.Remove("France"); //throws run-time exception: KeyNotFoundException

            //Console.WriteLine(Cities.ContainsKey("France")); returning boolean value

            //if (Cities.ContainsKey("France"))
            //{ 
            // check key before removing it
            //    Cities.Remove("France");
            //}

            //cities.Clear(); //removes all elements

            Cities.TryGetValue("India", out string resultIndia);
            Console.WriteLine($"India---> {resultIndia}");

            foreach (var kvp in Cities)
                Console.WriteLine("Key: {0}, Value: {1}", kvp.Key, kvp.Value);

            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("********Non-Generic***********");
            Console.WriteLine("********Hashtable***********");
            //Hashtable stores key - value pairs.
            //Comes under System.Collections namespace.
            //Implements IDictionary interface.
            //Keys must be unique and cannot be null.
            //Values can be null or duplicate.
            //Values can be accessed by passing associated key in the indexer e.g. myHashtable[key]

            //Hashtable<string,string> numberames = new  Hashtable<string, string>();
            //numberNames.Add("One", "One"); //adding a key/value using the Add() method
            //numberNames.Add("Two", "Two");
            //numberNames.Add("Three", "Three");

            var citis = new Hashtable(){
                {"UK", "London, Manchester, Birmingham"},
                {"USA", "Chicago, New York, Washington"},
                {"India", "Mumbai, New Delhi, Pune"}
            };

            foreach (DictionaryEntry de in citis)
                Console.WriteLine("Key: {0}, Value: {1}", de.Key, de.Value);

            //Add Dictionary in Hashtable
            Dictionary<int, string> dict = new Dictionary<int, string>();
            dict.Add(1, "one");
            dict.Add(2, "two");
            dict.Add(3, "three");

            Hashtable ht = new Hashtable(dict);

            foreach (DictionaryEntry de in ht)
                Console.WriteLine("Key: {0}, Value: {1}", de.Key, de.Value);

            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("********Generic and Non-Generic***********");
            Console.WriteLine("********Stack<T>***********");

            //LIFO style(Last In First Out)
            //Elements can be added using the Push() method
            //Elements can be retrieved using the Pop() and the Peek() methods.
            //It does not support an indexer

            Stack<int> myStack = new Stack<int>();
            myStack.Push(1);
            myStack.Push(2);
            myStack.Push(3);
            myStack.Push(4);

            //while (myStack.Count > 0)
            //    Console.Write(myStack.Pop() + ",");

            if (myStack.Count > 0)
            {
                Console.WriteLine(myStack.Peek()); // prints 4
            }
            Console.WriteLine($"Mystack count: {myStack.Count}");
            foreach (var item in myStack)
                Console.Write(item + ",");

            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("********Generic and Non-Generic***********");
            Console.WriteLine("********Queue<T>***********");

            //Queue<T> is FIFO (First In First Out) collection.
            //Elements can be added using the Enqueue() method
            //Elements can be retrieved using the Dequeue() and the Peek()

            Queue<int> callerIds = new Queue<int>();
            callerIds.Enqueue(1);
            callerIds.Enqueue(2);
            callerIds.Enqueue(3);
            callerIds.Enqueue(4);

            //if (callerIds.Count > 0)
            //{
            //    Console.WriteLine(callerIds.Peek()); //prints 1
            //}

            //callerIds.Contains(2);

            //while (strQ.Count > 0)
            //    Console.WriteLine(strQ.Dequeue()); //prints Hello

            //Console.WriteLine("Total elements: {0}", strQ.Count);

            foreach (var id in callerIds)
                Console.Write(id);


            Console.ReadLine();
        }

        class Student
        {
            public int Id { get; set; }
            public string Name { get; set; }
        }
    }
}
