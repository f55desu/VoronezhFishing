using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VoronezhFishing.Fishes
{
	abstract public class Fish
	{
		public static double GetFishWeight(double lowWeight, double highWeight) // метод случайного получения веса рыбы
		{
			double localWeight;
			Random rnd = new Random(DateTime.Now.Millisecond);
			localWeight = rnd.Next((int)lowWeight, (int)highWeight);
			if (localWeight >= 1000.0) // перевод в килограммы
			{
				localWeight /= 1000.0;
			}
			return localWeight;
		}
		public abstract void Catched();
	}
}
