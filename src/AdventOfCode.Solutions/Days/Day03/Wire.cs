using System.Collections;
using System.Collections.Generic;

namespace AdventOfCode.Solutions.Days.Day03
{
    public class Wire : IReadOnlyList<Position>
    {
        private readonly List<Position> _positions;

        internal Wire(IEnumerable<Movement> movements)
        {
            var current = new Position(0, 0);
            _positions = new List<Position> { current };

            foreach (var move in movements)
            {
                for (int i = 0; i < move.Length; i++)
                {
                    current = current.Move(move.Direction);
                    _positions.Add(current);
                }
            }
        }

        public int IndexOf(Position pos) => _positions.IndexOf(pos);

        public Position this[int index] => _positions[0];
        public int Count => _positions.Count;
        public IEnumerator<Position> GetEnumerator() => _positions.GetEnumerator();
        IEnumerator IEnumerable.GetEnumerator() => _positions.GetEnumerator();
    }

}
