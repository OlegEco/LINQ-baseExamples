using System.Collections.Generic;
using System.Text.RegularExpressions;

string[] names = { "Tom", "Jack", "Max", "Harry", "Mary", "Jay", "Dick", "Oster" };
IEnumerable<string> query1 = names
    .Select(n => Regex.Replace(n, "[aeiou]", ""))
    .Where(n => n.Length > 2)
    .OrderBy(n => n);
foreach (string name in query1)
    Console.Write(name + " / ");

Console.WriteLine("\nDiference between UP&DOWN syntax");
IEnumerable<string> query12 =
    from n in names
    where n.Length > 2
    orderby n
    select Regex.Replace(n, "[aeiou]", "");
foreach (string name in query12)
    Console.Write(name + " / ");

Console.WriteLine("\nCompleted upper result");
IEnumerable<string> query13 =
    from n in names
    select Regex.Replace(n, "[auoei]", "");
query13 = from n in query13
          where n.Length > 2
          orderby n
          select n;
foreach (var item in query13)
    Console.Write(item + " / ");

Console.WriteLine("\n\n\ninto:");
IEnumerable<string> query2 =
    from n in names
    select Regex.Replace(n, "[aouei]", "")
    into noVovel
    where noVovel.Length > 2
    orderby noVovel
    select noVovel;
foreach (var item in query2)
    Console.Write(item + " | ");

//var tempQuery = tempQueryExpr
//var finalQuery = from ... in tempQuery
////rewrite :
//var finalQuery = from in ( tempQueryExpr)


Console.WriteLine("\n\n\n");
IEnumerable<string> query3 =
    from n in names
    select Regex.Replace(n, "[aouei]", "");
query3 = from n in query3
         where n.Length > 2
         orderby n
         select n;
foreach (var item in query3)
    Console.Write($"{item} | ");

Console.WriteLine("\nWith a shell:");
IEnumerable<string> query31 =
    from n1 in
        (
            from n2 in names
            select Regex.Replace(n2, "[aeiou]", "")
        )
    where n1.Length > 2
    orderby n1
    select n1;

foreach (var item in query31)
    Console.Write($"{item} | ");
