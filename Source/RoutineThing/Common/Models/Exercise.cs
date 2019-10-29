namespace Routine.Common.Models
{
    public class Exercise
    {
        public string Name { get; set; }
        public double Weight { get; set; }
        public int NumberOfSets { get; set; }
        public int RepRangeLowerBound { get; set; }
        public int RepRangeUpperBound { get; set; }
    }
}