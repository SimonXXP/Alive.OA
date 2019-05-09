using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alive.OA.Model
{
    [Table("UserInfo")]
    public class UserInfo
    {
        [Key]
        public Guid ID { get; set; }
        [StringLength(20)]
        public string UserName { get; set; }
        [StringLength(20)]
        public string Pwd { get; set; }

        public virtual ICollection<Role> UserRoles { get; set; }
    }
}
