using System.Collections;
using UnityEngine;

public class MovementTools
{
    public class Velocity
    {
        public static void Move_X (Rigidbody2D rb2d, float direction, float speed)
        {
            rb2d.velocity = new Vector2 (direction * speed, 0) * Time.deltaTime;
        }

        public static void Stop_X (Rigidbody2D rb2d)
        {
            rb2d.velocity = new Vector2 (0, rb2d.velocity.y);
        }
    }

	public class Translate
	{
		public static void Move_X (Transform trans, float direction, float speed)
		{
			trans.Translate (new Vector2 (direction * speed, 0) * Time.deltaTime);
		}

		public static void Move_Y (Transform trans, float direction, float speed)
		{
			trans.Translate (new Vector2 (0, direction * speed) * Time.deltaTime);
		}

		public static void Move_XY (Transform trans, float directionX, float directionY, float speed)
		{
			trans.Translate (new Vector2 (directionX, directionY) * speed * Time.deltaTime);
		}
	}

    public class Shift
    {
        public static IEnumerator X_To (float targetPos, Transform targetObject, float speed)
        {
            while (Mathf.Abs (targetObject.position.x - targetPos) > 0.1f)
            {
                float direction = -(Mathf.Sign (targetObject.position.x - targetPos));

                Translate.Move_X (targetObject, direction, speed);

                yield return null;
            }

            targetObject.position = new Vector3 (targetPos, targetObject.position.y, targetObject.position.z);
        }

        public static IEnumerator Y_To (float targetPos, Transform targetObject, float speed)
        {
            while (Mathf.Abs (targetObject.position.y - targetPos) > 0.1f)
            {
                float direction = -(Mathf.Sign (targetObject.position.y - targetPos));

                Translate.Move_Y (targetObject, direction, speed);

                yield return null;
            }

            targetObject.position = new Vector3 (targetObject.position.x, targetPos, targetObject.position.z);
        }
    }
}
