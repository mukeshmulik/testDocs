using CM.Contract.BusinessContract;
using CM.Contract.DataAccessContract;
using CM.Model;
using System;
using System.Collections.Generic;

namespace CM.Business
{
    public class Departments : IDepartment
    {
        public Departments(IDepartmentDBClient _departmentDBClient)
        {
            _DepartmentDBClient = _departmentDBClient;
        }
        public IDepartmentDBClient _DepartmentDBClient { get; }
        public string GetAllDepartments()
        {
            var data = _DepartmentDBClient.GetAllDepartments();
            return data;
        }
        
    }
}
