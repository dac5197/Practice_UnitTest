using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_UnitTest.ApplicationCore.Models
{
    public class DacmeTcgCardColor
    {
        [Key, Column(Order = 1)]
        public Guid DacmeTcgCardId { get; set; }
        public DacmeTcgCard DacmeTcgCard { get; set; }
        [Key, Column(Order = 2)]
        public Guid DacmeTcgColorId { get; set; }
        public DacmeTcgColor Color { get; set; }
    }
}
