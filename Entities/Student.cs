namespace Dapper_Crud.Entities
{
    public class Student
    {
        protected Student() { }

        public Student(string Fullname, int Age, string SchoolClass)
        {
            FullName = Fullname;
            Age = Age;
            SchoolClass = SchoolClass;
            IsActive = true;
        }

        public int Id { get; private set; }
        public string FullName { get; private set; }
        public int Age { get; private set; }
        public string SchoolClass { get; private set; }
        public bool IsActive { get; private set; }
    }
}
