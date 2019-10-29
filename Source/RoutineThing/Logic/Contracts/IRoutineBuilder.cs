using System.Collections;
using System.Collections.Generic;
using Routine.Common.Models;

namespace Routine.Logic.Contracts
{
    public interface IRoutineBuilder
    {
        IEnumerable<Exercise> GetRoutine(long userId);
    }
}