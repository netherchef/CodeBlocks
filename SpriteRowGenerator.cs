using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum SortingLayer { Foreground, Midground, Background }

[ExecuteInEditMode]
public class SpriteRowGenerator : MonoBehaviour
{
    [Header ("Sprite Configuration:")]
    public int spriteCount;
    public int spriteWidth;

    public Sprite[] sprites;

    [Header ("Color:")]
    public bool recolor;
    public Color color;

    [Header ("Sorting Layer:")]
    public bool resort;
    public SortingLayer sortingLayer;

    [Header ("Direction:")]
    public bool randomiseDirection;

    [Header ("Execute:")]
    public bool generate;

    private void Update ()
    {
        if (generate)
        {
            Generate ();

            generate = false;
        }
    }

    void Generate ()
    {
        for (int c = transform.childCount; c > 0; c--)
        {
            if (transform.GetChild (c - 1).CompareTag ("Generated Sprite"))
            {
                DestroyImmediate (transform.GetChild (c - 1).gameObject);
            }
        }

        int direction = 0;

        // Middle

        if (OddCount ()) SpawnSprite (new Vector3 (0, 0, 0));

        // Left

        direction = SpawnDirection (-spriteWidth);

        for (int queue = spriteCount / 2; queue > 0; queue--)
        {
            SpawnSprite (new Vector3 (direction, 0, 0));
            direction -= spriteWidth;
        }

        // Right

        direction = SpawnDirection (spriteWidth);

        for (int queue = spriteCount / 2; queue > 0; queue--)
        {
            SpawnSprite (new Vector3 (direction, 0, 0));
            direction += spriteWidth;
        }
    }

    bool OddCount ()
    {
        return spriteCount % 2 != 0;
    }

    int SpawnDirection (int width)
    {
        int d = 0;

        if (OddCount ())
            d = width;
        else
            d = width / 2;

        return d;
    }

    #region Spawn Sprite _______________________________________________________

    void SpawnSprite (Vector3 spawnLocation)
    {
        GameObject grass = new GameObject ("Grass Patch");
        grass.transform.parent = transform;
        grass.transform.position += spawnLocation;

        grass.AddComponent<SpriteRenderer> ();
        grass.GetComponent<SpriteRenderer> ().sprite = sprites[Random.Range (0, sprites.Length)];

        grass.tag = "Generated Sprite";

        if (recolor)
        {
            grass.GetComponent<SpriteRenderer> ().color = color;
        }

        if (resort)
        {
            grass.GetComponent<SpriteRenderer> ().sortingLayerName = TargetLayer (sortingLayer);
        }

        if (randomiseDirection)
        {
            grass.GetComponent<SpriteRenderer> ().flipX = Random.Range (0, 2) > 0;
        }
    }

    #endregion

    #region Sprite Sorting _____________________________________________________

    string TargetLayer (SortingLayer layer)
    {
        string s = "";

        switch (layer)
        {
            case SortingLayer.Foreground:
                s = "Foreground";
                break;

            case SortingLayer.Midground:
                s = "Midground";
                break;

            case SortingLayer.Background:
                s = "Background";
                break;
        }

        return s;
    }

    #endregion
}
