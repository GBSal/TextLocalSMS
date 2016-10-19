using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace SMSLoclText
{
    class Program
    {

        //This is the sample code send SMS using TextLocal
        //http://www.textlocal.com/

        static void Main(string[] args)
        {


            string message = HttpUtility.UrlEncode("Hello I m try to send message from Application");

            byte[] response;
            using (var wp = new WebClient())
            {

                response = wp.UploadValues("http://api.txtlocal.com/send/", new NameValueCollection {
                {"username" , "salman_it24@hotmail.com"},
                {"apiKey" , "S+HCSg4PDgY-am70CrGAI3byoH4op21zdFO1Qy6pJI"},
                {"numbers" , "00447972714610"},
                {"message" , message},
                {"sender" , "WokWelfare"}
                });


                

            }


            string result = System.Text.Encoding.UTF8.GetString(response);


            Console.WriteLine(result);

            
            Console.WriteLine("Press any key to continue...");
            Console.ReadLine();



        }



        }
    }

