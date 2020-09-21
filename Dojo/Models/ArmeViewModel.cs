using BO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Dojo.Models
{
    public class ArmeViewModel
    {
        public Arme Arme { get; set; }
        public int Id { get; set; }
        public string Nom { get; set; }
        public int Degats { get; set; }
    }
}