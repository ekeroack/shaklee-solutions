using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ShakleeSolutions.Models.ViewModels
{
    public class SolutionViewModel
    {
        public Solution Solution { get; set; }
        public int AilmentCount { get; set; }

        public SolutionViewModel(Solution solution)
        {
            this.Solution = solution;
            this.AilmentCount = solution.Ailments.Count;
        }
    }
}