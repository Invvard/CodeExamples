using System;

namespace InvvardDev.VariousExamples.Cloneable {
    internal class CloneableObject : ICloneable
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Position Position { get; set; }

        public CloneableObject()
        {
            Position = new Position(0, 0);
        }

        public object Clone()
        {
            var clone = MemberwiseClone();

            return clone;
        }

        public override string ToString()
        {
            return $"Object {Name} ({Id}) @ {Position.X};{Position.Y}";
        }
    }

    internal class Position
    {
        public int X { get; set; }
        public int Y { get; set; }

        public Position(int x, int y)
        {
            X = x;
            Y = y;
        }
    }
}