using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cvicenie2_triedy
{
    class PersonDatabase
    {
        private List<Person> _people = new List<Person>();
        
        public void Add(params Person[] person)
        {
            for (int i = 0; i < person.Count(); i++)
            {
                _people.Add(person[i]);
            }
        }

        public void Add(Person person)
        {
            _people.Add(person);
        }

        public List<Person> Find(string text, Gender? gender = null)
        {
            return _people.Where(p =>
            (p.FullName.Contains(text) || 
            p.FirstName.Contains(text) || 
            p.LastName.Contains(text)) && 
            (gender == null || p.Gender == gender)).ToList();
        }
    }
}
