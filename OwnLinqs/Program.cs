
using OwnLinqs.Linqs;

var list = new List<int> { 1, 2, 34134, 42341, 32123 };

var enumerable = list.MyWhere(i => i >1 );

foreach (var each in enumerable)
{
    Console.WriteLine("ლუკა" + each);
}

