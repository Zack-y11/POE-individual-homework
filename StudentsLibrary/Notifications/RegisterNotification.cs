using StudentsLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentsLibrary.Notifications
{
    public class RegisterNotification
    {
        public event EventHandler<StudentClass> RegistrationCompleted;
        
        public void CompleteRegistration (StudentClass student)
        {
            OnRegistration(student);
        }
        protected virtual void OnRegistration(StudentClass student)
        {
            RegistrationCompleted?.Invoke(this, student);
        }

    }
}
