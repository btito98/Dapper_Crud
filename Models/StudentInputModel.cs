using System.ComponentModel.DataAnnotations;

namespace Dapper_Crud.Models
{
    public class StudentInputModel
    {
        public string FullName { get; set; }
        [DataType(DataType.DateTime)]
        public DateTime BirthDate { get; set; }
        public string SchoolClass { get; set; }
    }
}
