using System;
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
    public partial class Enunciado2 : Form
    {
        public Enunciado2()
        {
            InitializeComponent();
            // actualizarMascota();
            //actulizarDueño();
            cargarComboDuenio();
            cargarMascota();
        }
        private void tabControl1_Click(object sender, EventArgs e)
        {
            // actualizarMascota();
            //actulizarDueño();
            cargarComboDuenio();
            cargarMascota();
        }

        #region Dueño
        private void btnRegistro_Click(object sender, EventArgs e)
        {
            if (verificacionDatosDueño())
            {
                string t_nombre = tbNombre.Text;
                string t_direccion = tbDireccion.Text;
                string t_telefono = tbTelefono.Text;

                Dueño t_dueño = new Dueño(t_nombre, t_direccion, t_telefono);

                Form1.listDueño.Add(t_dueño);
                actulizarDueño();

                MessageBox.Show("Dueño creado exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                limpiarDueño();

                
            }
            
            
        }
        private void actulizarDueño()
        {
            lvLista.Items.Clear();
            foreach (Dueño t_dueño in Form1.listDueño)
            {
                ListViewItem t_item = new ListViewItem(t_dueño.T_Nombre);
                t_item.SubItems.Add(t_dueño.T_Direccion);
                t_item.SubItems.Add(t_dueño.T_Telefono);
                lvLista.Items.Add(t_item);
            }


        }
        private void limpiarDueño()
        {
            tbNombre.Clear();
            tbDireccion.Clear();
            tbTelefono.Clear();
            tbNombre.Focus();
        }

        #endregion


        #region Mascota

        private void btnRegistroMascota_Click(object sender, EventArgs e)
        {

           if(verificarDatosMascota())
            {
                string t_nombre = tbNombreMascota.Text;
                int t_edad = int.Parse(tbEdad.Text);
                string t_raza = tbRaza.Text;

                

                Mascota mascota = new Mascota(t_nombre, t_edad, t_raza, buscarDueño());

                //agregarListView a nuestra lista mascotas
                Form1.listMascota.Add(mascota);

                //agregamos al listview por metodo
                this.agregarListView(mascota);

                //actualizarMascota();
                cbDueño.SelectedIndex = -1;
                limpiarMascota();

                // Aquí puedes proceder a hacer lo que necesites con el objeto mascota
                MessageBox.Show("Mascota Registrada exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            
        }
        private void cargarComboDuenio()
        {
            cbDueño.Items.Clear();
            foreach (Dueño dueño in Form1.listDueño)
            {
                cbDueño.Items.Add(dueño.T_Nombre);
            }
        }
        private void cargarMascota()
        {
            lvListaMascota.Items.Clear();
            foreach (Mascota mascota in Form1.listMascota)
            {
                ListViewItem item = new ListViewItem(mascota.T_Nombre);
                item.SubItems.Add(mascota.T_Edad.ToString());
                item.SubItems.Add(mascota.T_Raza);
                item.SubItems.Add(mascota.T_Dueño.T_Nombre);
                lvListaMascota.Items.Add(item);
            }
        }
        private void agregarListView(Mascota mascota)
        {
            ListViewItem item = new ListViewItem(mascota.T_Nombre);
            item.SubItems.Add(mascota.T_Edad.ToString());
            item.SubItems.Add(mascota.T_Raza);
            item.SubItems.Add(mascota.T_Dueño.T_Nombre);
            lvListaMascota.Items.Add(item);
        }
       

        private Dueño buscarDueño()
        {
            string t_nombre = cbDueño.Text;

            Dueño t_dueño = new Dueño();

            foreach (Dueño du in Form1.listDueño)
            {
                if (du.T_Nombre.Equals(t_nombre))
                {
                    t_dueño = du;
                }
            }

            return t_dueño;
        }

        private void limpiarMascota()
        {
            tbNombreMascota.Clear();
            tbEdad.Clear();
            tbRaza.Clear();
            tbNombreMascota.Focus();
        }
        #endregion

        #region Verificaciones
        private Boolean verificacionDatosDueño()
        {


            if (string.IsNullOrWhiteSpace(tbNombre.Text))
            {
                MessageBox.Show("El nombre no puede estar vacío.", "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (string.IsNullOrWhiteSpace(tbDireccion.Text))
            {
                MessageBox.Show("La dirección no puede estar vacía.", "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (string.IsNullOrWhiteSpace(tbTelefono.Text))
            {
                MessageBox.Show("El teléfono no puede estar vacío.", "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }
        private Boolean verificarDatosMascota()
        {

            // Verificar que ninguno de los campos esté vacío
            if (string.IsNullOrWhiteSpace(tbNombreMascota.Text))
            {
                MessageBox.Show("El nombre de la mascota no puede estar vacío.", "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

           

            if (string.IsNullOrWhiteSpace(tbEdad.Text))
            {
                MessageBox.Show("La edad de la mascota no puede estar vacía.", "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (string.IsNullOrWhiteSpace(tbRaza.Text))
            {
                MessageBox.Show("La raza de la mascota no puede estar vacía.", "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (string.IsNullOrWhiteSpace(cbDueño.Text))
            {
                MessageBox.Show("El Dueño de la mascota no puede estar vacía.", "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            // Intentar convertir la edad a entero
            int t_edad;
            if (!int.TryParse(tbEdad.Text, out t_edad))
            {
                MessageBox.Show("La edad debe ser un número válido.", "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }


           return true;
        }

        #endregion

        #region Buscar

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string t_nombre = tbNonbreBuscar.Text;
            Boolean encontrado = false;
            int cont = 0;
            foreach (Mascota mascota in Form1.listMascota)
            {
                cont++;
                if (mascota.T_Nombre.Equals(t_nombre))
                {
                    ListViewItem[] itemsEncontrados = lvLista.Items.Find(t_nombre, false);
                    foreach (ListViewItem item in itemsEncontrados)
                    {
                        item.Selected = true;
                    }

                    encontrado = true;
                }
            }
            if (encontrado)
            {
                MessageBox.Show("Mascota encontrado.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Mascota no encontrado.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            limpiarBuscar();
        }

        private void limpiarBuscar()
        {
            tbNonbreBuscar.Clear();
            tbNonbreBuscar.Focus();
        }

        #endregion

        #region Validaciones

        private void tbEdad_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Verifica si la tecla presionada no es un dígito, el carácter de control (como Backspace), o el carácter de punto decimal
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                // Si la tecla presionada no es válida, cancela el evento
                e.Handled = true;
            }
        }
        private void tbNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                // Verifica si la tecla presionada no es una letra, un espacio ni una tecla de control (como Backspace)
                if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
                {
                    // Si la tecla presionada no es válida, cancela el evento
                    e.Handled = true;
                    // Muestra un mensaje indicando que solo se permiten letras y espacios
                    MessageBox.Show("Solo se permiten letras y espacios.", "Entrada no válida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                // Maneja cualquier excepción aquí (aunque es raro que ocurra una excepción en este caso)
                MessageBox.Show($"Error: {ex.Message}", "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void tbNonbreBuscar_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                // Verifica si la tecla presionada no es una letra, un espacio ni una tecla de control (como Backspace)
                if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
                {
                    // Si la tecla presionada no es válida, cancela el evento
                    e.Handled = true;
                    // Muestra un mensaje indicando que solo se permiten letras y espacios
                    MessageBox.Show("Solo se permiten letras y espacios.", "Entrada no válida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                // Maneja cualquier excepción aquí (aunque es raro que ocurra una excepción en este caso)
                MessageBox.Show($"Error: {ex.Message}", "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #region NombreMascota

        private void tbNombreMascota_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                // Verifica si la tecla presionada no es una letra, un espacio ni una tecla de control (como Backspace)
                if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
                {
                    // Si la tecla presionada no es válida, cancela el evento
                    e.Handled = true;
                    // Muestra un mensaje indicando que solo se permiten letras y espacios
                    MessageBox.Show("Solo se permiten letras y espacios.", "Entrada no válida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                // Maneja cualquier excepción aquí (aunque es raro que ocurra una excepción en este caso)
                MessageBox.Show($"Error: {ex.Message}", "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion

        #region Raza
        private void tbRaza_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                // Verifica si la tecla presionada no es una letra, un espacio ni una tecla de control (como Backspace)
                if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
                {
                    // Si la tecla presionada no es válida, cancela el evento
                    e.Handled = true;
                    // Muestra un mensaje indicando que solo se permiten letras y espacios
                    MessageBox.Show("Solo se permiten letras y espacios.", "Entrada no válida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                // Maneja cualquier excepción aquí (aunque es raro que ocurra una excepción en este caso)
                MessageBox.Show($"Error: {ex.Message}", "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion

        #region Telefono

        private void tbTelefono_KeyPress(object sender, KeyPressEventArgs e)
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

        private void tbTelefono_TextChanged(object sender, EventArgs e)
        {
            // Verifica si el contenido actual del TextBox excede 9 caracteres
            if (tbTelefono.Text.Length > 9)
            {
                // Si es así, recorta el texto a 9 caracteres
                tbTelefono.Text = tbTelefono.Text.Substring(0, 9);
                // Coloca el cursor al final del texto
                tbTelefono.SelectionStart = tbTelefono.Text.Length;
            }
        }

        private void tbTelefono_Leave(object sender, EventArgs e)
        {

            // Verifica si el contenido actual del TextBox tiene exactamente 9 caracteres
            if (tbTelefono.Text.Length != 9)
            {
                // Si no tiene 9 caracteres, muestra un mensaje de error
                MessageBox.Show("El número debe tener exactamente 9 dígitos.", "Entrada no válida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                // Opcionalmente, puedes enfocarte nuevamente en el TextBox para que el usuario lo corrija
                tbTelefono.Focus();
            }
        }
        #endregion

        #endregion
    }
}
