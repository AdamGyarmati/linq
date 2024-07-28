
using Linq;

using (var context = new MyDbContext())
{


}





List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
//List<int> evenNums = new List<int>();

//foreach (var num in numbers)
//{
//    if (num % 2 == 0)
//    {
//        evenNums.Add(num);
//    }
//}

//var evenNums = from num in numbers
//               where num % 2 == 0
//               select num;

var evenNums = numbers.Where(num => num % 2 == 0)
                      .OrderByDescending(num => num)
                      .ToList();

var doubleNums = numbers.Where(num => num % 2 == 0).Select(num => num * 2).ToList();

foreach (var num in doubleNums)
{
    Console.WriteLine(num);
}




