using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace IMS.Domain.Models
{
    public class BaseClass
    {
        [Key]
        public Guid Id { get; set; }

        [ForeignKey(nameof(CreatedById))]
        public string CreatedById { get; set; }
        public virtual AppUser CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }


        [ForeignKey(nameof(UpdatedById))]
        public string UpdatedById { get; set; }
        public virtual AppUser UpdatedBy { get; set; }
        public DateTime UpdatedDate { get; set; }


        [ForeignKey(nameof(DeletedById))]
        public string DeletedById { get; set; }
        public virtual AppUser DeletedBy { get; set; }
        public DateTime DeletedDate { get; set; }
        
    }
}
