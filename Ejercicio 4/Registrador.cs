using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ejercicio_4
{
    public class Registrador
    {
        private int idRegistrador;
        private string apellidoReg;
        private string nombreReg;

        public Registrador()
        {

        }

        public int IdRegistrador { get => idRegistrador; set => idRegistrador = value; }
        public string ApellidoReg { get => apellidoReg; set => apellidoReg = value; }
        public string NombreReg { get => nombreReg; set => nombreReg = value; }

        public void agregar()
        {
            throw new System.NotImplementedException();
        }

        public void buscar()
        {
            throw new System.NotImplementedException();
        }
    }
}