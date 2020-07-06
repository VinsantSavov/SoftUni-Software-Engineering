using System;

namespace _8.HotelRoom
{
    class Program
    {
        static void Main(string[] args)
        {
            string month = Console.ReadLine();
            int numNights = int.Parse(Console.ReadLine());

            double discount = 0;
            double costApartment=0;
            double costStudio=0;

            if(month == "May" || month == "October")
            {
                costApartment = numNights * 65;
                costStudio = numNights * 50;

               
                if (numNights > 7 && numNights <= 14)
                {
                           
                    discount = costStudio * 0.05;

                    costStudio = costStudio - discount;

                    
                }
                else if (numNights > 14)
                {

                    discount = costApartment * 0.1;
                    costApartment = costApartment - discount;
                    discount = costStudio * 0.3;

                    costStudio = costStudio - discount;
                }

            }
            else if (month == "June" || month == "September")
            {
                costApartment = numNights * 68.70;
                costStudio = numNights * 75.20;

                
                if (numNights > 14)
                {
                  
                    
                    discount = costStudio * 0.2;

                    costStudio = costStudio - discount;
                    discount = costApartment * 0.1;
                    costApartment = costApartment - discount;
                }
               
            }
            else if (month == "July" || month == "August")
            {
                costApartment = numNights * 77;
                costStudio = numNights * 76;

                if(numNights > 14)
                {
                    discount = costApartment * 0.1;
                    costApartment = costApartment - discount;
                }
                
                
            }

            Console.WriteLine("Apartment: {0:F2} lv.", costApartment);
            Console.WriteLine("Studio: {0:F2} lv.", costStudio); 
        }
    }
}
