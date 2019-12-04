using System;

namespace AdventOfCode.Solutions.Days.Day03
{
    public readonly struct Position : IEquatable<Position>
    {
        public Position(int x, int y)
        {
            X = x;
            Y = y;
        }

        public readonly int X;
        public readonly int Y;

        public Position Move(Direction dir) =>
            dir switch
            {
                Direction.Right => new Position(X+1, Y),
                Direction.Down => new Position(X, Y+1),
                Direction.Left => new Position(X-1, Y),
                Direction.Up => new Position(X, Y-1),
                _ => throw new Exception("Eh...")
            };

        public override bool Equals(object obj) => obj is Position position && Equals(position);
        public bool Equals(Position other) => X == other.X && Y == other.Y;
        public override int GetHashCode() => HashCode.Combine(X, Y);

        public static bool operator ==(Position left, Position right) => left.Equals(right);
        public static bool operator !=(Position left, Position right) => !(left == right);
    }
}
