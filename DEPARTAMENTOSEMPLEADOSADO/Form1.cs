using DEPARTAMENTOSEMPLEADOSADO.Models;

namespace DEPARTAMENTOSEMPLEADOSADO
{
    public partial class EmpleadosDepartamentos : Form
    {
        Repository.RepositoryDepartamentos repository;
        public EmpleadosDepartamentos()
        {
            InitializeComponent();
            repository = new Repository.RepositoryDepartamentos();
            LoadDepartamentos();

        }

        public async void LoadDepartamentos()
        {

            List<string> departamentos = await repository.GetDepartamentos();
            this.cmbDepartamentos.Items.Clear();
            foreach (string departamento in departamentos)
            {
                this.cmbDepartamentos.Items.Add(departamento);
            }
        }

        private void btnInsertarDepartamento_Click(object sender, EventArgs e)
        {
            int id = int.Parse(this.txtId.Text);
            string nombre = this.txtNombre.Text;
            string localidad = this.txtLocalidad.Text;

            repository.InsertarDepartamento(id, nombre, localidad);
            LoadDepartamentos();
        }

        private async void cmbDepartamentos_SelectedIndexChanged(object sender, EventArgs e)
        {
            Repository.RepositoryDepartamentos repository = new Repository.RepositoryDepartamentos();
            string nombre = this.cmbDepartamentos.SelectedItem.ToString();

            Departamentos departamento = await repository.GetDatosDepartamento(nombre);

            this.txtId.Text = departamento.Id.ToString();
            this.txtNombre.Text = departamento.Nombre;
            this.txtLocalidad.Text = departamento.Localidad;
            this.lstEmpleados.Items.Clear();
            departamento.Empleados.ForEach(empleado => this.lstEmpleados.Items.Add(empleado));
        }

        private async void lstEmpleados_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.lstEmpleados.SelectedItem != null)
            {
                string apellido = this.lstEmpleados.SelectedItem.ToString();

                Empleado empleado = await repository.GetDatosEmpleado(apellido);

                if (empleado != null)
                {
                    this.txtApellido.Text = empleado.Apellido.ToString();
                    this.txtOficio.Text = empleado.Oficio.ToString();
                    this.txtSalario.Text = empleado.Salario.ToString();

                }
                else
                {
                    MessageBox.Show("No se encontró información sobre el empleado seleccionado.",
                                    "Error",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Warning);
                }
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string apellido = this.txtApellido.Text;
            string oficio = this.txtOficio.Text;
            int salario = int.Parse(this.txtSalario.Text);
            

            //repository.UpdateEmpleado(apellido, oficio, salario);


        }
    }
}
