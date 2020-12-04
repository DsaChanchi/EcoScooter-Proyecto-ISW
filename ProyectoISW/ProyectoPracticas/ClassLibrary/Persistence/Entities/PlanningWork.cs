using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace EcoScooter.Entities
{
    public partial class PlanningWork
    {
        public int Id
        {
            get;
            set;
        }
        public string Description
        {
            get;
            set;
        }
        public int WorkingTime
        {
            get;
            set;
        }
        /*Relaciones*/
       public virtual Scooter Scooter
        {
            get;
            set;
        }
        public virtual Maintenance Maintenance
        {
            get;
            set;
        }
    }
}
