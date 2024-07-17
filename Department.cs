namespace UniversityAPI.Models
{
    public class Department
    {
        public int DepartmentId { get; set; }
        public string Name { get; set; }
        public int UniversityId { get; set; }
        public int? DepartmentHeadId { get; set; } // Nullable for optional head assignment
    }
}
