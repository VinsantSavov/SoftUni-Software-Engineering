using System.Collections.Generic;

namespace P04.Hospital
{
    public class Doctor
    {
        public Doctor(string name)
        {
            this.Name = name;
            this.Patients = new List<string>();
        }

        public string Name { get; private set; }
        public List<string> Patients { get; private set; }

        public void NewPatient(string patient)
        {
            this.Patients.Add(patient);
        }
    }
}
