using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaptopShop
{
	public class Battery
	{
		private string type;
		private float hours;

		public string Type
		{
			get{return this.type;}
			set
			{
				if (string.IsNullOrEmpty (value)) 
				{
					throw new ArgumentNullException ("The battery can not be null or empty ");
				}
				this.type = value;
			}
		}
		public float Hours
		{
			get{return this.hours;}
			set
			{
				if (value<=0) 
				{
					throw new ArgumentOutOfRangeException ("Hours cannot be negative or 0!");
				}
				this.hours = value;
			}
		}
		public Battery(string type)
		{
			this.Type = type;
		}
		public Battery(string type,float hours)
			:this(type)
		{
			this.Hours = hours;
		}
		public override string ToString ()
		{
			StringBuilder batteryInfo = new StringBuilder ();
			batteryInfo.AppendLine ("Battery: "+this.Type);
			batteryInfo.AppendLine ("Battery Life : " + this.Hours + " hours");
			return batteryInfo.ToString ();
		}
	}
}

