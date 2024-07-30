string[] names = { "Tom", "Jack", "Harry", "Jameson", "Lyudovig", "Mary", "Lucy", "Jay" };

IEnumerable<string> filteredNames = Enumerable.Where(names, n => n.Length > 4);
//or short
IEnumerable<string> filteredNames2 = names.Where(n => n.Length > 4); // or 2 rows
//or moreshort 
var filteredNames3 = names.Where(n => n.Length > 4);
foreach (string name in filteredNames)
    Console.WriteLine(name); Console.WriteLine();
foreach (string name in filteredNames2)
    Console.WriteLine(name); Console.WriteLine();
foreach (string name in filteredNames3)
    Console.WriteLine(name); Console.WriteLine();

//var 2
IEnumerable<string> filtederName =
    from n in names
    where n.Contains("a")
    select n;
Console.WriteLine("Contains 'a':");
foreach (string name in filtederName)
    Console.WriteLine(name); Console.WriteLine();

//uppercase
Console.WriteLine("ToUpper:");
IEnumerable<string> filteredNam = names
    .Where(n => n.Contains("a"))
    .OrderBy(n => n.Length)
    .Select(n => n.ToUpper());
foreach (var item in filteredNam)
{
    Console.Write(item + " | ");
}

Console.WriteLine("\n\n Filtered, Sorted, FinalQuery");
var filtered = names.Where(n => n.Contains("a"));
var sorted = filtered.OrderBy(n => n.Length);
var finalQuery = sorted.Select(n => n.ToUpper());

foreach (var item in filtered)
    Console.Write(item + " | "); Console.WriteLine();
foreach (var item in sorted)
    Console.Write(item + " | "); Console.WriteLine();
foreach (var item in finalQuery)
    Console.Write(item + " | "); Console.WriteLine();


//LyambdaFunc
Console.WriteLine("\n\nLength from names:  \"Tom\", \"Jack\", \"Harry\", \"Jameson\", \"Lyudovig\", \"Mary\", \"Lucy\", \"Jay\" ");
IEnumerable<int> query = names.Select(n => n.Length);
foreach (var length in query)
    Console.Write(length + " ");

//a few operators
int[] number = { 10, 9, 8, 7, 6 };
int firstNumber = number.First();
int lastNumber = number.Last();
int secondNumber = number.ElementAt(1);
Console.WriteLine("\r\n\nfirstNumber " + firstNumber);
Console.WriteLine("lastNumber " + lastNumber);
Console.WriteLine("secondNumber " + secondNumber);

int count = number.Count();
int min = number.Min();
Console.WriteLine("count " + count);
Console.WriteLine("min " + min);

bool hasTheNumberNine = number.Contains(9);
bool hasMoreThanZeroElements = number.Any();
bool hasAnOddElement = number.Any(n => n % 2 == 0);
Console.WriteLine("hasTheNumberNine " + hasTheNumberNine);
Console.WriteLine("hasMoreThanZeroElemtns " + hasMoreThanZeroElements);
Console.WriteLine("hasAnOddElement " + hasAnOddElement);