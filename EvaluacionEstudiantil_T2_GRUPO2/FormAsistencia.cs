using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace EvaluacionEstudiantil_T2_GRUPO2
{
    public partial class FormAsistencia : Form
    {
        // Declaraciones dentro de la clase
        private List<Alumno> _alumnos = new List<Alumno>();
        private IRegistroAsistencia _registroAsistencia = new RegistroAsistenciaEnMemoria();

        public FormAsistencia()
        {
            InitializeComponent();

            dgvAlumnos.AutoGenerateColumns = false;

            var colCodigo = new DataGridViewTextBoxColumn
            {
                Name = "Codigo",
                HeaderText = "Código",
                ReadOnly = true
            };
            dgvAlumnos.Columns.Add(colCodigo);

            var colNombre = new DataGridViewTextBoxColumn
            {
                Name = "Nombre",
                HeaderText = "Nombre",
                ReadOnly = true
            };
            dgvAlumnos.Columns.Add(colNombre);

            var colApellidos = new DataGridViewTextBoxColumn
            {
                Name = "Apellidos",
                HeaderText = "Apellidos",
                ReadOnly = true
            };
            dgvAlumnos.Columns.Add(colApellidos);

            var colCurso = new DataGridViewTextBoxColumn
            {
                Name = "Curso",
                HeaderText = "Curso",
                ReadOnly = true
            };
            dgvAlumnos.Columns.Add(colCurso);

            var colPresente = new DataGridViewCheckBoxColumn
            {
                Name = "Presente",
                HeaderText = "Presente",
                ReadOnly = false
            };
            dgvAlumnos.Columns.Add(colPresente);

            _alumnos.Add(new Alumno { Codigo = "A001", Nombre = "Lucía", Apellidos = "González", Curso = "5A" });
            _alumnos.Add(new Alumno { Codigo = "A002", Nombre = "Mateo", Apellidos = "Ramírez", Curso = "5A" });
            _alumnos.Add(new Alumno { Codigo = "A003", Nombre = "Valentina", Apellidos = "Torres", Curso = "5A" });
            _alumnos.Add(new Alumno { Codigo = "A004", Nombre = "Sebastián", Apellidos = "Flores", Curso = "5A" });
            _alumnos.Add(new Alumno { Codigo = "A005", Nombre = "Camila", Apellidos = "Rojas", Curso = "5A" });
            _alumnos.Add(new Alumno { Codigo = "A006", Nombre = "Diego", Apellidos = "Castillo", Curso = "5A" });
            _alumnos.Add(new Alumno { Codigo = "A007", Nombre = "María", Apellidos = "Cruz", Curso = "5A" });
            _alumnos.Add(new Alumno { Codigo = "A008", Nombre = "Daniel", Apellidos = "Reyes", Curso = "5A" });
            _alumnos.Add(new Alumno { Codigo = "A009", Nombre = "Antonella", Apellidos = "Morales", Curso = "5A" });
            _alumnos.Add(new Alumno { Codigo = "A010", Nombre = "Gabriel", Apellidos = "Peña", Curso = "5A" });
            _alumnos.Add(new Alumno { Codigo = "A011", Nombre = "Sofía", Apellidos = "Ortega", Curso = "5A" });
            _alumnos.Add(new Alumno { Codigo = "A012", Nombre = "Joaquín", Apellidos = "Herrera", Curso = "5A" });
            _alumnos.Add(new Alumno { Codigo = "A013", Nombre = "Isabella", Apellidos = "Vargas", Curso = "5A" });
            _alumnos.Add(new Alumno { Codigo = "A014", Nombre = "Tomás", Apellidos = "Mendoza", Curso = "5A" });
            _alumnos.Add(new Alumno { Codigo = "A015", Nombre = "Ximena", Apellidos = "Silva", Curso = "5A" });
            _alumnos.Add(new Alumno { Codigo = "A016", Nombre = "Emilio", Apellidos = "Navarro", Curso = "5A" });
            _alumnos.Add(new Alumno { Codigo = "A017", Nombre = "Renata", Apellidos = "Suárez", Curso = "5A" });
            _alumnos.Add(new Alumno { Codigo = "A018", Nombre = "Andrés", Apellidos = "Campos", Curso = "5A" });
            _alumnos.Add(new Alumno { Codigo = "A019", Nombre = "Fernanda", Apellidos = "Aguilar", Curso = "5A" });
            _alumnos.Add(new Alumno { Codigo = "A020", Nombre = "Bruno", Apellidos = "Cáceres", Curso = "5A" });


            CargarAlumnosEnTabla();
        }

        private void CargarAlumnosEnTabla()
        {
            dgvAlumnos.Rows.Clear();
            foreach (var alumno in _alumnos)
            {
                dgvAlumnos.Rows.Add(alumno.Codigo, alumno.Nombre, alumno.Apellidos, alumno.Curso, false);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void dgvAlumnos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            dgvAlumnos.EndEdit();

            for (int i = 0; i < dgvAlumnos.Rows.Count; i++)
            {
                var fila = dgvAlumnos.Rows[i];

                string codigo = fila.Cells["Codigo"].Value?.ToString();
                Alumno alumno = _alumnos.Find(a => a.Codigo == codigo);

                bool presente = false;

                // Validar si la celda tiene un valor booleano
                if (fila.Cells["Presente"].Value != null)
                {
                    bool.TryParse(fila.Cells["Presente"].Value.ToString(), out presente);
                }

                var asistencia = new Asistencia
                {
                    Alumno = alumno,
                    Fecha = DateTime.Today,
                    Presente = presente
                };

                _registroAsistencia.RegistrarAsistencia(asistencia);
            }

            MessageBox.Show("Asistencias registradas correctamente.", "Éxito");
        }
    }
}

