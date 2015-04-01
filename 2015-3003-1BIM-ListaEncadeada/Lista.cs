using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace _2015_3003_1BIM_ListaEncadeada
{
    class Lista
    {
        private Elemento primeiro;
        public Elemento Primeiro
        {
            get
            {
                return primeiro;
            }
            set
            {
                primeiro = value;
            }
        }

        public Elemento Ultimo
        {
            get
            {
                return BuscaUltimo();
            }
        }

        public Lista()
        {
            
        }

        public void Adiciona(Elemento e)
        {
            if (Primeiro == null)
            {
                Primeiro = e;
            }
            else
            {
                Ultimo.Proximo = e;
            }
        }

        public Elemento BuscaUltimo()
        {
            Elemento current = Primeiro;
            while (current.Proximo != null)
            {
                current = current.Proximo;
            }
            return current;
        }

        public void Addnew(int pica)
        {
            int count = 1;
            Elemento current = Primeiro;
            while (count < pica-1)
            {
                current = current.Proximo;
                count++;
            }
            Elemento buxa = current.Proximo;
            current.Proximo = new Elemento(Count);
            current.Proximo.Proximo = buxa;

            

        }


        public int Count
        {
            get {
                int count = 1;
                Elemento current = Primeiro;
                while (current != null)
                {
                    current = current.Proximo;
                    count++;
                }
                return count;
            }
        }

        public void ImprimeLista()
        {
            Elemento current = Primeiro;
            while (current != null)
            {
                Debug.WriteLine(current.AsString);
                current = current.Proximo;
            } 
        }

        public string RetornaLista()
        {
            StringBuilder strg = new StringBuilder();

            Elemento current = Primeiro;
            while (current != null)
            {
                strg.Append(current.AsString).Append(" ");
                current = current.Proximo;
            }
            return strg.ToString();


        }
    }
}
