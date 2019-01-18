namespace EFWithRepoPattern.Data.Entities
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    /// <summary>
    /// Represents a single company with multiple <see cref="Employee"/>s.
    /// </summary>
    [Table("Company")]
    public partial class Company
    {
        #region Constructors
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Company()
        {
            Employees = new List<Employee>();
        }
        #endregion


        #region Props
        public int CompanyID { get; set; }

        [Required]
        [StringLength(50)]
        public string Name { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual List<Employee> Employees { get; set; }
        #endregion


        #region Public Methods
        /// <summary>
        /// Returns the string representation of the <see cref="Company"/>.
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return $"{Name} - {0}";
        }
        #endregion
    }
}
