namespace Ejercicio_4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        List<Pasajero> listPas = new List<Pasajero>();
        List<Registrador> listReg = new List<Registrador>();

        public void datosPasajero()
        {
            if (string.IsNullOrWhiteSpace(txtIdPasajero.Text) || string.IsNullOrWhiteSpace(txtNombrePasajero.Text) || string.IsNullOrWhiteSpace(txtApellidoPasajero.Text))
            {
                MessageBox.Show("Debe ingresar datos en todos los campos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; 
            }
            if (!int.TryParse(txtIdPasajero.Text, out int idPasajero))
            {
                MessageBox.Show("El ID del pasajero debe ser un numero entero", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Pasajero p = new Pasajero();
            p.IdPasajero = int.Parse(txtIdPasajero.Text);
            p.Nombre = txtNombrePasajero.Text;
            p.Apellido = txtApellidoPasajero.Text;

            listPas.Add(p);
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = listPas;
        }

        public void datosRegistrador()
        {
            if (string.IsNullOrWhiteSpace(txtIdRegistrador.Text) || string.IsNullOrWhiteSpace(txtNombreRegistrador.Text) || string.IsNullOrWhiteSpace(txtApellidoRegistrador.Text))
            {
                MessageBox.Show("Debe ingresar datos en todos los campos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (!int.TryParse(txtIdRegistrador.Text, out int idRegistrador))
            {
                MessageBox.Show("El ID del registrador debe ser un numero entero", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Registrador r = new Registrador();
            r.IdRegistrador = int.Parse(txtIdRegistrador.Text);
            r.NombreReg = txtNombreRegistrador.Text;
            r.ApellidoReg = txtApellidoRegistrador.Text;

            listReg.Add(r);
            dataGridView2.DataSource = null;
            dataGridView2.DataSource = listReg;
        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnPasajero_Click(object sender, EventArgs e)
        {
            datosPasajero();
        }

        private void txtIdPasajero_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
        }

        private void txtNombrePasajero_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtApellidoPasajero_TextChanged(object sender, EventArgs e)
        {
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnRegistrador_Click(object sender, EventArgs e)
        {
            datosRegistrador();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];

                int idSeleccionado = Convert.ToInt32(selectedRow.Cells["IdPasajero"].Value);

                Pasajero elementoAEliminar = listPas.FirstOrDefault(p => p.IdPasajero == idSeleccionado);
                if (elementoAEliminar != null)
                {
                    listPas.Remove(elementoAEliminar);

                    dataGridView1.DataSource = null;
                    dataGridView1.DataSource = listPas;
                }
            }
            else
            {
                MessageBox.Show("Tiene que seleccionar un elemento", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (dataGridView2.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dataGridView2.SelectedRows[0];

                int idSeleccionado = Convert.ToInt32(selectedRow.Cells["IdRegistrador"].Value);

                Registrador elementoAEliminar = listReg.FirstOrDefault(r => r.IdRegistrador == idSeleccionado);
                if (elementoAEliminar != null)
                {
                    listReg.Remove(elementoAEliminar);

                    dataGridView2.DataSource = null;
                    dataGridView2.DataSource = listReg;
                }
            }
            else
            {
                MessageBox.Show("Tiene que seleccionar un elemento", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}