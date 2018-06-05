using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Define_class
{
    public class Call
    {
        string date;
        DateTime time;
        int phoneNumber;
        string duration;

        //public static List<Call> History;
        //static Call()
        //{
        //    History = new List<Call>();
        //}

        private string Datenow()
        {    
            string datein = DateTime.Now.ToString();
            string format = "dd.MM.yyyy";

            DateTime date = DateTime.Now;
            CultureInfo provider = new CultureInfo("bg-BG");//CultureInfo.InvariantCulture;

            try
            {
                date = DateTime.ParseExact(datein, format, provider);
            }
            catch (Exception)
            {
            }
            //date = date.Date;
            return date.ToString("d");
        }
        private DateTime Timenow()
        {
            string timein = DateTime.Now.ToString();
            string format = "HH:mm:ss";

            //HH:mm:ss
            DateTime time = DateTime.Now;
            CultureInfo provider = new CultureInfo("bg-BG");//CultureInfo.InvariantCulture;

            try
            {
                time = DateTime.ParseExact(timein, format, provider);
            }
            catch (Exception)
            {
            }
            return time;
        }
        //Create a class Call to hold a call performed through a GSM.
        //It should contain date, time, dialled phone number and duration (in seconds).

        public void Answer(int Number)
        {
            //sega.Date
            this.date = Datenow();
            this.time = Timenow();
            this.phoneNumber = Number;
        }
        public void Close()
        {
            this.duration = (Timenow() - this.time).ToString();
            this.duration = this.duration.Remove(8);
            //Call.History.Add(this);
            GSM.History.Add(this);
        }
        public string Date 
        {
            get
            {
                return this.date;
            }
        }
        public string Duration
        {
            get
            {
                return this.duration;
            }
        }
        public string Time
        {
            get
            {
                return this.time.ToString("T");
            }
        }
        public int PhoneNumber
        {
            get
            {
                return this.phoneNumber;
            }
        }

        public static void AddCall(string calldate, string calltime, int callnumber, string callduration)
        {
            Call current = new Call();
            current.date = calldate;
            current.time = DateTime.Parse(calltime);
            current.phoneNumber = callnumber;
            current.duration = callduration;
            GSM.History.Add(current);
        }
        //This is adding class instance to List from class property
        //public static List<Call> History;
        //static Call()
        //{
        //    History = new List<Call>();
        //}
        //public Call()
        //{
        //    Call.History.Add(this);
        //}
    }
}
