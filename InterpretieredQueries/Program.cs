//using System;
//using System.ComponentModel.DataAnnotations.Schema;
//using System.Data.Linq;
//using System.Data.Linq.Mapping;
//using System.Linq;

//[Table(Name = "Customers")]
//public class Customer
//{
//    [Column(IsPrimaryKey = true, IsDbGenerated = true)]
//    public int ID { get; set; }

//    [Column]
//    public string Name { get; set; }
//}

//class Test
//{
//    static void Main()
//    {
//        var dataContext = new DataContext(@"Server=(localdb)\MSSQLLocalDB;Database=MyDatabase;Trusted_Connection=True;");

//        Table<Customer> customers = dataContext.GetTable<Customer>();

//        IQueryable<string> query = from c in customers
//                                   where c.Name.Contains("a")
//                                   orderby c.Name.Length
//                                   select c.Name.ToUpper();

//        foreach (string name in query)
//        {
//            Console.WriteLine(name);
//        }
//    }
//}




//IQueryable<string> queryExample = customer
//    .Where(x => x.Name.Contains("a"))
//    .OrderBy(x => x.Name.Length)
//    .Select(x => x.Name.ToUpper());



//using System.Text.RegularExpressions;

//Regex wordCounter = new Regex(@"\Ь(\w | [-'])+\Ь");
//var query = dataContext.MedicalArticles
//.Where(article => article.Topic == "influenza")
//.AsEnumeraЬle()
//.Where(article =>
//wordCounter.Matches(article.AЬstract).Count
//, 100);