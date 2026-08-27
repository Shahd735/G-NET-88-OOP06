using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_9_OOP_6
{
    public abstract partial class Shipment
    {
        protected string _trackingStatus = "Ready";

        partial void OnTrackingStatusChanged(string newStatus);
        public void UpdateTrackingStatus(string newStatus)
        {
            _trackingStatus = newStatus;

            OnTrackingStatusChanged(newStatus);
        }
        public virtual string GetTrackingStatus()
        {
            return $"Shipment {TrackingCode} is {_trackingStatus}";
        }
    }
}
