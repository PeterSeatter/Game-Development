using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace SchoolApp
{
    class Program
    {
        static void Main(string[] args)
        {

            //public float Func <float , float , float> adad =  (x,y,z) => (x+y+z);
        }

        public class School
        {
            public string Name { get; set; }
            public string Address { get; set; }
            public string City { get; set; }
            public string State { get; set; }
            public string Zip { get; set; }
            public string PhoneNumber { get; set; }

            private string _twitterAddress;
            
            public string TwitterAddress
            {
                //make sure the twitter adderss starts with @
                get { return _twitterAddress; }
                set
                {
                    if (value.StartsWith("@"))
                    {
                        _twitterAddress = value;
                    } else
                    {
                        throw new Exception("The twitter address must begin with @");
                    }
                }
            }
            
            public School()
            {
                Name = "Untitled School";
                PhoneNumber = "555-1234";
            }

            public School(string SchoolName, string SchoolPhoneNumber)
            {
                Name = SchoolName;
                PhoneNumber = SchoolPhoneNumber;
            }

            //public float AverageThreeScores(float a, float b, float c)
            //{
            //    float result = (a + b + c) / 3;
            //    return result; 
            //}
           // public float AverageThreeScores (float a, float b, float c) => (a + b + c) / 3;

            public int AverageThreeScores (int a, int b, int c)
            {
                int result = (a + b + c) / 3;
                return result;
            }

            public float Func <float , float , float> adad =  (x,y,z) => (x+y+z);

        }
    }
}