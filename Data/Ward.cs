using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebAPI_Core_Test_DesignDb.Models
{
    public class Ward
    {
        public int idWard { get; set; }
        public string NameWard { get; set; }
        public List<User> Users { get; set; }
    }
}
