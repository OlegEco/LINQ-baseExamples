string[] musos = { "Rick Wright", "David Gilour", "Roger Waters" };
IEnumerable<string> query = musos.OrderBy(m => m.Split().Last());
foreach (string s in query)
    Console.WriteLine(s);

Console.WriteLine();
string[] names = { "Tom", "Dick", "Jay", "Mary", "Harry" };
IEnumerable<string> outerQuery = names
    .Where(n => n.Length == names.OrderBy(n2 => n2.Length)
    .Select(n2 => n2.Length).First());
foreach (string s in outerQuery)
    Console.WriteLine(s);

Console.WriteLine();
IEnumerable<string> comprehension =
    from n in names
    where n.Length ==
    (from n2 in names
     orderby n2.Length
     select n2.Length).First()
    select n;
foreach (string s in comprehension)
    Console.WriteLine(s);

Console.WriteLine();
IEnumerable<string> quer =
    from n in names
    where n.Length == names.Min(n2 => n2.Length)
    select n;
foreach (string item in quer)
    Console.WriteLine(item);

Console.WriteLine();
int shortest = names.Min(n => n.Length);
IEnumerable<string> qur =
    from n in names
    where n.Length == shortest
    select n;
foreach (string s in qur)
    Console.WriteLine(s);