


using Unit_2_physicsformulas;

namespace Unit_2_physicsformulas
{
	internal class Program
	{
		public static void Main(string[] args)
		{
			//Program that calculates the force and weight 
			try
			{


				Console.WriteLine("Enter the mass(kg): ");
				double m = Convert.ToDouble(Console.ReadLine());
				Console.WriteLine("Enter the acceleration(m/s^2): ");
				double a = Convert.ToDouble(Console.ReadLine());

				//declare the instance with the constructor that has the parameters
				//of the date i askefd for
				Formula_1 exercise = new Formula_1(m, a);
				Formula_2 exercise_1 = new Formula_2();

				Console.WriteLine("Force(N): " + exercise.CalculateForce());
				Console.WriteLine("Weight: " + exercise_1.Calculateweight(m));
			}
			catch (Exception)
			{
				Console.WriteLine("A value was added incorrectly");
			}
			Console.ReadKey();

		}
		
	}
}

