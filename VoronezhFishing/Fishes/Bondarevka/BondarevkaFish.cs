using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VoronezhFishing.Fishes.Bondarevka
{
	abstract public class BondarevkaFish
	{
		public double Weight { get; set; }
		public bool IsPredator { get; set; }
		public string Name { get; }
		public DateTime CatchingTime { get;}

		public abstract void Catched();
	}

	public class Plotva : BondarevkaFish
	{
		public override void Catched()
		{
			
		}
	}
}
