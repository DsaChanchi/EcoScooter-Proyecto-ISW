using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace EcoScooter.Entities
{
    public partial class Person
    {
       
        public DateTime Birthdate
        {
            get;
            set;
        }

        [Key]
        public string Dni
        {
            get;
            set;
        }
        public string Name
        {
            get;
            set;
        }
        public string Email
        {
            get;
            set;
        }
        public int Telephon
        {
            get;
            set;
        }
    }
}
