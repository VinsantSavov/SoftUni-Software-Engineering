using System;
using System.Collections.Generic;
using System.Linq;

namespace P04.Hospital
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            List<Department> departments = new List<Department>();
            List<Doctor> doctors = new List<Doctor>();

            while (true)
            {
                string input = Console.ReadLine();

                if(input == "Output")
                {
                    break;
                }

                string[] info = input.Split(" ", StringSplitOptions.RemoveEmptyEntries).ToArray();
                string department = info[0];
                string doctor = string.Empty;
                doctor += info[1];
                doctor += " ";
                doctor += info[2];
                string patient = info[3];

                if (!departments.Any(n=>n.Name == department))
                {
                    Department depart = new Department(department);
                    depart.AddPatient(patient);
                    departments.Add(depart);
                }
                else
                {
                    Department depart = departments.FirstOrDefault(n => n.Name == department);
                    depart.AddPatient(patient);
                }

                if (!doctors.Any(n=>n.Name == doctor))
                {
                    Doctor doc = new Doctor(doctor);
                    doc.NewPatient(patient);
                    doctors.Add(doc);
                }
                else
                {
                    Doctor doc = doctors.FirstOrDefault(n => n.Name == doctor);
                    doc.NewPatient(patient);
                }
            }

            while (true)
            {
                string input = Console.ReadLine();

                if(input == "End")
                {
                    break;
                }

                Department depart = departments.FirstOrDefault(n => n.Name == input);

                if (depart != null)
                {
                    PrintDepartment(depart);
                    continue;
                }

                Doctor doc = doctors.FirstOrDefault(n => n.Name == input);

                if (doc != null)
                {
                    PrintDoctor(doc);
                    continue;
                }

                string[] info = input.Split(" ").ToArray();
                int room = 0;

                if (Int32.TryParse(info[1], out room))
                {
                    room -= 1;
                    Department departR = departments.FirstOrDefault(n => n.Name == info[0]);
                    PrintDepartmentRoom(departR, room);
                }
    
            }
        }

        public static void PrintDepartment(Department department)
        {
            foreach (var room in department.PatientsInRooms)
            {
                foreach (var patient in room.Value)
                {
                    Console.WriteLine(patient);
                }
            }
        }

        public static void PrintDoctor(Doctor doctor)
        {
            foreach (var patient in doctor.Patients.OrderBy(p=>p))
            {
                Console.WriteLine(patient);
            }
        }

        public static void PrintDepartmentRoom(Department department, int room)
        {
            foreach (var kvp in department.PatientsInRooms)
            {
                if(kvp.Key == room)
                {
                    foreach (var patient in kvp.Value.OrderBy(n=>n))
                    {
                        Console.WriteLine(patient);
                    }
                }
            }
        }
    }
}
