using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_UnitTest.ApplicationCore.Models
{
    public class DacmeTcgCardMechanic
    {
        [Key]
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string RulesText { get; set; }
    }
}
