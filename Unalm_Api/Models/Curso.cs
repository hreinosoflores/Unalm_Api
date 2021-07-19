using System;
using System.Collections.Generic;

#nullable disable

namespace Unalm_Api.Models
{
    public partial class Curso
    {
        public ulong Id { get; set; }
        public string Codigo { get; set; }
        public string Nombre { get; set; }
        public int Creditos { get; set; }
        public int HorasTeoria { get; set; }
        public int HorasPractica { get; set; }
        public string Sumilla { get; set; }
        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
    }
}
