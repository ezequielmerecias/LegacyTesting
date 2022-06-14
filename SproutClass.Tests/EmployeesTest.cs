using Moq;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace SproutClass.Tests
{
    public class EmployeesTest
    {
        [Fact]
        public void GetEmployeesData_ReturnsSalaries()
        {
            //var currentDataObject = new EmployeeSalaryService();
            var currentDataObject = new Mock<IEmployeeService>();
            currentDataObject.Setup(x => x.GetEmployeesData()).Returns(new List<Employee>()
            {
                new Employee() { UniqueId = 1, Salary = 100 }
            });
            var salaryData = currentDataObject.Object.GetEmployeesData();

            Assert.Contains(salaryData, x => x.Salary > 0);
        }

    }
}
