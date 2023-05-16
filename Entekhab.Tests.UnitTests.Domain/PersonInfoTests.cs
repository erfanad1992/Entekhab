using Entekhab.Domain;

namespace Entekhab.Tests.UnitTests.Domain
{
    public class PersonInfoTests
    {
        [Fact]
        public void Update_Should_Update_PersonInfo()
        {
            // Arrange
            var personInfo = new PersonInfo(
                Guid.NewGuid(),
                "erfan",
                "darvish",
                DateTimeOffset.Now,
                1000,
                200,
                150,
                900
            );

            // Act
            personInfo.Update(
                "erfan",
                "darvish",
                DateTimeOffset.Now.AddDays(1),
                1500,
                300,
                200,
                1200
            );

            // Assert
            Assert.Equal("erfan", personInfo.Name);
            Assert.Equal("darvish", personInfo.Family);
            Assert.NotEqual(DateTimeOffset.Now, personInfo.Date);
            Assert.Equal(1500, personInfo.BasicSalary);
            Assert.Equal(300, personInfo.Allowance);
            Assert.Equal(200, personInfo.Transportation);
            Assert.Equal(1200, personInfo.SalaryAfterTax);
        }
    }
}
