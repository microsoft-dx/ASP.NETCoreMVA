using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVC.Models
{
    public class ProfileData
    {
        public string PictureUrl { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string FullName
        {
            get
            {
                return FirstName + LastName;
            }
            private set { }
        }
        public string Description { get; set; }
        public string Hobbies { get; set; }
    }
}
