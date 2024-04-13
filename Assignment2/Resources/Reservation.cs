using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Assignment2.Resources;

namespace Assignment2.Resources
{
	public class Reservation
	{
		private string reservationCode;
		public string ReservationCode { get { return reservationCode; } }
		private string flightCode;
		public string FlightCode { get { return flightCode; } }
		private string airlineName;
		public string AirlineName { get { return airlineName; } }
		private double cost;
		public double Cost { get { return cost; } }
		private string name;
		private string weekday;
		public string Weekday { get { return weekday; } }
		private string time;
		public string Time { get { return time; } }
		public string Name { get { return name; } set { name = value; } }
		private string citizenship;
		public string Citizenship { get { return citizenship; } set { citizenship = value; } }
		private bool isActive;
		public bool IsActive { get; set; }

		private void GenerateResCode() 
		{	
			reservationCode = "";
			Random rand = new Random();
			int numLength = 4;
			int randValue;
			char letter;
			randValue = rand.Next(0, 26);
			letter = Convert.ToChar(randValue + 65);
			reservationCode += letter;
			for (int i = 0; i < numLength; i++)
			{
				randValue = rand.Next(0, 9);
				reservationCode += randValue;
			}
		}

		public Reservation() { }
		public Reservation(Flight flight, string name, string citizenship)
		{
			flightCode = flight.FlightCode;
			airlineName = flight.AirlineName;
			cost = flight.Cost;
			weekday = flight.Weekday;
			time = flight.Time;
			this.name = name;
			this.citizenship = citizenship;
			this.isActive = true;
			GenerateResCode();
		}

		public override string ToString()
		{
			return $"{reservationCode} - {airlineName}- {name} -{String.Format("${0:0.00}", cost)} - {time}, {weekday}";
		}
	}
}
