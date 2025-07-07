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
        public FormAsistencia()
        {
            InitializeComponent();

            // definir columnas
            dgvAlumnos.Columns.Clear();

            dgvAlumnos.Columns.Add("Codigo", "Código");
            dgvAlumnos.Columns["Codigo"].ReadOnly = true;

            dgvAlumnos.Columns.Add("Nombre", "Nombre");
            dgvAlumnos.Columns["Nombre"].ReadOnly = true;

            dgvAlumnos.Columns.Add("Apellidos", "Apellidos");
            dgvAlumnos.Columns["Apellidos"].ReadOnly = true;

            dgvAlumnos.Columns.Add("Curso", "Curso");
            dgvAlumnos.Columns["Curso"].ReadOnly = true;

            var colPresente = new DataGridViewCheckBoxColumn();
            colPresente.Name = "Presente";
            colPresente.HeaderText = "Presente";
            dgvAlumnos.Columns.Add(colPresente);

            // ahora carga datos
            CargarAlumnosDesdeBase();
        }


        private void CargarAlumnosDesdeBase()
        {
            dgvAlumnos.Rows.Clear();

            using (var conexion = new MySql.Data.MySqlClient.MySqlConnection(Conexion.Cadena))
            {

                try
                {
                    conexion.Open();
                    string query = @"
                SELECT a.codigo, a.nombre, a.apellidos, a.curso, 
                       IFNULL(ast.presente, false) AS presente
                FROM alumnos a
                LEFT JOIN asistencias ast 
                    ON ast.id_alumno = a.id_alumno AND ast.fecha = @fecha
                WHERE a.id_profesor = @idProfesor
            ";

                    using (var cmd = new MySql.Data.MySqlClient.MySqlCommand(query, conexion))
                    {
                        cmd.Parameters.AddWithValue("@idProfesor", Sesion.IdProfesor);
                        cmd.Parameters.AddWithValue("@fecha", DateTime.Today);

                        var reader = cmd.ExecuteReader();
                        while (reader.Read())
                        {
                            dgvAlumnos.Rows.Add(
                                reader.GetString("codigo"),
                                reader.GetString("nombre"),
                                reader.GetString("apellidos"),
                                reader.GetString("curso"),
                                reader.GetBoolean("presente")
                            );
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al cargar alumnos: " + ex.Message);
                }
            }
        }




        private void btnGuardar_Click(object sender, EventArgs e)
        {
            dgvAlumnos.EndEdit();

            using (var conexion = new MySql.Data.MySqlClient.MySqlConnection(Conexion.Cadena))
            {
                try
                {
                    conexion.Open();

                    for (int i = 0; i < dgvAlumnos.Rows.Count; i++)
                    {
                        var fila = dgvAlumnos.Rows[i];
                        bool presente = false;

                        if (fila.Cells["Presente"].Value != null)
                        {
                            bool.TryParse(fila.Cells["Presente"].Value.ToString(), out presente);
                        }

                        string codigo = fila.Cells["Codigo"].Value.ToString();

                        // obtener id_alumno
                        string sqlId = "SELECT id_alumno FROM alumnos WHERE codigo = @codigo";
                        int idAlumno = 0;
                        using (var cmdId = new MySql.Data.MySqlClient.MySqlCommand(sqlId, conexion))
                        {
                            cmdId.Parameters.AddWithValue("@codigo", codigo);
                            var result = cmdId.ExecuteScalar();
                            if (result != null)
                                idAlumno = Convert.ToInt32(result);
                        }

                        if (idAlumno > 0)
                        {
                            string sql = @"
                        INSERT INTO asistencias (id_alumno, fecha, presente)
                        VALUES (@idAlumno, @fecha, @presente)
                        ON DUPLICATE KEY UPDATE presente = @presente
                    ";
                            using (var cmd = new MySql.Data.MySqlClient.MySqlCommand(sql, conexion))
                            {
                                cmd.Parameters.AddWithValue("@idAlumno", idAlumno);
                                cmd.Parameters.AddWithValue("@fecha", DateTime.Today);
                                cmd.Parameters.AddWithValue("@presente", presente);
                                cmd.ExecuteNonQuery();
                            }
                        }
                    }

                    MessageBox.Show("Asistencias guardadas correctamente.");
                    CargarAlumnosDesdeBase(); // para actualizar checks
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al guardar asistencia: " + ex.Message);
                }
            }
        }



        private void FormAsistencia_Load(object sender, EventArgs e)
        {
        }
    }
}
