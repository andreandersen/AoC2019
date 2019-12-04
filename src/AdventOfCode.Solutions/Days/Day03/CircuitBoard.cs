
using System;
using System.Collections.Generic;
using System.Linq;

namespace AdventOfCode.Solutions.Days.Day03
{
    public partial class Day03
    {
        internal sealed class CircuitBoard
        {
            private static readonly Position s_ignoredPosition =
                new Position(0, 0);

            private readonly Wire _wire1;
            private readonly Wire _wire2;

            public CircuitBoard(Wire wire1, Wire wire2)
            {
                _wire1 = wire1;
                _wire2 = wire2;
            }

            public IEnumerable<Position> IntersectingPositions =>
                _wire1.Intersect(_wire2).Where(
                    p => !p.Equals(s_ignoredPosition));

            public int MinimumManhattanDistance =>
                IntersectingPositions.Select(
                    p => Math.Abs(p.X) + Math.Abs(p.Y)).Min();

            public int MinimumSteps =>
                IntersectingPositions.Aggregate(
                    int.MaxValue, (current, next) => 
                    {
                        var steps =
                            _wire1.IndexOf(next) +
                            _wire2.IndexOf(next);

                        return steps < current ? steps : current;
                    });
        }
    }

}
