string[] names = { "Tom", "Jack", "Max", "Harry", "Mary", "Jay", "Dick", "Oster" };
IEnumerable<string> query =
    from n in names // filtered elements
    where n.Contains("a") //sorted elements
    orderby n.Length
    select n.ToUpper();
foreach (string name in query)
    Console.Write(name + " | ");

Console.WriteLine();
IEnumerable<string> query2 = names
    .Where(n => n.Contains("a"))
    .OrderBy(n => n.Length)
    .Select(n => n.ToUpper());
foreach (string name in query2)
    Console.Write(name + " | ");

int count = (from name in names
             where name.Contains("a")
             select name).Count();
Console.WriteLine("Count: " + count);

Console.WriteLine();
var numbers = new List<int>();
numbers.Add(1);
IEnumerable<int> queery = numbers.Select(n => n * 10);
numbers.Add(2);
foreach (int n in queery)
    Console.Write(n + " | ");
int matches = numbers.Where(n => n < 2).Count();
Console.WriteLine("Matches: " + matches);

Console.WriteLine();
var nummbers = new List<int>() { 1, 2 };
IEnumerable<int> quuery = nummbers.Select(n => n * 20);
foreach (int n in quuery)
    Console.Write(n + " | ");
nummbers.Clear();
foreach (var item in nummbers)
    Console.Write(item + " [] ");


Console.WriteLine();
var nuummbers = new List<int>() { 1, 2 };
List<int> timesTen = nuummbers
    .Select(n => n * 30)
    .ToList();
nuummbers.Clear();
Console.WriteLine("Elements in List after clear " + timesTen.Count);

Console.WriteLine();
int[] numb = { 1, 2 };
int factor = 22;
var querys = numb.Select(n => n * factor);
foreach (int n in querys)
    Console.Write(n + " | ");

Console.WriteLine();
IEnumerable<char> stringChar = "Not what you might expect";
foreach (char vowel in "aeiou")
{
    char temp = vowel;
    stringChar = stringChar.Where(c => c != temp);
}
Console.WriteLine((stringChar).ToArray());

Console.WriteLine();
IEnumerable<int> qery = new int[] { 5, 12, 3 }
.Where(n => n < 10)
.OrderBy(n => n)
.Select(n => n * 100);
foreach (var item in qery)
    Console.Write(item + " [] ");

Console.WriteLine();
IEnumerable<int>
    source = new int[] { 4, 12, 2 },
    filtered = source.Where(n => n < 10),
    sorted = filtered.OrderBy(n => n),
    qyri = sorted.Select(n => n * 1000);
foreach (int n in qyri)
    Console.Write(n + " / ");

