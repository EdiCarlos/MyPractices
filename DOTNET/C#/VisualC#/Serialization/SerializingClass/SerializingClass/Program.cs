using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters;
using System.Runtime.Serialization.Formatters.Binary;
using System.Xml.Serialization;
using System.Windows.Forms;

namespace SerializingClass
{
    [Serializable()]
    public class Employee : ISerializable
    {
        public int EmpId;
        public string EmpName;
        public Employee()
        {
            EmpId = 0;
            EmpName = "Arif";
        }
        public Employee(SerializationInfo info, StreamingContext context)
        {
            EmpId = (int)info.GetValue("EmployeeId", typeof(int));
            EmpName = (string)info.GetValue("EmployeeName", typeof(string));
        }
        #region ISerializable Members

        public void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            info.AddValue("EmployeeId", EmpId);
            info.AddValue("EmployeeName", EmpName);

        }

        #endregion
    }
    public class clsPerson
    {
        public string FirstName, MI, LastName;

        public static void Serialize(clsPerson person)
        {
            XmlSerializer xmlserializer = new XmlSerializer(person.GetType());
            Stream stream = File.Open("person.xml", FileMode.Create);

            try
            {
                if (File.Exists("person.xml"))
                {
                    xmlserializer.Serialize(stream, person);
                    Console.WriteLine("clsPerson Class serailized");
                }
                else
                {
                    Console.WriteLine("serialized class already exists");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                stream.Close();
            }
        }
        public static clsPerson DeSerialize()
        {
            clsPerson person = null;
            XmlSerializer xmlserializer = new XmlSerializer(typeof(clsPerson));
            Stream stream = File.Open("person.xml", FileMode.Open);
            try
            {
                person = (clsPerson)xmlserializer.Deserialize(stream);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                stream.Close();
            }
            return person;
        }
    }
    class Program
    {
        Form1 frm;
        Program prog1;
        [STAThread()]
        static void Main(string[] args)
        {
            //Employee mp = null;
            //Employee mp = new Employee();
            //mp.EmpId = 100;
            //mp.EmpName = "aarif khan";
            //Stream stream = File.Open("employeeinfo.osl", FileMode.Create);
            //BinaryFormatter bformatter = new BinaryFormatter();
            //Console.WriteLine("writing employee information");
            //bformatter.Serialize(stream, mp);
            //stream.Close();
            //Stream stream = File.Open(Environment.CurrentDirectory+"\\EmployeeInfo.osl", FileMode.Open);
            //BinaryFormatter bformatter = new BinaryFormatter();
            //mp = (Employee)bformatter.Deserialize(stream);
            //Console.WriteLine("Employee Id {0}", mp.EmpId);
            //Console.WriteLine("Employee Name {0}", mp.EmpName);
            clsPerson person = new clsPerson();
            person.FirstName = "Aarif";
            person.LastName = "Khan";
            person.MI = "Hasan";
            clsPerson.Serialize(person);
            clsPerson person = clsPerson.DeSerialize();
            Console.WriteLine("firstname " + person.FirstName);
            Console.WriteLine("lastname " + person.LastName);
            Console.WriteLine("middle name " + person.MI);
            //Console.ReadLine();
            //Button btn = new Button();
            //btn.Text = "Serialize";
            //btn.Size = new System.Drawing.Size(100, 75);
            //SButton sbtn = clsBSerializer<SButton>.DeSerialize();
            ////sbtn.Text = "Change Text";
            ////sbtn.Location = new System.Drawing.Point(200, 100);
            //Program prog = new Program();
            //prog.frm = new Form1();
            //prog.frm.Controls.Add(btn);
            //prog.frm.Controls.Add(sbtn);
            ////clsBSerializer<SButton>.Serialize(sbtn);
            //System.Windows.Forms.Application.Run(prog.frm);
        }
    }
    [Serializable]
    public class SButton : Button, ISerializable
    {
        
        public SButton()
        {

        }
        public SButton(SerializationInfo info, StreamingContext context) : base()
        {
            this.Text = info.GetString("Text");
            this.Location = (System.Drawing.Point)info.GetValue("Location", typeof(System.Drawing.Point));
        }
        #region ISerializable Members

        public void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            info.AddValue("Text", this.Text);
            info.AddValue("Location", this.Location);
        }

        #endregion
    }
   
    class clsBSerializer<T>
    {
        public static void Serialize(T t)
        {
            Stream stream = File.Open("sbutton.bin", FileMode.Create);
            BinaryFormatter bformatter = new BinaryFormatter();
            bformatter.Serialize(stream, t);
            stream.Close();
        }
        public static T DeSerialize()
        {
            Stream stream = File.Open("sbutton.bin", FileMode.Open);
            BinaryFormatter bformatter = new BinaryFormatter();
            return (T)bformatter.Deserialize(stream);
        }
    }
    class clsSerializer<T>
    {
        public static void Serialize(T t)
        {
            XmlSerializer serialize = new XmlSerializer(t.GetType());
            Stream stream = File.Open("form1.xml", FileMode.Create);
            try
            {
                serialize.Serialize(stream, t);
                Console.WriteLine("Class serialize");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                stream.Close();
            }

        }
        public static T Deserialize()
        {
            T t = default(T);
            XmlSerializer serialize = new XmlSerializer(typeof(T));
            Stream stream = File.Open("form1.xml", FileMode.Open);
            try
            {
                t = (T)serialize.Deserialize(stream);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return t;
        }
    }
   
   
}
