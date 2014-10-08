using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Computer
{
	private string name;
	private List<Components> components;

	public string Name
	{
		get{return this.name;}
		set
		{
			if (string.IsNullOrEmpty(value)) 
			{
				throw new ArgumentNullException ("Name can`t be null or empty!");
			}
			this.name = value;
		}
	}
	public List<Components> Components
	{
		get{return this.components;}
		set
		{
			if (value==null) 
			{
				throw new ArgumentException ("Components can not be null or empty!");
			}
			this.components = value;
		}
	}
	public decimal Price
	{
		get
		{
			return this.Components.Sum (a => a.Price);
		}
	}
	public Computer(string name,List<Components> components)
	{
		this.Name = name;
		this.Components = components;
	}
	public override string ToString ()
	{
		StringBuilder result = new StringBuilder ();
		result.AppendLine ("Computer Name: "+this.Name);
		foreach (var component in components) 
		{
			result.AppendLine (component.ToString());
		}

		return result.ToString ();
	}
}

