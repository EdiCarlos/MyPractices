using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CreationalPatterns
{
    class ProxyPattern
    {
        interface Subject
        {
            void Request();            
        }
        abstract class SomeSubjects
        {
            public abstract void ShowSubjects();
        }
        class RealSubject : SomeSubjects, Subject
        {
            public void Request()
            {
                Console.WriteLine("Real Subject");
            }

            public override void ShowSubjects()
            {
                Console.WriteLine("English, Mathematics, Science etc are some subjects...");
            }
        }

        class Proxy : SomeSubjects, Subject
        {
            RealSubject _realSubject;
            
            public void Request()
            {
                if (_realSubject == null)
                {
                    Console.WriteLine("Real subject is not intialized");
                    Console.WriteLine("Initializing real subject");
                    _realSubject = new RealSubject();
                }
                _realSubject.Request();
            }
            public override void ShowSubjects()
            {
                if (_realSubject == null)
                {
                    _realSubject = new RealSubject();
                }
                _realSubject.ShowSubjects();
            }
        }
        internal class UsePoxySubject
        {
            public static void UseProxy()
            {
                Subject subject = new Proxy();
                subject.Request();
                ((SomeSubjects)subject).ShowSubjects();
            }
        }
    }
    class AuthenticationProxy
    {
        interface ISubject
        {
            void Request();
        }
        class RealSubject : ISubject
        {


            public void Request()
            {
                Console.WriteLine("Authenticated request");
            }
        }
        class Proxy : ISubject
        {
            string username = "axkhan2";
            string password = "password";
            RealSubject _realSubject;
            bool isAutheticated = false;
            public void Request()
            {
                if (!isAutheticated)
                {
                    if (Authenticate())
                    {
                        isAutheticated = true;
                        _realSubject = new RealSubject();
                        Console.WriteLine("Authentication Successfull");
                    }
                    else
                    {
                        Console.WriteLine("You are not autheticated to access request method");
                    }
                }
                
                if(isAutheticated)
                {
                    _realSubject.Request();
                }
            }
            public bool Authenticate()
            {
                Console.WriteLine("Enter username");
                string username = Console.ReadLine();
                Console.WriteLine("Enter password");
                string password = Console.ReadLine();
                if (this.username.Equals(username) && this.password.Equals(password))
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }
        public class UseAuthenticationProxy
        {
            public static void UseAuthetication()
            {
                ISubject subject = new Proxy();
                subject.Request();
            }
        }
    }
}
