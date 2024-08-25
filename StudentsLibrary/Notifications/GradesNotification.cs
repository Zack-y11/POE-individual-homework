using StudentsLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentsLibrary.Notifications
{
    public class GradesNotification
    {
        public event EventHandler<StudentClass> ReportCompleted;

        public void CompleteReport(StudentClass student)
        {
            OnReportFinished(student);
        }
        protected virtual void OnReportFinished(StudentClass student)
        {
            ReportCompleted?.Invoke(this, student);
        }
    }
}
