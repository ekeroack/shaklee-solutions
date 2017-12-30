using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ShakleeSolutions.Models
{
    public class Form
    {
        public Form()
        {
            this.Ailments = new HashSet<Ailment>();
        }

        public int Id { get; set; }
        public DateTime Date { get; set; }

        public int ClientId { get; set; }
        //public Client Client { get; set; }

        public ICollection<Ailment> Ailments { get; set; }
    }
}