using System;
using System.Collections.Generic;
using System.Linq;

namespace BuilderPattern
{
    public class EmployeeReportBuilder : IEmployeeReportBuilder
    {
        private EmployeeReport _employeeReport;
        private readonly IEnumerable<Employee> _employees;
        public EmployeeReportBuilder(IEnumerable<Employee> employees)
        {
            _employees = employees;
            _employeeReport = new();
        }

        public void BuildHeader()
        {
            _employeeReport.Header +=
                $"EPLOYEES REPORT ON DATE: {DateTime.Now}\n";

            _employeeReport.Header +=
                "\n--------------------------------------------------------------------------------------------------\n";
        }
        public void BuildBody()
        {
            _employeeReport.Body =
                string.Join(Environment.NewLine,
                _employees.Select(e => $"Employee: {e.Name}\t\t Salary: {e.Salary}$"));

        }
        public void BuildFooter()
        {
            _employeeReport.Footer+=
                "\n--------------------------------------------------------------------------------------------------\n";

            _employeeReport.Footer +=
                $"\nTOTAL EMPLOYEES: {_employees.Count()}, " +
                $"TOTAL SALARY: {_employees.Sum(e => e.Salary)}$";
        }
        public EmployeeReport GetReport()
        {
            EmployeeReport employeeReport = _employeeReport;
            return employeeReport;
        }
        public void Build()
        {
            BuildHeader();
            BuildBody();
            BuildFooter();
        }
    }
}
