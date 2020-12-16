using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClientesForm
{
    class claseCliente
    {
        int codigo;
        string nombre;
        int TipoDoc;
        int documento;
        DateTime fechaNac;
        bool sexo;
        bool EsCasado;

        public claseCliente()
        {
            codigo = 0;
            nombre = "";
            TipoDoc = 0;
            documento = 0;
            fechaNac = DateTime.Today;
            sexo = false;
            EsCasado = false;
        }

        public claseCliente(int cod, string nom, int TipoDo, int doc, DateTime fechaN, bool sex, bool EsC)
        {
            this.codigo = cod;
            this.nombre = nom;
            this.TipoDoc = TipoDo;
            this.documento = doc;
            this.fechaNac = fechaN;
            this.sexo = sex;
            this.EsCasado = EsC;

        }
        public int pCodigo
        {
            set { codigo = value; }
            get { return codigo; }
        }
        public string pNombre
        {
            set { nombre = value; }
            get { return nombre; }
        }
        public int pTipoDoc
        {
            set { TipoDoc = value; }
            get { return TipoDoc; }
        }
        public int pdocumento
        {
            set { documento = value; }
            get { return documento; }
        }
        public DateTime pFechaNac
        {
            set { fechaNac = value; }
            get { return fechaNac; }
        }
        public bool pSexo
        {
            set { sexo = value; }
            get { return sexo; }
        }
        public bool pEsCasado
        {
            set { EsCasado = value; }
            get { return EsCasado; }
        }

        public string toStringSexo()
         {
           string sex;
           if (sexo == true)
           sex = "Masculino";
           else
           sex = "Femenino";
           return sex;
          }
        public string toStringTipoDoc()
         {
            string TipoDocum;
            switch(TipoDoc)
            {
                case 1: TipoDocum = "LC"; break;
                case 2: TipoDocum = "LE"; break;
                case 3: TipoDocum = "DNI"; break;
                default: TipoDocum = "Desconocido"; break;
            }
            return TipoDocum;
         }

        public string toStringEsCasado()
        {
            string EsCasadoo;
        
            if(EsCasado)
            EsCasadoo="Casado";
            else
            EsCasadoo="Soltero";
             return EsCasadoo;
         }

            public string toString()
            {
                string mensaje;
                mensaje = "Codigo" + codigo.ToString()
                    + "/nNombre" + nombre.ToString()
                    + toStringTipoDoc() + ":" + TipoDoc.ToString()
                    + "n/Fecha Nacimiento:" + "  " + fechaNac.ToShortDateString()
                    + "n/Sexo:" + toStringSexo()
                    + "/nEstado Civil:" + toStringEsCasado();
                return mensaje;
                 
            }
    //para hacer un mayor tengo que crear metedo en esta clase para calcular edad//
        public int calcularEdad()
            {// tome el año de hoy y restelo a la fecha de nacimiento//
                return DateTime.Today.Year - fechaNac.Year;
            }

           
        }
    }
 
