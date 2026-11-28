using System;
using EmployeeManager.Models;
using NUnit.Framework;

namespace EmployeeManagerApp.Tests
{
    [TestFixture]
    public class EmployeeTests
    {
        [Test]
        public void CalculateAnnualBonus_ValidSalary_Returns10Percent()
        {
            // Arrange
            var employee = new Employee { FullName = "Ana Cruz", Department = "IT", Salary = 50000m };

            // Act
            decimal bonus = employee.CalculateAnnualBonus();

            // Assert
            Assert.That(bonus, Is.EqualTo(5000m));
        }

        [Test]
        public void CalculateAnnualBonus_ZeroSalary_ReturnsZero()
        {
            // Arrange
            var employee = new Employee { FullName = "Ana Cruz", Department = "IT", Salary = 0m };

            // Act
            decimal bonus = employee.CalculateAnnualBonus();

            // Assert
            Assert.That(bonus, Is.EqualTo(0m));
        }

        [Test]
        public void CalculateAnnualBonus_NegativeSalary_ThrowsArgumentException()
        {
            // Arrange
            var employee = new Employee { FullName = "Ana Cruz", Department = "IT", Salary = -100m };

            // Act & Assert
            Assert.Throws<ArgumentException>(() => employee.CalculateAnnualBonus());
        }
    }
}