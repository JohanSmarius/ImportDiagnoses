using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImportDiagnoses
{
    public class Diagnose
    {
        public int Id { get; set; }

        public int Code { get; set; }

        public string Lichaamsdeel { get; set; }

        public string Omschrijving { get; set; }


        public override string ToString()
        {
            return $"{Code} {Lichaamsdeel} {Omschrijving}";
        }
    }
}
