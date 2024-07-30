using ProjectionStrategies;
using System.Text.RegularExpressions;

string[] names = { "Tom", "Dick", "Harry", "Mary", "Jay" };

IEnumerable<TempProjectionItem> temp =
    from n in names
    select new TempProjectionItem
    {
        Original = n,
        Vowelless = Regex.Replace(n, "[aouei]", "")
    };
IEnumerable<string> query =
    from item in temp
    where item.Vowelless.Length > 2
    select item.Original;
foreach (string n in query)
    Console.Write(n + " | ");


//Anonim types
Console.WriteLine("\n\n\n");
var intermediate = from n in names
                   select new
                   {
                       Originall = n,
                       Vowellesss = Regex.Replace(n, "[aouei]", "")
                   };
IEnumerable<string> query2 = from item in intermediate
                             where item.Vowellesss.Length > 2
                             select item.Originall;
foreach (string n in query2)
    Console.Write(n + " | ");


//var
Console.WriteLine("\n\n");
var query3 =
    from n in names
    select new
    {
        Original = n,
        Vowellesss = Regex.Replace(n, "[aouei]", "")
    }
    into n
    where n.Vowellesss.Length > 2
    select n.Original;
foreach (var n in query3)
    Console.Write(n + " | ");


//let
Console.WriteLine("\n\nlet");
IEnumerable<string> query4 =
    from item in names
    let vowelles = Regex.Replace(item, "[aouei]", "")
    where vowelles.Length > 2
    orderby vowelles
    select item;
foreach (var n in query4)
    Console.Write(n + " + ");