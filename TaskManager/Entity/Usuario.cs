﻿

namespace Entity
{
    public class Usuario
    {
        public int UsuarioId { get; set; }
        public string Nombre { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public bool EsAdministrador { get; set; }
        public int SectorId { get; set; }
    }
}
