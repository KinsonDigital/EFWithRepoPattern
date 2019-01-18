using EFWithRepoPattern.Data.Entities;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;

namespace EFWithRepoPattern.Data.DesignSampleData
{
    [ExcludeFromCodeCoverage]
    public class CompaniesSampleData
    {
        public List<Company> Companies { get; set; } = new List<Company>();
    }
}
