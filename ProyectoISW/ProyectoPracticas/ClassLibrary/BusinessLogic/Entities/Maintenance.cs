using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcoScooter.Entities
{
    public partial class Maintenance
    {

        public Maintenance()
        {
            PlanningWork = new List<PlanningWork>();
        }
        public Maintenance(String descripcion, DateTime? endDate, DateTime startDate, Employee employee) : this()
        {
            Descripcion = descripcion;
            EndDate = endDate;
            StartDate = startDate;
            Employee = employee;
        }


    }
}
