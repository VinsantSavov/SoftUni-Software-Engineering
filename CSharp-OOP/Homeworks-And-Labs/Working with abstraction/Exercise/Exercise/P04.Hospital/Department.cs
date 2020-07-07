using System.Collections.Generic;

namespace P04.Hospital
{
    public class Department
    {
        public Department(string name)
        {
            this.Name = name;
            PatientsInRooms = new Dictionary<int, List<string>>();
        }

        public string Name { get; set; }
        public Dictionary<int, List<string>> PatientsInRooms { get; private set; }
        public int CountRooms { get; private set; }

        public void AddPatient(string patient)
        {
            if (!PatientsInRooms.ContainsKey(CountRooms) && CountRooms < 20)
            {
                this.PatientsInRooms.Add(CountRooms, new List<string>());
                this.PatientsInRooms[CountRooms].Add(patient);
            }
            else if(PatientsInRooms[CountRooms].Count < 3)
            {
                this.PatientsInRooms[CountRooms].Add(patient);
            }
            else
            {
                this.CountRooms++;
                this.PatientsInRooms.Add(CountRooms, new List<string>());
                this.PatientsInRooms[CountRooms].Add(patient);
            }
        }
    }
}
