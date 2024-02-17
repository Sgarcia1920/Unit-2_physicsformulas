
using System.Drawing;

namespace Unit_2_physicsformulas
{
	internal class Formula_1
	{
		
		private double mass;
		//properties 
		public double Mass
		{
			get { return mass; }
			set { mass = value; }
		}
		private double acceleration;

		public double Acceleration
		{
			get { return acceleration; }
			set { acceleration = value; }
		}

		//constructor
		public Formula_1()
		{
			mass = 0;
			acceleration = 0;
		}
		public Formula_1(double m, double a )
		{
			this.mass = m;
			this.acceleration = a;
		}

		public double CalculateForce()
		{
			return mass * acceleration;
		}

	}
}
