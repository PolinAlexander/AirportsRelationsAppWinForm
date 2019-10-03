using System;
using System.Linq;
using System.Text;
using DevExpress.Xpo;

namespace AirportsRelationsApp.Module.BusinessObjects
{
    public class Plane : XPObject
    {
        private string planeName;
        private Airport airport;

        public Plane(Session session) : base(session) { }
        [Size(4096)]
        //[RuleRequiredField]
        public string PlaneName
        {
            get { return planeName; }
            set
            {
                if (value.Length < 200) SetPropertyValue<string>("PlaneName", ref planeName, value);
                else
                {
                    SetPropertyValue<string>("PlaneName", ref planeName, null);
                    throw new ArgumentOutOfRangeException();
                }
            }
        }
        [Association("Airport-Planes")]
        public Airport Airport
        {
            get { return airport; }
            set { SetPropertyValue<Airport>("Airport", ref airport, value); }
        }
        [Association("Pilot-Plane")]
        public XPCollection<Pilot> Pilots
        {
            get { return GetCollection<Pilot>("Pilots"); }
        }
        public override void AfterConstruction()
        {
            base.AfterConstruction();
        }        
    }
}