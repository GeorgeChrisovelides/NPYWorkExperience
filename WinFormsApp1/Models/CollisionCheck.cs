using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1.Models
{
    public class CollisionCheck
    {
        [Key]
        public int CollisionId { get; set; }


        public int Meteor1X { get; set; }
        public int Meteor1Y { get; set; }
        public int Meteor2X { get; set; }
        public int Meteor2Y { get; set; }

        public bool Checked { get; set; }

        public DateTime WhenCreated { get; set; }    
    }
}


