using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PC_Catalog
{
	class MainClass
	{
		public static void Main()
		{
			Console.OutputEncoding = Encoding.UTF8;

			//components graphics
			Components graphicsCardRadeon = new Components("XFX Radeon HD 5450 1GB 64-bit DDR3", 51.22m);
			Components graphicsCardASUS = new Components("ASUS HD6450-SL-1GD3-BRK", 75.00m);
			Components graphicsCardGigabyte = new Components("Gigabyte GV-N660WF2-2GD", 345.00m);

			//Processors
			Components processorIntel = new Components("Intel Celeron G1820", 64.09m);
			Components processorAMD = new Components("AMD A4-Series X2 4020", 78.00m);
			Components processorIntelCorei5 = new Components("Intel Core i5-4460 (6M Cache, up to 3.40 GHz)", 360.00m);

			//Motherboard
			Components motherboardASROCK = new Components("ASROCK AM1B-M", 50.00m);
			Components motherboardASROCK2 = new Components("ASROCK FM2A55M-VG3+", 81.00m);
			Components motherboardASUS = new Components("ASUS GRYPHON Z87", 263.00m);

			//Computers
			Computer computer1 = new Computer("Lenovo", new List<Components> { graphicsCardRadeon, processorIntel, motherboardASROCK });
			Computer computer2 = new Computer("ASUS", new List<Components> { graphicsCardASUS, processorAMD, motherboardASROCK2 });
			Computer computer3 = new Computer("ASUS", new List<Components> { graphicsCardGigabyte, processorIntelCorei5, motherboardASUS });

			List<Computer> computers = new List<Computer> { computer1, computer2, computer3 };

			computers.OrderByDescending(computer => computer.Price).ToList()
				.ForEach(computer => Console.WriteLine(computer.ToString()));
		}
	}
}
