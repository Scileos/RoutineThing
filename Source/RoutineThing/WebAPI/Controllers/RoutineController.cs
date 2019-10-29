using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Collections.Generic;
using Routine.Common.Models;
using Routine.Logic.Contracts;
using Routine.Logic.Implementation;

namespace RoutineWebAPI.Controllers
{
    [ApiController]
    [Route("Routine")]
    public class RoutineController : ControllerBase
    {
        private readonly ILogger<RoutineController> _logger;
        private readonly IRoutineBuilder _routineBuilderService;

        public RoutineController(ILogger<RoutineController> logger, IRoutineBuilder routineBuilderService)
        {
            //TODO: Ninject?
            _logger = logger;
            _routineBuilderService = routineBuilderService;
        }

        [HttpPost]
        public void Save()
        {
            //TODO: Implement routine saving
        }


        [HttpGet]
        public IEnumerable<Exercise> Get(long userId)
        {
            return _routineBuilderService.GetRoutine(userId);
        }


    }
}
