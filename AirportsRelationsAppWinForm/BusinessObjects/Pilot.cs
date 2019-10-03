using System;
using System.Linq;
using System.Text;
using DevExpress.Xpo;

namespace AirportsRelationsApp.Module.BusinessObjects
{
    public class Pilot : XPObject
    {
        private string pilotName;
        private Airport airport;

        public Pilot(Session session) : base(session) { }

        [Size(4096)]
        //[RuleRequiredField]
        public string PilotName
        {
            get { return pilotName; }
            set { SetPropertyValue("PilotName", ref pilotName, value); }
        }
        [Association("Airport-Pilots")]
        public Airport Airport
        {
            get { return airport; }
            set { SetPropertyValue<Airport>("Airport", ref airport, value); }
        }
        [Association("Pilot-Plane")]
        public XPCollection<Plane> Planes
        {
            get { return GetCollection<Plane>("Planes"); }
        }

        public override void AfterConstruction()
        {
            base.AfterConstruction();            
        }
    }
}