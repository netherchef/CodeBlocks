using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementTools
{
    public class Velocity
    {
        public static void Move_X (Rigidbody2D rb2d, int direction, float speed)
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
        public static void Move_X (Transform trans, int direction, float speed)
        {
            trans.Translate (new Vector2 (direction * speed, 0) * Time.deltaTime);
        }

        public static void Move_Y (Transform trans, int direction, float speed)
        {
            trans.Translate (new Vector2 (0, direction * speed) * Time.deltaTime);
        }

        public static void Move_XY (Transform trans, int directionX, int directionY, float speed)
        {
            trans.Translate (new Vector2 (directionX, directionY) * speed * Time.deltaTime);
        }
    }
}
