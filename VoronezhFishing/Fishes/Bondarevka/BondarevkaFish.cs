using System;
using VoronezhFishing.Fishes;

namespace VoronezhFishing.Fishes.Bondarevka
{

	public class Plotva : Fish
	{
		static double lowWeight = 50.0; // нижний предел веса рыбы (граммы)
		static double highWeight = 800.0; // верхний предел веса рыбы (граммы)
		public double Weight { get; } = GetFishWeight(lowWeight, highWeight); // вес рыбы
		public bool IsPredator { get; } = false; // параметр определения хищника
		public string Name { get; } = "Плотва"; // название вида рыба
		public DateTime CatchingTime { get; } //

		public override void Catched()
		{
			throw new NotImplementedException();
		}
	}

	public class Shyuka : Fish
	{
		static double lowWeight = 500.0; // нижний предел веса рыбы (граммы)
		static double highWeight = 10000.0; // верхний предел веса рыбы (граммы)
		public double Weight { get; } = GetFishWeight(lowWeight, highWeight); // вес рыбы
		public bool IsPredator { get; } = true; // параметр определения хищника
		public string Name { get; } = "Щука"; // название вида рыба
		public DateTime CatchingTime { get; } //

		public override void Catched()
		{
			throw new NotImplementedException();
		}
	}
}
