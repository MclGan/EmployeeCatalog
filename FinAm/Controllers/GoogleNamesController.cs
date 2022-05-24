using Microsoft.AspNetCore.Mvc;
using System.Linq;
using System.Text;


// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace FinAm.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GoogleNamesController : ControllerBase
    {


        // GET api/<GoogleNames>/firstName/LastName
        [HttpGet("{firstName}/{lastName}")]
        public string Get(string firstName, string lastName)
        {
            List<Employee> foundEmployees = EmployeeCollection.Find(firstName, lastName);

            if (!foundEmployees.Any())
                return string.Format("{0} {1} не найден", firstName, lastName);

            StringBuilder stringBuilder = new StringBuilder();
            foreach (Employee employee in foundEmployees)
                stringBuilder.AppendLine(string.Format("{0} {1} найден", employee.FirstName, employee.LastName)); 
            return stringBuilder.ToString();
        }

    }
}
