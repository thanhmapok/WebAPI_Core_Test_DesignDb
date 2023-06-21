using System;

namespace WebAPI_Core_Test_DesignDb.Models
{
    public class UserInfo
    {
        public string Name { get; set; }
        public string Role { get; set; }
        public string NameWard { get; set; }

        public static implicit operator UserInfo(UserInfo v)
        {
            throw new NotImplementedException();
        }
    }
}
