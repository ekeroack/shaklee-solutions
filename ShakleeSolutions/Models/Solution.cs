using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ShakleeSolutions.Models
{
    public class Solution
    {
        public Solution()
        {
            this.Ailments = new HashSet<Ailment>();
        }
        public int Id { get; set; }
        public string Desc { get; set; }

        public ICollection<Ailment> Ailments { get; set; }

        public List<string> SelectedAilments()
        {
            if (this.Ailments == null || !this.Ailments.Any())
            {
                return new List<string>();
            }

            return this.Ailments.Select(x => x.Desc).ToList();
        }
    }
}