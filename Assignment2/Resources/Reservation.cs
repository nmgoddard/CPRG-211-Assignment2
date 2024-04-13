using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2.Resources
{
	public class Reservation
	{
		private string reservationCode;
		public string ReservationCode { get; }
		private string flightCode;
		public string FlightCode { get; }
		private string airlineName;
		public string AirlineName { get; }
		private double cost;
		public double Cost { get; }
		private string name;
		public string Name { get; set; }
		private string citizenship;
		public string Citizenship { get; set; }
		private bool isActive;
		public bool IsActive { get; set; }
	}
}
