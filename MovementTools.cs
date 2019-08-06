using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementTools
{
    public class Velocity : MonoBehaviour
    {
        public static void Move_X (Rigidbody2D rb2d, int direction, int speed)
        {
            rb2d.velocity = new Vector2 (direction * speed, 0) * Time.deltaTime;
        }

        public static void Stop_X (Rigidbody2D rb2d)
        {
            rb2d.velocity = new Vector2 (0, rb2d.velocity.y);
        }
    }

    public class Translate : MonoBehaviour
    {
        public static void Move_X (Transform trans, int direction, int speed)
        {
            trans.Translate (new Vector2 (direction * speed, 0) * Time.deltaTime);
        }

        public static void Move_Y (Transform trans, int direction, int speed)
        {
            trans.Translate (new Vector2 (0, direction * speed) * Time.deltaTime);
        }

        public static void Move_XY (Transform trans, int directionX, int directionY, int speed)
        {
            trans.Translate (new Vector2 (directionX, directionY) * speed * Time.deltaTime);
        }
    }
}
