using ExampleApplication.Models;
using ExampleApplication.Services;
using Microsoft.EntityFrameworkCore;
using Moq;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExampleTest
{
    public class EmployeeServiceTest
    {
        [Test]
        public async Task GetAllTestPassAsync()
        {
            //Arrange
            List<Employee> employees = new List<Employee>()
            {
                new Employee(){ Id = 1, Name ="Ramu",Salary =12345.6f}
            };
            var dbSetMock = new Mock<DbSet<Employee>>();
            var queribaleData = employees.AsQueryable();
            dbSetMock.As<IQueryable<Employee>>().Setup(emp=>emp.Provider).Returns(queribaleData.Provider);
            dbSetMock.As<IQueryable<Employee>>().Setup(emp => emp.Expression).Returns(queribaleData.Expression);
            dbSetMock.As<IQueryable<Employee>>().Setup(emp => emp.ElementType).Returns(queribaleData.ElementType);
            dbSetMock.As<IQueryable<Employee>>().Setup(emp => emp.GetEnumerator()).Returns(queribaleData.GetEnumerator());
            var contextMock = new Mock<CompanyContext>();
            contextMock.Setup(ctx=>ctx.Employees).Returns(dbSetMock.Object);
            IRepo<int,Employee> repo = new EmployeeRepo(contextMock.Object);
            //Action
            var res = await repo.GetAll();
            //Assert
            Assert.AreEqual(1, res.Count);
        }
    }
}
