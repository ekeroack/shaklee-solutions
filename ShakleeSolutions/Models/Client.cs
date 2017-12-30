using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ShakleeSolutions.Models
{
    public class Client
    {
        public Client()
        {
            this.Forms = new HashSet<Form>();
        }

        public int Id { get; set; }
        [Display(Name="First Name")]
        public string FirstName { get; set; }
        [Display(Name = "Last Name")]
        public string LastName { get; set; }
        [DisplayFormat(DataFormatString = "{0:MM/dd/yyyy}", ApplyFormatInEditMode = true)]
        public DateTime? Birthday { get; set; }
        public GenderEnum Gender { get; set; }

        public ICollection<Form> Forms { get; set; }

        public string FullName()
        {
            return this.FirstName + " " + this.LastName;
        }
        public string Age()
        {
            var currentDate = DateTime.Now;

            if (this.Birthday != null)
            {
                var timespan = currentDate - this.Birthday;

                return ((int) (timespan.Value.TotalDays/365)).ToString();
            }

            return "";
        }

        public enum GenderEnum
        {
            Unspecified,
            Male,
            Female
        }
    }
}