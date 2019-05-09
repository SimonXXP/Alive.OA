using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alive.OA.Model
{
    [Table("Role")]
    public class Role
    {
        [Key]
        public Guid ID { get; set; }
        [StringLength(20)]
        public string RoleName { get; set; }
        public virtual ICollection<UserInfo> RoleUsers { get; set; }
    }
}
