using System;

public class Components
{
	private string name;
	private string details;
	private decimal price;

	public string Name
	{
		get { return this.name; }
		set
		{
			if (string.IsNullOrEmpty(value))
			{
				throw new ArgumentNullException("Name cannot be empty or null");
			}
			this.name = value;
		}
	}
	public string Details
	{
		get{return this.details;}
		set{this.details = value;}
	}
	public decimal Price
	{
		get{return this.price;}
		set
		{
			if (value < 0 ) 
			{
				throw new ArgumentOutOfRangeException ("Price can not be negativ!e");
			}
			this.price = value;
		}
	}
	public Components(string name,string details,decimal price)
	{
		this.Name = name;
		this.Details = details;
		this.Price = price;
	}
	public Components(string name,decimal price)
		:this(name,null,price)
	{
	}
	public override string ToString ()
	{
		string result = string.Format ("-Component: [name : {0}]",this.name);
		if (this.Details != null) 
		{
			result += " details: "+this.Details+" ";
		}
		result+="price: "+this.Price+" lv.";

		return result;
	}
}

