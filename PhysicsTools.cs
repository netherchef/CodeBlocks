using UnityEngine;

public class PhysicsTools
{
	public class Gravity
	{
		public static void AlterSpeed (float currDist, float fullDist, float moveSpeed, out float currSpeed)
		{
			currSpeed = currDist / fullDist * moveSpeed;
		}
	}
}
