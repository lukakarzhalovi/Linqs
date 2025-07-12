
using OwnLinqs.Linqs;

var list = new List<int> { 1, 2, 34134, 42341, 32123 };

var whereEnumerable = list.MyWhere(i => i >1 );
var selectEnumerable = list.OwnSelect(i => i * 2);

foreach (var each in whereEnumerable)
{
    Console.WriteLine(each);
}

foreach (var each in selectEnumerable)
{
    Console.WriteLine(each);
}

var rangeEnumerable = OwnRange.Range(1, 10);

foreach (var each in rangeEnumerable)
{
    Console.WriteLine(each);

}