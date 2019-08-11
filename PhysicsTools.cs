using UnityEngine;

public class PhysicsTools
{
	public class Gravity
	{
		public class Alter_Speed
		{
			public static void By_MinDistance (float currDist, float fullDist, float minDist, float fullSpeed, out float currSpeed_out, float minSpeed)
			{
				if (currDist > minDist)
				{
					Alter_Speed_Relative_Distance (currDist, fullDist, fullSpeed, out currSpeed_out);
				}
				else
				{
					currSpeed_out = minSpeed;
				}
			}

			public static void By_MinSpeed_And_MinDistance (float currDist, float fullDist, float minDist, float fullSpeed, in float currSpeed_in, out float currSpeed_out, float minSpeed)
			{
				if (currSpeed_in > minSpeed)
				{
					Alter_Speed_Relative_Distance (currDist, fullDist, fullSpeed, out currSpeed_out);
				}
				else if (currDist < minDist)
				{
					currSpeed_out = minSpeed;
				}
				else
				{
					Alter_Speed_Relative_Distance (currDist, fullDist, fullSpeed, out currSpeed_out);
				}
			}

			public static void Alter_Speed_Relative_Distance (float currDist, float fullDist, float fullSpeed, out float currSpeed)
			{
				if (currDist <= fullDist)
				{
					currSpeed = currDist / fullDist * fullSpeed;
				}
				else
				{
					currSpeed = fullSpeed;
				}
			}
		}
	}
}
