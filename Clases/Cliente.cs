using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factura.Clases
{
    public class Cliente
    {
        public Cliente(string Cedula, string Nombres, string Direccion, string Telefono, string Email)
        {
            this.Cedula = Cedula;
            this.Nombres = Nombres;
            this.Direccion = Direccion;
            this.Telefono = Telefono;
            this.Email = Email;
        }

        public string Cedula { get; set; }
        public string Nombres { get; set; }
        public string Direccion { get; set; }
        public string Telefono { get; set; }
        public string Email { get; set; }

    }
}
