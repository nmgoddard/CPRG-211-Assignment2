using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2.Resources
{
	internal class Flight
	{
		private string flightCode;
		public string FlightCode { get; }
		private string airlineName;
		public string AirlineName { get; }
		private string originAirport;
		public string OriginAirport { get; }
		private string destAirport;
		public string DestAirport { get; }
		private double cost;
		public double Cost { get; }
		private string weekday;
		public string Weekday { get; }
		private string time;
		public string Time { get; }
		public bool isSelected = false; 

		public Flight() {}
		public Flight(string flightCode, string airlineName, string originAirport, string destAirport, string weekday, string time, double cost) 
		{
			this.flightCode = flightCode;
			this.airlineName = airlineName;
			this.originAirport = originAirport;
			this.destAirport = destAirport;
			this.cost = cost;
			this.time = time;
			this.weekday = weekday;
		}

		public override string ToString() 
		{
			return $"{flightCode} - {airlineName}- {String.Format("${0:0.00}", cost)} - {time}, {weekday}";
		}
	}
}
