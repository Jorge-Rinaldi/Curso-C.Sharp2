using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio1
{
    class Telefono
    {
        public Telefono(string Modelo, string Marca)
        {
            this.Modelo = Modelo;
            this.Marca = Marca;
        }

        private string Modelo;
        private string Marca;
        private string NumeroTelefonico;
        private int CodigoOperador;

        public string modelo { get; set; }
        public string marca { get; set; }

        public string NumTelefono { get; set; }

        public int CodOper
        {
            get { return CodigoOperador; }
            set
            {
                if (CodigoOperador == 1)
                    CodigoOperador = value;
                else
                {
                    value = 0;
                }
            }
        }
        public string Llamar()
        {
            return "Realizando llamada...";
        }

        public string Llamar(string Contacto)
        {
            return "Llamando a... " + Contacto;
        }
    }
}
