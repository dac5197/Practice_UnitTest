using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_UnitTest.ApplicationCore.Models
{
    public class DacmeTcgCard
    {
        [Key]
        public Guid Id { get; set; }

        public string Name { get; set; }
        public int CastingCostValue { get; set; }
        public string Color { get; set; }
        public string Type { get; set; }



    }
}
