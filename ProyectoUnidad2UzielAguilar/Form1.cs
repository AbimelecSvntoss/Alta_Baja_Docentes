using POOTecNM.Monclova.Gestion;
using System.IO;

namespace ProyectoUnidad2UzielAguilar
{
    public partial class Académico : Form
    {
        List<Persona> listaPersonas = new List<Persona>();
        public Académico()
        {
            InitializeComponent();
        }
        //Metodo para actualizar y limpiar la lista
        private void ActualizarLista()
        {
            lstVisualizacion.Items.Clear();
            foreach (Persona p in listaPersonas)
            {
                //Lista completa
                lstVisualizacion.Items.Add($"ID: {p.ID} | {p.Tipo}: {p.Nombre} {p.Apellidos} | Tel: {p.Telefono} | Esp: {p.Especialidad} | Mat: {p.Matricula}");
            }

            // Creamos (o abrimos) un archivo llamado "BaseDatos.txt"
            using (StreamWriter sw = new StreamWriter("DatosTecNM.txt"))
            {
                foreach (Persona p in listaPersonas)
                {
                    sw.WriteLine(p.GenerarLineaArchivo());
                }
            }
        }
        private void GuardarEnArchivo()
        {
            try
            {
                // Esto crea el archivo DatosTecNM.txt en la carpeta del programa
                using (StreamWriter sw = new StreamWriter("DatosTecNM.txt", false))
                {
                    foreach (Persona p in listaPersonas)
                    {
                        // Usamos el método que creamos en la clase Persona
                        sw.WriteLine(p.GenerarLineaArchivo());
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar el archivo: " + ex.Message);
            }
        }

        private void btnPrincipalClick(object sender, EventArgs e)
        {
            // 1. Validar que el ID sea un número (para evitar que truene el programa)
            if (!int.TryParse(txtID.Text, out int id))
            {
                MessageBox.Show("El ID debe ser un número");
                return;
            }

            // 2. Crear el objeto con la nueva estructura
            Persona nuevaPersona = new Persona(
                id,
                txtNombre.Text,
                txtApellidos.Text,
                txtTelefono.Text,
                txtEspecialidad.Text,
                txtMatricula.Text,
                cmbTipo.Text
            );

            // 3. Guardar y Actualizar
            listaPersonas.Add(nuevaPersona);
            ActualizarLista();
            GuardarEnArchivo(); // El método que crea el .txt

            // 4. Limpiar (ahora son más cuadros)
            txtID.Clear();
            txtNombre.Clear();
            txtApellidos.Clear();
            txtTelefono.Clear();
            txtEspecialidad.Clear();
            txtMatricula.Clear();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (lstVisualizacion.SelectedIndex != -1)
            {
                // Eliminamos de la lista lógica
                listaPersonas.RemoveAt(lstVisualizacion.SelectedIndex);

                // Actualizamos la lista visual (puedes crear un método para esto)
                ActualizarLista();
                MessageBox.Show("Registro eliminado.");
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            //Guardar en un archivo
            GuardarEnArchivo();
            MessageBox.Show("Toda la información ha sido respaldada en DatosTecNM.txt");
        }

        private void Académico_Load(object sender, EventArgs e)
        {
            if (File.Exists("DatosTecNM.txt"))
            {
                string[] lineas = File.ReadAllLines("DatosTecNM.txt");
                foreach (string linea in lineas)
                {
                    //Futuras actualizaciones
                }
            }
        }
    }
}
