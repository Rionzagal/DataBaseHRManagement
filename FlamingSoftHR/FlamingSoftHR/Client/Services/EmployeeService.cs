using FlamingSoftHR.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace FlamingSoftHR.Client.Services
{
    public class EmployeeService : IEmployeeService
    {
        private readonly HttpClient http;
        public EmployeeService(HttpClient http)
        {
            this.http = http;
        }

        public Task<IEnumerable<Employee>> GetEmployees()
        {
            //return await http.GetJsonAsync<Employee[]>("api/employees");

            throw new NotImplementedException();
        }
    }
}
