using Dapper;
using Dapper_Crud.Entities;
using Dapper_Crud.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Data.SqlClient;
using System.Security.Cryptography.X509Certificates;

namespace Dapper_Crud.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentsController : Controller
    {
        private readonly string _connectionString;
        public StudentsController(IConfiguration configuration)
        {
            _connectionString = configuration.GetConnectionString("ConexaoPadrao");
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            using (var SqlConnection = new SqlConnection(_connectionString))
            {
                const string sql = "SELECT * FROM Students";

                var students = await SqlConnection.QueryAsync<Student>(sql);

                return Ok(students);
            }
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var parameters = new
            {
                id
            };
            using (var SqlConnection = new SqlConnection(_connectionString))
            {
                const string sql = "SELECT * FROM Students WHERE Id = @id";

                var student = await SqlConnection.QuerySingleOrDefaultAsync<Student>(sql, parameters);

                if (student == null)
                {
                    return NotFound();
                }

                return Ok(student);
            }
        }

        [HttpPost]
        public async Task<IActionResult> Post(StudentInputModel model)
        {
            var student = new Student(model.FullName, model.BirthDate, model.SchoolClass);

            var parameters = new
            {
                student.FullName,
                student.BirthDate,
                student.SchoolClass,
                student.IsActive
            };

            using (var SqlConnection = new SqlConnection(_connectionString))
            {
                const string sql = "INSERT INTO Students OUTPUT INSERTED.Id Values (@FullName, @BirthDate, @SchoolClass, @IsActive)";

                var id = await SqlConnection.ExecuteScalarAsync<int>(sql, parameters);

                return Ok(id);
            }
        }

        [HttpPut]
        public async Task<IActionResult> Put(int id, StudentInputModel model)
        {
            var parameters = new
            {
                id,
                model.FullName,
                model.BirthDate,
                model.SchoolClass
            };

            using (var SqlConnection = new SqlConnection(_connectionString))
            {
                const string sql = "UPDATE Students SET FullName = @FullName, BirthDate = @BirthDate, SchoolClass = @SchoolClass WHERE Id = @id";

                await SqlConnection.ExecuteAsync(sql, parameters);

                return NoContent();
            }
        }

        [HttpDelete]
        public async Task<IActionResult> Delete(int id)
        {
            var parameters = new
            {
                id
            };

            using (var sqlConnection = new SqlConnection(_connectionString))
            {
                const string sql = "UPDATE Students SET IsActive = 0 WHERE Id = @id";

                await sqlConnection.ExecuteAsync(sql, parameters);

                return NoContent();
            }
        }



    }
}
