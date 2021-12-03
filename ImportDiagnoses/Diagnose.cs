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
        /// <summary>
        /// The normal Id is used as a primary key. Code can be used
        /// for this as well, but that would require an explicit
        /// call to the database to turn enable identity insert on before
        /// SaveChanges and off after SaveChanges.
        /// </summary>
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
