namespace Dapper_Crud.Entities
{
    public class Student
    {
        protected Student() { }

        public Student(string Fullname, DateTime BirthDate, string SchoolClass)
        {
            FullName = Fullname;
            BirthDate = BirthDate;
            SchoolClass = SchoolClass;
            IsActive = true;
        }

        public int Id { get; private set; }
        public string FullName { get; private set; }
        public DateTime BirthDate { get; private set; }
        public string SchoolClass { get; private set; }
        public bool IsActive { get; private set; }
    }
}
