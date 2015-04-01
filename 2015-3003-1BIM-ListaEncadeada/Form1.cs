using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.Threading;

namespace _2015_3003_1BIM_ListaEncadeada
{
    public partial class Form1 : Form
    {
        private Lista lista;
        private List<Elemento> arr = new List<Elemento>();
        bool foi = false;
        Random r = new Random();

        public Form1()
        {
            InitializeComponent();
        }

        private void CarregarPrograma(object sender, EventArgs e)
        {

            lista = new Lista();
        }

        private void InicializarLista(object sender, EventArgs e)
        {
            if (foi == false)
            {
                Elemento elemento = new Elemento(lista.Count);
                lista.Adiciona(elemento);
                foi = true;
                richTextBox1.Text = lista.RetornaLista();
            }
            else
            {
                label1.Text = "você já iniciou a lista";
            }
            
        }

        private void Sort(object sender, EventArgs e)
        {

            Stopwatch stope = new Stopwatch();
            stope.Start();

            BubbleSort(arr);

            stope.Stop();

            arr = new List<Elemento>();

            StringBuilder stgb = new StringBuilder();
             foreach(Elemento elemento in arr)
            {
               stgb.Append("Valor: ").Append(elemento.Valor).Append(" ");
            }

             richTextBox1.Text = stgb.ToString();
             Console.WriteLine(stope.Elapsed.TotalSeconds);
             chart1.Series["Series1"].Points.AddXY(lista.Count, stope.Elapsed.TotalSeconds);
        }

        private void AdicionaElemento(object sender, EventArgs e)
        {
            Elemento elemento = new Elemento(r.Next(1, 100));
            lista.Adiciona(elemento);
            arr.Add(elemento);
            
           // label1.Text = "Número adicionado com sucesso";
            richTextBox1.Text = lista.RetornaLista();

        }

        private void ExibirLista(object sender, EventArgs e)
        {
            lista.ImprimeLista();
            richTextBox1.Text = lista.RetornaLista();
        }


        private void button4_Click(object sender, EventArgs e)
        {
            if (int.Parse(textBox1.Text) > lista.Count)
            {
              //  label1.Text = "Você está tentando enfiar um elemento onde não existem elementos";
            }
            else
            {
                lista.Addnew(int.Parse(textBox1.Text));
                richTextBox1.Text = lista.RetornaLista();
               // label1.Text = "Número adicionado com sucesso";
            }
            
        }

        static void BubbleSort(List<Elemento> array) 
        {
            for (int i = 0; i < array.Count - 1; i++)
            {
                for (int j = i + 1; j < array.Count   ; j++)
                {
                    if (array[i].Valor > array[j].Valor)
                    {
                        Elemento temp = array[i];
                        array[i] = array[j];
                        array[j] = temp;
                    }
                }
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Graficuzin(Int16.Parse(textBox3.Text));

        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            lista.Primeiro = null;
            if (textBox2.Text.Equals("") == false)
            {
                
                for (Int32 i = 0; i <= Int16.Parse(textBox2.Text); i++)
                {
                   
                    Elemento elemento = new Elemento(r.Next(1, 100));
                    lista.Adiciona(elemento);
                    arr.Add(elemento);
                }
            }

            richTextBox1.Text = lista.RetornaLista();
        }

        private void Graficuzin(int numero)
        {
            chart1.Series["Series1"].Points.Clear();
            for(int i = 0; i <= numero; i++)
            {
                lista.Primeiro = null;
                for (Int32 j = 0; j < (i+1)*5; j++)
                {

                    Elemento elemento = new Elemento(r.Next(1, 100));
                    lista.Adiciona(elemento);
                    arr.Add(elemento);
                }

                Stopwatch stope = new Stopwatch();
                stope.Start();

                BubbleSort(arr);

                stope.Stop();


                chart1.Series["Series1"].Points.AddXY((i + 1) * 5, stope.Elapsed.TotalSeconds);



            }
        }
    }
}
