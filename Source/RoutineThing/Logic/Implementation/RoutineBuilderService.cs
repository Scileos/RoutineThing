using System.Collections.Generic;
using Routine.Common.Models;
using Routine.Logic.Contracts;

namespace Routine.Logic.Implementation
{
    public class RoutineBuilderService : IRoutineBuilder
    {
        public IEnumerable<Exercise> GetRoutine(long userId)
        {
            //TODO: Implement data access layer
            return new List<Exercise>();
        }
    }
}