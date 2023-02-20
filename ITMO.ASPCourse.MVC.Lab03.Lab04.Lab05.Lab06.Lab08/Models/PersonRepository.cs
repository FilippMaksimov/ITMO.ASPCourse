using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ITMO.ASPCourse.MVC.Lab03.Lab04.Lab05.Lab06.Lab08.Models
{
    public class PersonRepository
    {
        private List<Person> persons = new List<Person>();
        public int NumberOfPerson
        {
            get { return persons.Count; }
        }
        public IEnumerable<Person> GettAllResposes
        {
            get { return persons; }
        }
        public void AddRespose (Person pers)
        {
            persons.Add(pers);
        }
    }
}