//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace InterSessions.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Event
    {
        public long EventID { get; set; }
        public string EventName { get; set; }
        public Nullable<System.DateTime> EventTime { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
        public string LocationVenue { get; set; }
        public string Teachers { get; set; }
        public string Sponsors { get; set; }
        public string Description { get; set; }
    }
}
