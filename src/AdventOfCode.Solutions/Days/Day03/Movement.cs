using System;

namespace AdventOfCode.Solutions.Days.Day03
{
    internal readonly struct Movement
    {
        public Movement(char direction, short length)
        {
            Direction = direction switch
            {
                'R' => Direction.Right,
                'U' => Direction.Up,
                'D' => Direction.Down,
                'L' => Direction.Left,
                _ => throw new ArgumentException()
            };

            Length = length;
        }

        public readonly short Length;
        public readonly Direction Direction;
    }
}
