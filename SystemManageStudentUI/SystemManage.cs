using StudentsLibrary.Models;
using StudentsLibrary.Notifications;
using StudentsLibrary.Validators;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace SystemManageStudentUI
{
    public partial class SystemManage : Form
    {
        private RegisterNotification _RegistrationNotifyHandler;
        public SystemManage()
        {
            InitializeComponent();
            _RegistrationNotifyHandler = new RegisterNotification();
            _RegistrationNotifyHandler.RegistrationCompleted += OnRegistration;

            StudentClass studentClass = new StudentClass();
            estudiantesComboBox.DataSource = studentClass.GetStudents();
            estudiantesComboBox.DisplayMember = "Nombres";
            estudiantesComboBox.ValueMember = "Dui";
        }

        private void OnRegistration(object sender, StudentClass student)
        {
            sendEmailNotify(student);
        }

        private void sendEmailNotify(StudentClass student)
        {
            string action = "Registration Completed Successfully";

            string body = $"Atencion {student.Nombres} se ha registrado en la universidad con exito" +
                $"\n\nEl estudiante responde al numero de DUI: {student.Dui}" +
                $"\n\nY el numero de telefono: {student.Telefono}" +
                $"\n\n Para consultas o dudas el numero: 0000-0000";

            MessageBox.Show($"Para: {student.Correo} \n\n Cuestion: {action}\n\n{body}");
        }

            private void agregarEstudianteButton_Click(object sender, EventArgs e)
            {
            ValidatorInfo validar = new ValidatorInfo();
            string errorMessage = "";

            if (!validar.ValidateName(nombreRegistroTexBox.Text))
                errorMessage += "Nombre inválido. ";
            if (!validar.ValidateEmail(correoRegistroTexBox.Text))
                errorMessage += "Correo inválido. ";
            if (!validar.ValidatePhoneNumber(telefonoRegistroTexBox.Text))
                errorMessage += "Teléfono inválido. ";
            if (!validar.ValidateDui(duiRegistroTexBox.Text))
                errorMessage += "DUI inválido. ";

            if (string.IsNullOrEmpty(errorMessage))
            {
                try
                {
                    StudentClass student = new StudentClass
                    {
                        Nombres = nombreRegistroTexBox.Text,
                        Correo = correoRegistroTexBox.Text,
                        Telefono = int.Parse(telefonoRegistroTexBox.Text),
                        Dui = duiRegistroTexBox.Text
                    };
                    _RegistrationNotifyHandler.CompleteRegistration(student);
                    MessageBox.Show("Registro completado con éxito.");
                    //luego de acaba todos los procesos, se limpian los strings
                    nombreRegistroTexBox.Text = string.Empty;
                    correoRegistroTexBox.Text = string.Empty;
                    telefonoRegistroTexBox.Text = string.Empty;
                    duiRegistroTexBox.Text = string.Empty;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al registrar: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Por favor, corrija los siguientes errores: " + errorMessage);
            }
        }

        //Si un estudiante no se encuentra en la comboBox, puede ser buscado por algunas credenciales 
        private void informeEstudianteButton_Click(object sender, EventArgs e)
        {
                string emailToFind = correoTexBox.Text;
                string duiToFind = duiTexBox.Text;
                try
                {
                    StudentManager studentManager = new StudentManager();

                    //Buscando Por Email
                    StudentClass studentEmail = studentManager.FindByEmail(emailToFind);
                    //Buscando por DUI
                    StudentClass studentDui = studentManager.FindByDui(duiToFind);
                    if (studentEmail != null || studentDui != null)
                    {
                        GradeStudents gradeStudents = new GradeStudents();
                        gradeStudents.ShowDialog();
                    }
                    else { MessageBox.Show("No se ha encontrado al estudiante"); }

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            
        }
        //La idea seria mejor con una DB tal vez con el ID poder autocompletar la parte del correo
        //A la hora de enviar las notas 
        private void estudiantesComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Evita que el ShowDialog se sobreponga al UI principal
            if (this.IsHandleCreated)
            {
            GradeStudents gradeStudents = new GradeStudents();
            gradeStudents.ShowDialog();
            }
        }
    }
}
