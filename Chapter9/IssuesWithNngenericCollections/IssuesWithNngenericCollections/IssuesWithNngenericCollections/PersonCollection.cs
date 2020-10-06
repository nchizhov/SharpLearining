using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IssuesWithNngenericCollections
{
    class PersonCollection: IEnumerable
    {
        private ArrayList arPeople = new ArrayList();
        public Person GetPerson(int pos) => (Person)arPeople[pos];
        public void AddPerson(Person p)
        {
            arPeople.Add(p);
        }
        public void ClearPeople()
        {
            arPeople.Clear();
        }
        public int Count => arPeople.Count;
        IEnumerator IEnumerable.GetEnumerator() => arPeople.GetEnumerator();
    }
}
