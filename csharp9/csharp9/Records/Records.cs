using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp9.Records
{
    public abstract record Food (int Calories);
    public record Milk(int C, double FatPercentage) : Food(C);
    public record Chicken { public string Name { get; init; } }
    //public record Chicken(string name);

    public class ClassType
    {
    }

    public interface IRecord { }

    public record RecordType : IRecord { }


    // method constrains sur record?
}
