using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ShakleeSolutions.Models.ViewModels
{
    public class AddFormViewModel
    {
        private ClientContext db = new ClientContext();

        public int Id { get; set; }
        public int ClientId { get; set; }
        public DateTime Date { get; set; }
        public List<int> SelectedAilmentIds { get; set; }

        public AddFormViewModel()
        {
            
        }
        public AddFormViewModel(int clientId)
        {
            this.ClientId = clientId;
            this.Date = DateTime.Now;
        }
        public AddFormViewModel(Form form)
        {
            this.ClientId = form.ClientId;
            this.Date = form.Date;
            this.SelectedAilmentIds = form.Ailments.Select(x => x.Id).ToList();
        }

        public List<Ailment> Ailments()
        {
            return db.Ailments.OrderBy(x=>x.Desc).ToList();
        }
    }
}