// See https://aka.ms/new-console-template for more information
string[] animals = { "Cow", "Camel", "Elephant" };
// Create a List and add a collection
List<string> animalsList = new List<string>();
animalsList.AddRange(animals);
foreach (string a in animalsList)
    Console.WriteLine(a);




List<string> authors = new List<string>(5);
authors.Add("Mahesh Chand");
authors.Add("Chris Love");
authors.Add("Allen O'neill");
authors.Add("Naveen Sharma");
authors.Add("Monica Rathbun");
authors.Add("David McCarter");
int i = 0;
foreach (string a in authors) {
  
    i++;
    Console.WriteLine(i +": " +a); 
}
    Console.WriteLine("_______________________________");

authors.Insert(3, "Bill Author");
// Collection of new authors
string[] newAuthors = { "New Author1", "New Author2", "New Author3" };
// Insert array at position 2
authors.InsertRange(2, newAuthors);

foreach (string a in authors) { Console.WriteLine(a); }
    Console.WriteLine("______________________________");


authors.Remove("New Author1");

// Remove 3rd item
authors.RemoveAt(3);
authors.RemoveRange(3, 2);
foreach (string a in authors) { Console.WriteLine(a); }
Console.WriteLine("______________________________");

Console.WriteLine("Original List items");
Console.WriteLine("===============");
// Print original order
foreach (string a in authors)
    Console.WriteLine(a);
// Sort list items
authors.Sort();
Console.WriteLine();
Console.WriteLine("Sorted List items");
Console.WriteLine("===============");
// Print sorted items
foreach (string a in authors)
    Console.WriteLine(a);