using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorTools
{
    public class Image
    {
        public class Fade
        {
            public static IEnumerator In (UnityEngine.UI.Image image, float changeRate)
            {
                while (image.color.a < 1)
                {
                    image.color += new UnityEngine.Color (0, 0, 0, changeRate) * Time.deltaTime;

                    yield return null;
                }
            }

            public static IEnumerator Out (UnityEngine.UI.Image image, float changeRate)
            {
                while (image.color.a > 0)
                {
                    image.color -= new UnityEngine.Color (0, 0, 0, changeRate) * Time.deltaTime;

                    yield return null;
                }
            }

            public static IEnumerator To (UnityEngine.UI.Image image, float targetAplha, float changeRate)
            {
                float direction = Mathf.Sign (image.color.a - targetAplha);

                float difference = image.color.a - targetAplha;

                while (difference / difference > 0.05f)
                {
                    image.color += new UnityEngine.Color (0, 0, 0, changeRate * direction) * Time.deltaTime;

                    difference = image.color.a - targetAplha;

                    yield return null;
                }

                image.color = new UnityEngine.Color (image.color.r, image.color.g, image.color.b, targetAplha);
            }
        }

        public class Colors
        {
            public static void Swap (UnityEngine.UI.Image image, Color color)
            {
                image.color = color;
            }

            public static void Alter (UnityEngine.UI.Image image, Color alteration)
            {
                image.color += alteration;
            }
        }
    }

    public class Sprite
    {
        public class Fade
        {
            public static IEnumerator In (SpriteRenderer spriteRenderer, float changeRate)
            {
                while (spriteRenderer.color.a < 1)
                {
                    spriteRenderer.color += new UnityEngine.Color (0, 0, 0, changeRate) * Time.deltaTime;

                    yield return null;
                }
            }

            public static IEnumerator Out (SpriteRenderer spriteRenderer, float changeRate)
            {
                while (spriteRenderer.color.a > 0)
                {
                    spriteRenderer.color -= new UnityEngine.Color (0, 0, 0, changeRate) * Time.deltaTime;

                    yield return null;
                }
            }

            public static IEnumerator To (SpriteRenderer spriteRenderer, float targetAplha, float changeRate)
            {
                float direction = Mathf.Sign (spriteRenderer.color.a - targetAplha);

                float difference = spriteRenderer.color.a - targetAplha;

                while (difference / difference > 0.05f)
                {
                    spriteRenderer.color += new UnityEngine.Color (0, 0, 0, changeRate * direction) * Time.deltaTime;

                    difference = spriteRenderer.color.a - targetAplha;

                    yield return null;
                }

                spriteRenderer.color = new UnityEngine.Color (spriteRenderer.color.r, spriteRenderer.color.g, spriteRenderer.color.b, targetAplha);
            }
        }

        public class Colors
        {
            public static void Swap (SpriteRenderer spriteRenderer, Color color)
            {
                spriteRenderer.color = color;
            }

            public static void Alter (SpriteRenderer spriteRenderer, Color alteration)
            {
                spriteRenderer.color += alteration;
            }
        }
    }

    public class Texts
    {
        public class Fade
        {
            public static IEnumerator In (UnityEngine.UI.Text text, float changeRate)
            {
                while (text.color.a < 1)
                {
                    text.color += new UnityEngine.Color (0, 0, 0, changeRate) * Time.deltaTime;

                    yield return null;
                }
            }

            public static IEnumerator Out (UnityEngine.UI.Text text, float changeRate)
            {
                while (text.color.a > 0)
                {
                    text.color -= new UnityEngine.Color (0, 0, 0, changeRate) * Time.deltaTime;

                    yield return null;
                }
            }

            public static IEnumerator To (UnityEngine.UI.Text text, float targetAplha, float changeRate)
            {
                float direction = Mathf.Sign (text.color.a - targetAplha);

                float difference = text.color.a - targetAplha;

                while (difference / difference > 0.05f)
                {
                    text.color += new UnityEngine.Color (0, 0, 0, changeRate * direction) * Time.deltaTime;

                    difference = text.color.a - targetAplha;

                    yield return null;
                }

                text.color = new UnityEngine.Color (text.color.r, text.color.g, text.color.b, targetAplha);
            }
        }

        public class Colors
        {
            public static void Swap (UnityEngine.UI.Text text, Color color)
            {
                text.color = color;
            }

            public static void Alter (UnityEngine.UI.Text text, Color alteration)
            {
                text.color += alteration;
            }
        }
    }
}
