using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnalizadorParentesisWinForms.Models
{
    public class ValidationResult
    {
        public bool IsValid { get; set; }
        public int ErrorIndex { get; set; } = -1;
        public string Message { get; set; } = "";
        public List<string> Steps { get; } = new List<string>();
    }
}
