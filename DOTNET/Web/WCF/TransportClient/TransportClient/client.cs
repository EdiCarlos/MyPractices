using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
using System.Security.Cryptography.X509Certificates;
using System.Net.Security;

namespace TransportClient
{
    class client
    {
        public static void Main()
        {
            PermissiveCertificatePolicy.Enact("CN=ServiceModelSamples-HTTPS-Server");

            CalculatorClient client = new CalculatorClient();
            int value1 = 200;
            int value2 = 100;
            Console.WriteLine("Add {0} , {1} = {2}", value1, value2, client.Addition(value1, value2));

            Console.WriteLine("Sub {0} , {1} = {2}", value1, value2, client.Subtraction(value1, value2));
            Console.WriteLine("Multiplication {0} , {1} = {2}", value1, value2, client.Multiplication(value1, value2));
            Console.WriteLine("Division {0} , {1} = {2}", value1, value2, client.Division(value1, value2));
            client.Close();
        }
    }
    class PermissiveCertificatePolicy
    {
        string subjectName;
        static PermissiveCertificatePolicy pceritificatePolicy;
        public PermissiveCertificatePolicy(string subjectName)
        {
            this.subjectName = subjectName;
            ServicePointManager.ServerCertificateValidationCallback += new System.Net.Security.RemoteCertificateValidationCallback(RemoveCertificateValidate);
        }
        public static void Enact(string subjectName)
        {
            pceritificatePolicy = new PermissiveCertificatePolicy(subjectName);
        }
        bool RemoveCertificateValidate(object sender, X509Certificate cert, X509Chain chain, SslPolicyErrors error)
        {
            if (cert.Subject == subjectName)
            {
                return true;
            }
            return false;
        }
    }
}
