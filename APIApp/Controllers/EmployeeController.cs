using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using APIApp.Models;
using System.Xml.Linq;
using System.Xml;
using System.Text;
using Newtonsoft.Json;

namespace APIApp.Controllers
{
    public class EmployeeController : ApiController
    {
        //[HttpGet]
        //public List<Employee> GetAllEmpoyees()
        //{
        //    List<Employee> employees = new List<Employee>();            
        //    XDocument doc = XDocument.Load(@"/Users/hp/Documents/TestAPI/APIApp/APIApp/App_Start/Employee.xml");
        //    foreach (XElement element in doc.Descendants("documentelement").Descendants("employee"))
        //    {
        //        Employee employee = new Employee();
        //        employee.ID = element.Element("id").Value;
        //        employee.Cmp_Name = element.Element("cmp_name").Value;
        //        employee.Address = element.Element("address").Value;
        //        employees.Add(employee);
        //    }
        //    return employees;
        //}

        //[HttpGet]
        //public Employee GetEmployee(int id)
        //{
        //    Employee employee = new Employee();
        //    XDocument doc = XDocument.Load(@"/Users/hp/Documents/TestAPI/APIApp/APIApp/App_Start/Employee.xml");
        //    XElement element = doc.Element("documentelement").Elements("employee").Elements("id").SingleOrDefault(x => x.Value == id.ToString());
        //    if (element != null)
        //    {
        //        XElement parent = element.Parent;
        //        employee.ID = parent.Element("id").Value;
        //        employee.Cmp_Name = parent.Element("cmp_name").Value;
        //        employee.Address = parent.Element("address").Value;
        //        return employee;
        //    }
        //    else
        //    {
        //        throw new HttpResponseException(new HttpResponseMessage(HttpStatusCode.NotFound));
        //    }
        //}

        public HttpResponseMessage Get()
        {
            XmlDocument doc = new XmlDocument();
            doc.Load(@"/Users/hp/Documents/TestAPI/APIApp/APIApp/App_Start/EmployeeTest.xml");

            HttpResponseMessage response = this.Request.CreateResponse(HttpStatusCode.OK);

            string json = JsonConvert.SerializeXmlNode(doc);
            response.Content = new StringContent(json, Encoding.UTF8, "application/json");

            return response;
        }
    }
}
