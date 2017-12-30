using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ShakleeSolutions.Models
{
    public class Ailment
    {
        public Ailment()
        {
            this.Solutions = new HashSet<Solution>();
            this.Forms = new HashSet<Form>();
        }

        public int Id { get; set; }
        public string Desc { get; set; }

        public ICollection<Solution> Solutions { get; set; }
        public ICollection<Form> Forms { get; set; }

        public List<string> SelectedSolutions()
        {
            if (this.Solutions == null || !this.Solutions.Any())
            {
                return new List<string>();
            }

            return this.Solutions.Select(x => x.Desc).ToList();
        }
    }
}