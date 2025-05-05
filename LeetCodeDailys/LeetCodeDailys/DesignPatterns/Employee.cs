

namespace LeetCodeDailys.DesignPatterns
{
    public class Employee
    {
        public string Name { get; set; }
        public int Id { get; set; }
        public string Department { get; set; }
        public string Position { get; set; }

        public override string ToString()
        {
            return string.Join(", ", Name, Department, Position);
        }
    }
}
