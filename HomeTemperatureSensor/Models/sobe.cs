using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeTemperatureSensor.Models
{
    public class sobe
    {
        [Key]
        public int SobaID { get; set; }
        public string NazivSobe { get; set; }
    }
}
