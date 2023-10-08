using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ejercicio_4
{
    public class Pasajero
    {
        private int idPasajero;
        private string nombre;
        private string apellido;

        public Registrador Registrador
        {
            get => default;
            set
            {
            }
        }

        public Pasajero()
        {

        }

        public int IdPasajero { get => idPasajero; set => idPasajero = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellido { get => apellido; set => apellido = value; }

        

        public void agregar()
        {
            throw new System.NotImplementedException();
        }

        public void modificar()
        {
            throw new System.NotImplementedException();
        }

        public void buscar()
        {
            throw new System.NotImplementedException();
        }
    }
}