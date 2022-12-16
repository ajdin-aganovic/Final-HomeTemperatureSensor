using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace HomeTemperatureSensor.Models
{
    public class podaci
    {
        [Key]
        public int RedniBrojID { get; set; }
        public float TemperaturaCelzijusa { get; set; }
        public float TemperaturaFarenhajta { get; set; }
        public int SobaID { get; set; }
        [ForeignKey("SobaID")]
        public sobe soba { get; set; }
        public DateTime Vrijeme { get; set; }
        public string StatusAlarma { get; set; }

    }
}
