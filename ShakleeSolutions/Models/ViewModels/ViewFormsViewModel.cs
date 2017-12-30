using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ShakleeSolutions.Models.ViewModels
{
    public class ViewFormsViewModel
    {
        private ClientContext db = new ClientContext();

        public int ClientId { get; set; }
        public List<Form> Forms { get; set; }

        public ViewFormsViewModel(int clientId)
        {
            this.ClientId = clientId;
            this.Forms = CompletedForms(clientId);
        }

        public List<Form> CompletedForms(int clientId)
        {
            return db.Forms.Where(x=>x.ClientId == clientId).ToList();
        }

    }
}