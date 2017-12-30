using System.Collections.Generic;
using System.Linq;

namespace ShakleeSolutions.Models.ViewModels
{
    public class CreateAilmentViewModel
    {
        private ClientContext db = new ClientContext();

        public int Id { get; set; }
        public string Desc { get; set; }
        public List<int> SelectedSolutionIds { get; set; }
        
        public CreateAilmentViewModel()
        {
            
        }

        public CreateAilmentViewModel(Ailment ailment)
        {
            this.Id = ailment.Id;
            this.Desc = ailment.Desc;
            this.SelectedSolutionIds = ailment.Solutions.Select(x => x.Id).ToList();
        }

        public List<Solution> Solutions()
        {
            return db.Solutions.ToList();
        }

        public Dictionary<int, string> AvailableSolutions()
        {
            return db.Solutions.ToDictionary(x => x.Id, x => x.Desc);
        }
    }
}