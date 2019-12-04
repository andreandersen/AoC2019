using AdventOfCode.Solutions.BuildingBlocks;
using System.Linq;

namespace AdventOfCode.Solutions.Days.Day03
{
    public partial class Day03 : IDay
    {
        public object First(string input) => 
            GetCircuitBoard(input).MinimumManhattanDistance;

        public object Second(string input) => 
            GetCircuitBoard(input).MinimumSteps;

        private CircuitBoard GetCircuitBoard(string input)
        {
            var (w1, w2) = ParseInput(input);
            return new CircuitBoard(w1, w2);
        }


        private (Wire, Wire) ParseInput(
            string input)
        {
            var wireInputs = input.Split('\n');

            var firstMovements = wireInputs[0].ParseMovements();
            var secondMovements = wireInputs[1].ParseMovements();

            var wire1 = new Wire(firstMovements);
            var wire2 = new Wire(secondMovements);

            return (wire1, wire2);
        }
    }

}
