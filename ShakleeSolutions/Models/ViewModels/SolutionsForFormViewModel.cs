using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ShakleeSolutions.Models.ViewModels
{
    public class SolutionsForFormViewModel
    {
        private ClientContext db = new ClientContext();
        public List<SolutionToDisplay> SolutionsToDisplay { get; set; }

        public SolutionsForFormViewModel(Form form)
        {
            this.SolutionsToDisplay = new List<SolutionToDisplay>();
            
            foreach (var ailment in form.Ailments)
            {
                //var solutionsForAilment = ailment.Solutions.Select(x => x).ToList();
                var solutionsForAilment = db.Ailments.Include("Solutions").Where(x => x.Id == ailment.Id).Select(x => x.Solutions.ToList()).ToList()[0].ToList();

                foreach (var solution in solutionsForAilment)
                {
                    var solutionToDisplay = this.SolutionsToDisplay.SingleOrDefault(x => x.Id == solution.Id);

                    if (solutionToDisplay != null)
                    {
                        solutionToDisplay.Count++;
                    }
                    else
                    {
                        this.SolutionsToDisplay.Add(new SolutionToDisplay()
                        {
                            Id = solution.Id,
                            Name = solution.Desc,
                            Count = 1
                        });
                    }
                }
            }

            if (this.SolutionsToDisplay.Any())
            {
                this.SolutionsToDisplay = this.SolutionsToDisplay.OrderByDescending(x => x.Count).ToList();
            }
        }

        public class SolutionToDisplay
        {
            public int Id { get; set; }
            public string Name { get; set; }
            public int Count { get; set; }
        }
    }
}