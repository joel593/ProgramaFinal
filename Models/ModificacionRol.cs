using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace AfectacionMedioAmbiente.Web.Models
{
    public class ModificacionRol
    {
        public string RoleName { get; set; }
        public string RoleId { get; set; }
        public string[] AumentarIds { get; set; }
        public string[] BorrarIds { get; set; }
    }
}