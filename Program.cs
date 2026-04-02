using System.Security.Cryptography.X509Certificates;

namespace G_NET_12_Adv03
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region Exercise 1

            //int[] Grades = [85, 92, 78, 95, 88, 70, 100, 65];
            //Console.WriteLine();
            //ConsoleHelper.PrintArray("Grades", Grades);
            //Console.WriteLine();

            //Console.WriteLine($"Count of Grades = {Grades.Count()}");
            //Console.WriteLine();

            //Console.WriteLine($"First Grade = {Grades.First()}");
            //Console.WriteLine();

            //Console.WriteLine($"Last Grade = {Grades.Last()}");
            //Console.WriteLine();

            //Grades.Sort();
            //ConsoleHelper.PrintArray("Grades After Sort", Grades);
            //Console.WriteLine();
            //Console.WriteLine($"First Grade Above 90 =  {Grades.FirstOrDefault(n => n > 90)}");
            //Console.WriteLine();

            //for (int i = 0; i < Grades.Length; i++)
            //{
            //    if (Grades[i] < 75)
            //    {
            //        Console.WriteLine($"Grades below 75 [failing Grades] =  {Grades[i]}");

            //    }
            //    ;

            //}
            //List<int> Grade = Grades.ToList();
            //Grade.RemoveAll(g => g < 75);
            //Console.WriteLine();

            //Console.WriteLine($"Grades Contain 100  = {Grade.Contains(100)}");
            //List<string> Result = new();
            //foreach (var i in Grade)
            //{  
            //    Result.Add("Grade :" + i);
            //}
            //ConsoleHelper.PrintList("Result", Result);

            #endregion

            #region Exercise 2
            ////Add: 500="Ahmed", 200="Sara", 800="Ali", 350="Mona"
            //SortedList<int, string> Playres = new()
            //{
            //    [500] = "Ahmed",
            //    [200] = "Sara",
            //    [300] = "Ali",
            //    [350] = "Mona",
            //};
            //Console.WriteLine();

            ////Print all entries (they should be sorted by score automatically)
            //foreach (var item in Playres)
            //{
            //    Console.WriteLine($"Players = {item}");
            //}

            ////Access the first key and first value 
            //Console.WriteLine($"First Key  = {Playres.First().Key} , First Value  = {Playres.First().Value}");


            ////Check if score 500 exists
            //Console.WriteLine($"if score 500 exists ? {Playres.ContainsKey(500)}");
            //Console.WriteLine();

            ////Safely get the player with score 999
            //Playres.ElementAtOrDefault( 999 );

            ////Remove the player with score 200 and print the updated list
            //Playres.Remove(200);
            //foreach (var item in Playres)
            //{
            //    Console.WriteLine($"Players = {item}");
            //}

            #endregion

            #region Exercise 3

            ////Create a Collection  with 4 contacts (name → phone number)
            ////Add a new contact using [] syntax (add or update)
            //Dictionary<string , int> PhoneBook = new(4)
            //{
            //    ["Alice"] = 1234567890,
            //    ["Bob"] = 987653210,
            //    ["Charlie"] = 555555555,
            //    ["Mai"] = 273462875,
            //};

            ////Try adding a duplicate using .Add() — catch the exception and print the error
            //try
            //{
            //    PhoneBook.Add("Alice", 1234567890);

            //}
            //catch (Exception e) 
            //{
            //    Console.WriteLine(e);
            //}

            ////Try adding a duplicate using .TryAdd() — print whether it succeeded
            //Console.WriteLine($"{PhoneBook.TryAdd("Alice", 1234567890)}"); // False

            ////Search for a contact that doesn’t exist
            //Console.WriteLine($"{PhoneBook.ContainsKey("David")}");

            ////Get a contact with a fallback of "Not Found"
            //PhoneBook.TryGetValue("David", out int number);
            //Console.WriteLine($"{number} => Not Found");

            ////Print all Keys on one line, then all Values on another line
            //foreach (var key in PhoneBook.Keys)
            //{
            //    Console.Write(key + ",");
            //}
            //Console.WriteLine();
            //foreach (var Value in PhoneBook.Values)
            //{
            //    Console.Write(Value + ",");
            //}



            #endregion

        }
    }
}
