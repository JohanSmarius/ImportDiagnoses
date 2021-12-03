using System;
using System.Collections.Generic;
using System.IO;

namespace ImportDiagnoses
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const string fileName = "Vektis lijst diagnoses gecorrigeerd.csv";
            var diagnoses = new List<Diagnose>();

            var lines = File.ReadAllLines(fileName);

            foreach (var line in lines)
            {
                var parts = line.Split(',');

                // The first line is a header and does not contain a parseable code. For easy of use the check is made for all lines.
                if (int.TryParse(parts[0], out int code))
                { 
                    var diagnose = new Diagnose() { Code = code, Lichaamsdeel = parts[1], Omschrijving = parts[2] };

                    diagnoses.Add(diagnose);
                }
            }

            foreach (var diagnose in diagnoses)
            { 
                Console.WriteLine(diagnose);
            }

            using var context = new DiagnoseContext();

            context.Diagnoses.AddRange(diagnoses);

            context.SaveChanges();

        }
    }
}
