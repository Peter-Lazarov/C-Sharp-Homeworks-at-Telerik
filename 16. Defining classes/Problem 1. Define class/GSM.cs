using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Define_class
{
    public class GSM
    {
        //Define a class that holds information about a mobile phone device: model, manufacturer,
        //price, owner, battery characteristics (model, hours idle and hours talk) and display 
        //characteristics (size and number of colors).
        //Define 3 separate classes (class GSM holding instances of the classes Battery and Display).

        string model;
        string manufacturer;
        int price;
        string owner;
        Battery currentBattery = new Battery();
        Display currentDisplay = new Display();

        //For problem 9
        //Add a property CallHistory in the GSM class to hold a list of the performed calls.
        //Try to use the system class List<Call>.
        public static List<Call> History;
        static GSM()
        {
            History = new List<Call>();
        }

        public static void AddCalls(string date, string time, int number, string duration)
        {
            Call.AddCall(date, time, number, duration);
            //GSM.History.Add(this);
        }
        public static void DeleteCalls(int position)
        {
            History.RemoveAt(position);
        }

        public GSM(string modelGSM, string manufacturerofGSM)
        {
            this.model = modelGSM;
            this.manufacturer = manufacturerofGSM;
        }
        public GSM(string modelGSM, string manufacturerofGSM, int priceGSM, string ownerGSM)
            : this(modelGSM, manufacturerofGSM)
        {
            this.price = priceGSM;
            this.owner = ownerGSM;
        }
        public GSM(string modelGSM, string manufacturerofGSM, int priceGSM, string ownerGSM,
            int bateryIdle, int bateryTalk, string bateryModel, double displaySize, long displayColors)
            : this(modelGSM, manufacturerofGSM, priceGSM, ownerGSM)
        {
            this.price = priceGSM;
            this.owner = ownerGSM;
            currentBattery.HoursIdle = bateryIdle;
            currentBattery.HoursTalk = bateryTalk;
            currentBattery.BatteryModel = bateryModel;

            currentDisplay.DisplaySize = displaySize;
            currentDisplay.DisplayColors = displayColors;
        }
        public string Model
        {
            get
            {
                return this.model;
            }
            set
            {
                this.model = value;
            }
        }
        public string Manufacturer
        {
            get
            {
                return this.manufacturer;
            }
            set
            {
                this.manufacturer = value;
            }
        }
        public int Price
        {
            get 
            {
                return this.price;
            }
            set
            {
                this.price = value;
            }
        }
        public string Owner
        {
            get
            {
                return this.owner;
            }
            set
            {
                this.owner = value;
            }
        }
        public int BatteryHoursIdle
        {
            get
            {
                return this.currentBattery.HoursIdle;
            }
            set
            {
                this.currentBattery.HoursIdle = value;
            }
        }
        public int BatteryHoursTalk
        {
            get
            {
                return this.currentBattery.HoursTalk;
            }
            set
            {
                this.currentBattery.HoursTalk = value;
            }
        }
        public string BatteryModel
        {
            get
            {
                return this.currentBattery.BatteryModel;
            }
            set
            {
                this.currentBattery.BatteryModel = value;
            }
        }

        public double DisplaySize
        {
            get
            {
                return this.currentDisplay.DisplaySize;
            }
            set
            {
                this.currentDisplay.DisplaySize = value;
            }
        }

        public long DisplayColors
        {
            get
            {
                return this.currentDisplay.DisplayColors;
            }
            set
            {
                this.currentDisplay.DisplayColors = value;
            }
        }

        public override string ToString()
        {
            return string.Format("{0} {1} {2} {3} \n\r{4} {5} \n\r{6} {7}", this.Manufacturer, this.Model, this.Price, this.Owner, 
                this.currentBattery.BatteryModel, this.currentBattery.HoursIdle, this.currentBattery.HoursTalk,
                this.currentDisplay.DisplaySize, this.currentDisplay.DisplayColors);
        }

        public static string IPhone4s
        {
            get
            {
                return string.Format("Apple Iphone4S 1200 Gosho \n\rIbattery 8 2 \n\r4.5 1024");
            }
        }

        public static string CallSum()
        {
            double price = 0;
            double forminute = 0.37;
            DateTime sum = new DateTime();
            DateTime currentduration = new DateTime();
            foreach (var item in GSM.History)
            {
                currentduration = ToTime(item.Duration);
                sum = sum.Add(currentduration.TimeOfDay);
            }
            price = sum.Minute * forminute;
            return string.Format("All phone callings is {0} and cost {1}",sum.TimeOfDay.ToString() , price.ToString());
        }
        public static void DeleteLongestCall()
        {
            DateTime current = new DateTime();
            DateTime max = new DateTime();
            int position = 0;
            int currentposition = 0;
            foreach (var item in GSM.History)
            {
                current = ToTime(item.Duration);
                if (current.TimeOfDay > max.TimeOfDay)
                {
                    max = current;
                    position = currentposition;
                }
                currentposition++;
            }
            GSM.DeleteCalls(position);
        }
        private static DateTime ToTime(string timein)
        {
            string format = "HH:mm:ss";

            //HH:mm:ss
            DateTime time = new DateTime();
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
    }
}
