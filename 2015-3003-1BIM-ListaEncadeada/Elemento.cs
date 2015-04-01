using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2015_3003_1BIM_ListaEncadeada
{
    class Elemento
    {
        #region Propriedades
        private int valor;
        private Elemento proximo;
        private Elemento anterior;
        #endregion

        #region Construtores
        public Elemento(int v)
        {
            Valor = v;
            Proximo = null;
            Anterior = null;
        }

        public Elemento(int v, Elemento p = null)
        {
            Valor = v;
            Proximo = p;
            Anterior = null;
        }

        public Elemento(int v, Elemento p = null, Elemento a = null) 
        {
            Valor = v;
            Proximo = p;
            Anterior = a;
        }
        #endregion

        #region Get/Set
        public int Valor
        {
            get
            {
                return valor;
            }
            set
            {
                valor = value;
            }
        }

        public Elemento Proximo
        {
            get
            {
                return proximo;
            }
            set
            {
                proximo = value;
            }
        }

        public Elemento Anterior
        {
            get
            {
                return anterior;
            }
            set
            {
                anterior = value;
            }
        }
        #endregion

        #region Utilitários
        public String AsString
        {
            get {
                return "Valor: " + valor.ToString();
            }
        }
        #endregion
    }

}
