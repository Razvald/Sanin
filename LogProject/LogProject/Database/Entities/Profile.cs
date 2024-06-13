using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LogProject.Database.Entities
{
    public class Profile
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [ForeignKey("Area")]
        public int AreaId { get; set; }

        [ForeignKey("Operator")]
        public int OperatorId { get; set; }
        public virtual Area Area { get; set; }
        public virtual Operator Operator { get; set; }
    }
}
