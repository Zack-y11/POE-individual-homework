using StudentsLibrary.Models;
using StudentsLibrary.Notifications;
using StudentsLibrary.Validators;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Tab;

namespace SystemManageStudentUI
{
    public partial class GradeStudents : Form
    {
        private GradesNotification _GradesNotifyHandler;
        public GradeStudents()
        {
            InitializeComponent();
            _GradesNotifyHandler = new GradesNotification();
            _GradesNotifyHandler.ReportCompleted += OnReportFinished;
        }
        private void OnReportFinished(object sender, StudentClass student)
        {
            SendReportNotify(student);
        }
        private void SendReportNotify(StudentClass student)
        {
            
            string action = "Report Completed Successfully";
            string body;
            if (string.IsNullOrEmpty(MensajeTextBox.Text))
            {
                body = $"Felicidades por el rendimiento que obtuviste: {student.NotaFinal} , sigue mejorando";
            }
            else
            {
                body = $"{MensajeTextBox.Text}, obtuviste una nota de {student.NotaFinal}";
            }
            MessageBox.Show($"Para: {student.Correo} \n\n Informe: {action}\n\n{body}");


        }

        private void NotasEstudianteButton_Click(object sender, EventArgs e)
        {
            try
            {
                NotaFinalLabel.Text = string.Empty;
                StudentClass student = new StudentClass();
                ValidatorInfo validator = new ValidatorInfo();
                double primeraNota = double.Parse(PrimeraNotaTextBox.Text);
                double segundaNota = double.Parse(SegundaNotaTextBox.Text);
                double TerceraNota = double.Parse(TercerNotaTextBox.Text);


                if ((primeraNota >= 0 && primeraNota <= 10) &&
                    (segundaNota >= 0 && segundaNota <= 10) &&
                    (TerceraNota >= 0 && TerceraNota <= 10) &&
                    validator.ValidateEmail(correoEstudianteTextBox.Text))
                {
                    student.Correo = correoEstudianteTextBox.Text;
                    student.NotaFinal = student.GetNotas(primeraNota, segundaNota, TerceraNota);
                    _GradesNotifyHandler.CompleteReport(student);
                    NotaFinalLabel.Text = Convert.ToString(student.NotaFinal);
                    PrimeraNotaTextBox.Text = string.Empty;
                    SegundaNotaTextBox.Text = string.Empty;
                    TercerNotaTextBox.Text = string.Empty;
                    correoEstudianteTextBox.Text = string.Empty;
                    MensajeTextBox.Text = string.Empty;

                }
                else
                {
                    MessageBox.Show("La nota debe estar entre 0 y 10.\n El correo debe ser valido");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
