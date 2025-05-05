using LeetCodeDailys.DesignPatterns;

namespace Testing
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            Employee employeeBuilder = new EmployeeBuilder()
                .SetName("daw")
                .Setposition("daw")
                .SetDepartment("Dwadaw")
                .build();

            Assert.Equal("aa", employeeBuilder.ToString());
        }
    }
}