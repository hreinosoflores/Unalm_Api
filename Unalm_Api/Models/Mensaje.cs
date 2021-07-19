using System;
using System.Collections.Generic;

#nullable disable

namespace Unalm_Api.Models
{
    public partial class Mensaje
    {
        public ulong Id { get; set; }
        public string Nombres { get; set; }
        public string Apellidos { get; set; }
        public string Email { get; set; }
        public string Telefono { get; set; }
        public string Comentarios { get; set; }
        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
    }
}
