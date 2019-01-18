using EFWithRepoPattern.Data.Entities;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;

namespace EFWithRepoPattern.Data.DesignSampleData
{
    [ExcludeFromCodeCoverage]
    public class CompaniesSampleData
    {
        public CompaniesSampleData()
        {
            Companies = new List<Company>
            {
                new Company()
                {
                    CompanyID = 1,
                    Name = "Company A",
                    Employees = new List<Employee>
                    {
                        new Employee()
                        {
                            CompanyID = 1,
                            EmployeeID = 1,
                            FirstName = "John",
                            LastName = "Doe",
                            Age = 22
                        },
                        new Employee()
                        {
                            CompanyID = 1,
                            EmployeeID = 2,
                            FirstName = "Bozo",
                            LastName = "Smith",
                            Age = 44
                        }
                    }
                },
                new Company()
                {
                    CompanyID = 2,
                    Name = "Company B",
                    Employees = new List<Employee>
                    {
                        new Employee()
                        {
                            CompanyID = 2,
                            EmployeeID = 1,
                            FirstName = "Jake",
                            LastName = "Jones",
                            Age = 36
                        },
                        new Employee()
                        {
                            CompanyID = 2,
                            EmployeeID = 2,
                            FirstName = "JarJar",
                            LastName = "Binks",
                            Age = 29
                        }
                    }
                }
            };
        }

        public List<Company> Companies { get; set; } = new List<Company>();
    }
}
