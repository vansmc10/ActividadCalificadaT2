using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ACTIVIDAD_CALIFICADA__T2
{
    public partial class Enunciado1 : Form
    {
        
        public Enunciado1()
        {
            InitializeComponent();

            //Random r = new Random();

            //for (int i = 0; i < 15; i++)
            //{
            //    Form1.list.Add(r.Next(100));
            //}

            actulizar();
        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            if(tbNumero.Text.Length > 0 && tbNumero.Text != "")
            {
                int numero = int.Parse(tbNumero.Text.ToString());
                if (!Form1.list.Contains(numero))
                {
                    Form1.list.Add(numero);
                    actulizar();
                }
                else
                {
                    MessageBox.Show("El elemento " + numero + " ya existe en la lista.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                 
                }
                

                //Form1.list.Add(numero);
               // actulizar();

                tbNumero.Clear();
                tbNumero.Focus();
            }
            else
            {
                MessageBox.Show("Debe ingresar un numero para insertar", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            

        }

        private void btnAscendente_Click(object sender, EventArgs e)
        {
            ordenBurbuja(Form1.list);
            actulizar();
        }



        private void btnDescendente_Click(object sender, EventArgs e)
        {
            QuickSortDescendente(Form1.list, 0, Form1.list.Count - 1);
            actulizar();
        }


        private void actulizar()
        {
            lbLista.Items.Clear();

            foreach (int number in Form1.list)
            {

                lbLista.Items.Add(number);
            }
        }


        public static void QuickSortDescendente(List<int> lista, int izquierda, int derecha)
        {
            if (izquierda < derecha)
            {
                int indicePivote = Particionar(lista, izquierda, derecha);
                QuickSortDescendente(lista, izquierda, indicePivote - 1);
                QuickSortDescendente(lista, indicePivote + 1, derecha);
            }
        }

        public static int Particionar(List<int> lista, int izquierda, int derecha)
        {
            int pivote = lista[derecha];
            int i = izquierda - 1;

            for (int j = izquierda; j < derecha; j++)
            {
                if (lista[j] > pivote) 
                {
                    i++;
                    Intercambiar(lista, i, j);
                }
            }
            Intercambiar(lista, i + 1, derecha);
            return i + 1;
        }
        public static void Intercambiar(List<int> lista, int i, int j)
        {
            int temp = lista[i];
            lista[i] = lista[j];
            lista[j] = temp;
        }
        private  void ordenBurbuja(List<int> lista)
        {
            int n = lista.Count;
            for (int i = 0; i < n - 1; i++)
            {
                for (int j = 0; j < n - i - 1; j++)
                {
                    if (lista[j] > lista[j + 1])
                    {
                        int temp = lista[j];
                        lista[j] = lista[j + 1];
                        lista[j + 1] = temp;
                    }
                }
            }
        }
        
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            float numero = int.Parse(tbBuscar.Text.ToString());
            Boolean encontrado = false;
            int cont = 0;
            foreach (int number in Form1.list)
            {
                cont++;
                if (numero == number)
                {

                    lbLista.SetSelected(cont - 1, true);
                    encontrado = true; break;

                }
            }

            if (encontrado)
            {
                MessageBox.Show("Número encontrado.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {
                MessageBox.Show("Número no encontrado.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            int numero = int.Parse(tbNumEliminar.Text.ToString());
            Boolean encontrado = false;
            foreach (int number in Form1.list)
            {
                
                if (numero == number)
                {
                    encontrado = true; break;
                }
            }

            if (encontrado)
            {
                MessageBox.Show("Número Eliminado.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);

                Form1.list.Remove(numero);
                actulizar();

            }
            else
            {
                MessageBox.Show("Número no encontrado.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void tbNumero_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                // Verifica si la tecla presionada no es un dígito ni una tecla de control (como Backspace)
                if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                {
                    // Si la tecla presionada no es válida, cancela el evento
                    e.Handled = true;
                    // Muestra un mensaje indicando que solo se permiten números
                    MessageBox.Show("Solo se permiten números.", "Entrada no válida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                // Maneja cualquier excepción aquí (aunque es raro que ocurra una excepción en este caso)
                MessageBox.Show($"Error: {ex.Message}", "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void tbBuscar_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                // Verifica si la tecla presionada no es un dígito ni una tecla de control (como Backspace)
                if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                {
                    // Si la tecla presionada no es válida, cancela el evento
                    e.Handled = true;
                    // Muestra un mensaje indicando que solo se permiten números
                    MessageBox.Show("Solo se permiten números.", "Entrada no válida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                // Maneja cualquier excepción aquí (aunque es raro que ocurra una excepción en este caso)
                MessageBox.Show($"Error: {ex.Message}", "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void tbNumEliminar_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                // Verifica si la tecla presionada no es un dígito ni una tecla de control (como Backspace)
                if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                {
                    // Si la tecla presionada no es válida, cancela el evento
                    e.Handled = true;
                    // Muestra un mensaje indicando que solo se permiten números
                    MessageBox.Show("Solo se permiten números.", "Entrada no válida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                // Maneja cualquier excepción aquí (aunque es raro que ocurra una excepción en este caso)
                MessageBox.Show($"Error: {ex.Message}", "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    } 
}
