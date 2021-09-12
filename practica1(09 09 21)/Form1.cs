using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace practica1_09_09_21_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnFLL_Click(object sender, EventArgs e)
        {
            dgData.Columns.Add("idEstudiantes", "CODIGO");
            dgData.Columns.Add("firstName", "NOMBRE");
            dgData.Columns.Add("lastName", "APELLIDO");
            dgData.Columns.Add("age", "EDAD");
            dgData.Columns.Add("nationality", "NACIONALIDAD");

            foreach (var Estudiantes in selectAllData())
            {
                dgData.Rows.Add(Estudiantes.idEstudiantes, Estudiantes.firstName, Estudiantes.lastName, Estudiantes.age, Estudiantes.nationality);
            }
        }

        private static List<Estudiantes> selectAllData()
        {
            //crear la consulta
            List<Estudiantes> result = (
                                    from Estudiantes in Estudiantes.GetEstudiantes()
                                    select new Estudiantes()
                                    {
                                        idEstudiantes = Estudiantes.idEstudiantes,
                                        firstName = Estudiantes.firstName,

                                        lastName = Estudiantes.lastName,
                                        age = Estudiantes.age,
                                        nationality = Estudiantes.nationality
                                    }
                ).ToList();
            //retorna el resultado de la consulta
            return result;
        }
    }

    }

