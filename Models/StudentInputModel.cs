using System.ComponentModel.DataAnnotations;

namespace Dapper_Crud.Models
{
    public class StudentInputModel
    {
        public string FullName { get; set; }
        public int Age { get; set; }
        public string SchoolClass { get; set; }
    }
}
