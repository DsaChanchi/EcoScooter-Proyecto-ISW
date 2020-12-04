using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcoScooter.Entities
{
    public partial class TrackPoint
    {
        public TrackPoint()
        {


        }
        public TrackPoint(Double batteryLevel, Double latitude, Double longitude, Double speed, DateTime timeStamp):this() 
        {
            BatteryLevel = batteryLevel;
            Latitude = latitude;
            Longitude = longitude;
            Speed = speed;
            Timestamp = timeStamp;
        }

    }
}
