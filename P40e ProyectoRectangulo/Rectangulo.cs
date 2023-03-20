using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P40e_ProyectoRectangulo
{
    class Rectangulo
    {
        //Campos
        string nombre;
        int ladoBase, ladoLateral;

        //Constructores
        public Rectangulo(string nombre, int ladoBase, int ladoLateral)
        {
            this.nombre = nombre;
            this.ladoBase = ladoBase;
            this.ladoLateral = ladoLateral;
        }

        //Propiedades de campos
        public string Nombre { get => nombre; set => nombre = value; }
        public int LadoBase { get => ladoBase; set => ladoBase = value; }
        public int LadoLateral { get => ladoLateral; set => ladoLateral = value; }

        //Propiedades
        public int Perimetro => ladoBase + ladoBase + ladoLateral + ladoLateral;
       
        public int Area => ladoBase * ladoLateral;

        //Métodos
        public string RectanguloAString() => String.Format("\t{0}\t{1}\t{2}\t\t{3}\t{4}",nombre,ladoBase,ladoLateral,Perimetro,Area);




    }
}
