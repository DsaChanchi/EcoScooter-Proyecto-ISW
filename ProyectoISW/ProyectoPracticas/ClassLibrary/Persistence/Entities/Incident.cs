using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace EcoScooter.Entities
{
    public partial class Incident
    {
        public string Description
        {
            get;
            set;
        }

        public int Id
        {
            get;
            set;
        }
        public DateTime TimeStamp
        {
            get;
            set;
        }
       

    }
}
