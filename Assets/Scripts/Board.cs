using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Board : MonoBehaviour
{
    public int width;
    public int height;
    public GameObject tilePrefab;
    public GameObject[] dots;
    public GameObject[, ] allDots;


    private BackgroundTile [,] allTile;
    // Start is called before the first frame update
    void Start()
    {
        allTile = new BackgroundTile[width, height];
        allDots = new GameObject[width, height];
        SetUp();
    }

    private void SetUp()
    { 
        for (int i = 0; i < width; i++)
        {
            for (int j = 0; j < height; j++)
            {
                Vector2 tempPosition = new Vector2(i, j);
                GameObject backgroudTile = Instantiate(tilePrefab,tempPosition , Quaternion.identity) as GameObject;
                backgroudTile.transform.parent = this.transform;
                backgroudTile.name = $"({j},{j})";

                int dotToUse = Random.Range(0, dots.Length);
                GameObject dot = Instantiate(dots[dotToUse], tempPosition, Quaternion.identity);
                dot.transform.parent = this.transform;
                dot.name = $"({j},{j})";

                allDots[i, j] = dot;
            }
        }
    }
} 
