using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EcoScooter.Entities
{
    public partial class Maintenance
    {
      public string Descripcion
        {
            get;
            set;
        }
       public DateTime? EndDate
        {
            get;
            set;
        }

        public int Id
        {
            get;
            set;
        }
        public DateTime StartDate
        {
            get;
            set;
        }
        /*Relaciones*/
        [InverseProperty("Maintenances")]
        public virtual Employee Employee
        {
            get;
            set;
        }
        public virtual ICollection<PlanningWork> PlanningWork
        {
            get;
            set;
        }

    }
}
