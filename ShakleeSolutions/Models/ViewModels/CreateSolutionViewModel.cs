using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ShakleeSolutions.Models.ViewModels
{
    public class CreateSolutionViewModel
    {
        private ClientContext db = new ClientContext();

        public int Id { get; set; }
        public string Desc { get; set; }
        public List<int> SelectedAilmentIds { get; set; }
        
        public CreateSolutionViewModel()
        {
            
        }

        public CreateSolutionViewModel(Solution solution)
        {
            this.Id = solution.Id;
            this.Desc = solution.Desc;
            this.SelectedAilmentIds = solution.Ailments.Select(x => x.Id).ToList();
        }

        public List<Ailment> Ailments()
        {
            return db.Ailments.ToList();
        }

        public Dictionary<int, string> AvailableAilments()
        {
            return db.Ailments.ToDictionary(x => x.Id, x => x.Desc);
        }
    }
}