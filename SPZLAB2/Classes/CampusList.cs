using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SPZLAB2.Classes
{
    class CampusList
    {
        public List<Campus> Campuses = new List<Campus>();// список кампусов
        public void AddCampus(Campus newCampus) // добавить кампус
        {
            Campuses.Add(newCampus);
        }
        public Campus GetCampus(int index) //обратиться по индексу
        {
            return Campuses[index];
        }
    }
}
