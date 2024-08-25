using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace StudentsLibrary.Validators
{
    //Clase para validar todos los datos de Registro.
    public class ValidatorInfo
    {
        public bool ValidateName(string name)
        {
            if (string.IsNullOrWhiteSpace(name) || name.Length < 2 || name.Length > 50)
                return false;

            return Regex.IsMatch(name, @"^[a-zA-Z\s]+$");
        }
        public bool ValidateEmail(string email)
        {
            if (string.IsNullOrWhiteSpace(email))
                return false;

            return Regex.IsMatch(email, @"^[^@\s]+@[^@\s]+\.[^@\s]+$");
        }
        public bool ValidatePhoneNumber(string phone)
        {
            if (string.IsNullOrWhiteSpace(phone) || phone.Length != 8)
                return false;

            return Regex.IsMatch(phone, @"^\d{8}$");
        }
        public bool ValidateDui(string document)
        {
            if (string.IsNullOrWhiteSpace(document) || document.Length < 7 || document.Length > 9)
                return false;

            return Regex.IsMatch(document, @"^\d+$");
        }
    }
}
