using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Define_class
{
    public enum batteryType
    {
        [Description("LiIon")]
        LiIon, NiMH, NiCd
    }
    class Battery
    {
        string model;
        int hoursIdle;
        int hoursTalk;

        public Battery()
        {
        }
        public Battery(string batteryModel, int batteryIdle, int batteryTalk)
        {

        }
        public string BatteryModel
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
        public int HoursIdle
        {
            get
            {
                return this.hoursIdle;
            }
            set
            {
                this.hoursIdle = value;
            }
        }
        public int HoursTalk
        {
            get
            {
                return this.hoursTalk;
            }
            set
            {
                this.hoursTalk = value;
            }
        }
    }
}
