using DevExpress.Xpo;
using DevExpress.Persistent.Validation;

namespace AirportsRelationsApp.Module.BusinessObjects
{
    public class Airport : XPObject
    {
        private string airportName;
        [RuleRequiredField]
        public string AirportName
        {
            get { return airportName; }
            set { SetPropertyValue<string>("AirportName", ref airportName, value); }
        }
        [Association("Airport-Pilots")]
        public XPCollection<Pilot> Pilots { get { return GetCollection<Pilot>("Pilots"); } }
        [Association("Airport-Planes")]
        public XPCollection<Plane> Planes { get { return GetCollection<Plane>("Planes"); } }

        public Airport(Session session) : base(session) { }

        public override void AfterConstruction()
        {
            base.AfterConstruction();            
        }        
    }



}