using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcoScooter.Entities
{
    public partial class PlanningWork
    {
        public PlanningWork()
        { 

        }
        public PlanningWork(String description, int worktime, Maintenance maintenance, Scooter scooter) :this()
        {
            Description = description;
            WorkingTime = worktime;
            Maintenance = maintenance;
            Scooter = scooter;
        }
    }
}
