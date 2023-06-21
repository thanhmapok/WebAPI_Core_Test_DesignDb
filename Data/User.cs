using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebAPI_Core_Test_DesignDb.Models
{
    public class User
    {
        public int idUser { get; set; }
        public string Name { get; set; }
        public string Role { get; set; }
        public int idWard { get; set; }
        public List<Ward> Ward { get; set; }
    }
}
