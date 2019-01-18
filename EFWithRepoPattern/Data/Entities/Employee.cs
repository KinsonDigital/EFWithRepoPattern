namespace EFWithRepoPattern.Data.Entities
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("Employee")]
    public partial class Employee
    {
        #region Props
        [Key]
        public int EmployeeID { get; set; }

        public int CompanyID { get; set; }

        [Required]
        [StringLength(50)]
        public string FirstName { get; set; }

        [Required]
        [StringLength(50)]
        public string LastName { get; set; }

        public int Age { get; set; }

        public virtual Company Company { get; set; }
        #endregion 
    }
}
