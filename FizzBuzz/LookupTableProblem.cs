using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FizzBuzz
{
    //public static class LookupTableProblem
    //{
    //    public static void Solution()
    //    {
    //        string[] testStrings = {"cat", "house", "bacon", "salad"};
    //        LookupItem[] testItems =
    //        {
    //            new LookupItem {ID = 1, Name = "salad"},
    //            new LookupItem {ID = 2, Name = "bacon"},
    //            new LookupItem {ID = 3, Name = "cat"},
    //            new LookupItem {ID = 4, Name = "house"}
    //        };
    //        //var sameStrings = testStrings.Intersect(testItems.Select((ti => ti.Name)));
    //        //testItems.Where(ti => testStrings.Contains(ti.Name))
    //        var iterateThroughThis = testStrings.Select(ts => testItems.First(ti => ti.Name == ts));
    //    }
    //}

    //public class LookupItem
    //{
    //    public int ID { get; set; }
    //    public string Name { get; set; }
    //}

    //// http://brendan.enrick.com/post/linq-your-collections-with-iequalitycomparer-and-lambda-expressions.aspx
    //public class LambdaComparer<T> : IEqualityComparer<T>
    //{
    //    private readonly Func<T, T, bool> _lambdaComparer;
    //    private readonly Func<T, int> _lambdaHash;

    //    public LambdaComparer(Func<T, T, bool> lambdaComparer) :
    //        this(lambdaComparer, o => 0)
    //    {
    //    }

    //    public LambdaComparer(Func<T, T, bool> lambdaComparer, Func<T, int> lambdaHash)
    //    {
    //        if (lambdaComparer == null)
    //            throw new ArgumentNullException("lambdaComparer");
    //        if (lambdaHash == null)
    //            throw new ArgumentNullException("lambdaHash");

    //        _lambdaComparer = lambdaComparer;
    //        _lambdaHash = lambdaHash;
    //    }

    //    public bool Equals(T x, T y)
    //    {
    //        return _lambdaComparer(x, y);
    //    }

    //    public int GetHashCode(T obj)
    //    {
    //        return _lambdaHash(obj);
    //    }
    //}
}
