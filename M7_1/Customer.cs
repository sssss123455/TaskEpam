using System;
using System.Collections.Generic;
using System.Text;

namespace M7_1
{
    public class Customer
    {
        public const string text = "Customer record: ";
        public string Name { get; set; }
        public string ContactPhone { get; set; }
        public decimal Revenue { get; set; }
        public Customer(string name,string contactPhone,decimal revenue)
        {
            this.Name = name;
            this.ContactPhone = contactPhone;
            this.Revenue = revenue;
        }
        public static string GetCustomerRecord(int num)
        {
            Customer customer = new Customer("Jeffrey Richter", "+1 (425) 555-0100", 1000000);
            string answer = null;
            switch (num)
            {
                case 1:
                    answer =$"{text}{customer.Name },{customer.Revenue}";
                    break;
                case 2:
                    answer= $"{text}{customer.Name },{customer.ContactPhone}";
                    break;
                case 3:
                    answer= $"{text}{customer.ContactPhone},{customer.Revenue}"; 
                    break;
                case 4:
                    answer= $"{text}{customer.Name}";
                    break;
                case 5:
                    answer= $"{text}{customer.Revenue}";
                    break;
                default:
                    answer= $"{text}{customer.Name },{customer.ContactPhone},{customer.Revenue}";
                    break;
            }
            return answer;
        }
    }
}
