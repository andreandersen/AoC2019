using System.Linq;

namespace AdventOfCode.Solutions.Days.Day03
{
    internal static class ExtensionMethods
    {
        internal static Movement[] ParseMovements(this string input) => input
                .Split(',')
                .Select(e =>
                {
                    var dir = e[0];
                    var len = short.Parse(e[1..]);
                    return new Movement(dir, len);
                })
                .ToArray();
    }


}
