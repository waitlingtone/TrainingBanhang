using Lambda.BusinessObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Lambda.CoreService
{
    [DataContract]
    public enum AcknowledgeType
    {
        [EnumMember]
        Failure = 0,
        [EnumMember]
        Success = 1
    }
    [DataContract]
    public class Response
    {
        public Response() { }
        public Response(string correlationId)
        {
            CorrelationId = correlationId;
        }

        [DataMember]
        public AcknowledgeType Acknowledge = AcknowledgeType.Success;

        [DataMember]
        public string CorrelationId;

        [DataMember]
        public string Message;

        /// <summary>
        /// Reservation number issued by the web service. Used in long running requests. 
        /// Also sometimes referred to as Correlation Id. This number is a way for both the client
        /// and web service to keep track of long running requests (for example, a request 
        /// to make a reservation for a airplane flight).
        /// </summary>
        [DataMember]
        public string ReservationId;

        /// <summary>
        /// Date when reservation number expires. 
        /// </summary>
        [DataMember]
        public DateTime ReservationExpires;

        /// <summary>
        /// Version number (in major.minor format) of currently executing web service. 
        /// Used to offer a level of understanding (related to compatibility issues) between
        /// the client and the web service as the web services evolve over time. 
        /// Ebay.com uses this in their API.
        /// </summary>
        [DataMember]
        public string Version =
            Assembly.GetExecutingAssembly().GetName().Version.Major + "." +
            Assembly.GetExecutingAssembly().GetName().Version.Minor;

        /// <summary>
        /// Build number of currently executing web service. Used as an indicator
        /// to client whether certain code fixes are included or not.
        /// Ebay.com uses this in their API.
        /// </summary>
        [DataMember]
        public string Build = Assembly.GetExecutingAssembly().GetName().Version.Build.ToString();


        /// <summary>
        /// Number of rows affected by "Create", "Update", or "Delete" action.
        /// </summary>
        [DataMember]
        public int RowsAffected = 0;


        [DataMember]
        public List<AutoObject> DataItems;
    }
}