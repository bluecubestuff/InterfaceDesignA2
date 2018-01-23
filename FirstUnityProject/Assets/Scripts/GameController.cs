using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour {

    public int maxCount;
    public float spawnRate;
    public Vector3 spawnPosition;
    public Vector2 minAnchor, maxAnchor;
    public List<GameObject> listOfTiles;
    public GameObject canvas;
    public static int score;

    private float spawnTime;
    private GameObject newTile;
    private static List<GameObject> spawnedTiles;

    private void Start()
    {
        spawnTime = spawnRate;
        spawnedTiles = new List<GameObject>();
        score = 0;
    }

    private void Update()
    {
        if (spawnTime >= spawnRate)
        {
            if (spawnedTiles.Count <= maxCount)
            {
                //spawn a random tile
                newTile = Instantiate(listOfTiles[Random.Range(0, listOfTiles.Count)]);
                newTile.GetComponent<RectTransform>().position = new Vector3(spawnPosition.x, spawnPosition.y + canvas.GetComponent<RectTransform>().position.y, spawnPosition.z);
                newTile.GetComponent<RectTransform>().anchorMax = maxAnchor;
                newTile.GetComponent<RectTransform>().anchorMin = minAnchor;
                newTile.transform.SetParent(canvas.GetComponent<Transform>());
                spawnTime = 0;
                spawnedTiles.Add(newTile);
            }
        }
        spawnTime += Time.deltaTime;
    }

    public static void PopTiles(GameObject clicked)
    {
        if (!PauseScript.paused)
        {
            for (int i = 0; i < spawnedTiles.Count; ++i)
            {
                if (spawnedTiles[i].Equals(clicked))
                {
                    if (i < spawnedTiles.Count - 1)
                        GameController.RecursivePopTile(clicked, true, i + 1);
                    if (i > 0)
                        GameController.RecursivePopTile(clicked, false, i - 1);
                    spawnedTiles.Remove(clicked);
                    Destroy(clicked);
                    score += 1;
                }
            }
        }
    }

    private static void RecursivePopTile(GameObject go, bool side, int index)
    {
        if (side)
        {
            if (spawnedTiles[index].name == go.name)
            {
                if (index < spawnedTiles.Count - 1)
                    RecursivePopTile(go, side, index + 1);
                Destroy(spawnedTiles[index]);
                spawnedTiles.RemoveAt(index);
                score += 2;
            }
        }
        else
        {
            if (spawnedTiles[index].name == go.name)
            {
                GameObject temp = spawnedTiles[index];
                if (index > 0)
                    RecursivePopTile(go, side, index - 1);
                spawnedTiles.Remove(temp);
                Destroy(temp);
                score += 2;
            }
        }
    }
}
