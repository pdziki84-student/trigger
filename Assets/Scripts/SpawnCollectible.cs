using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnCollectible : MonoBehaviour
{
    private Terrain terrain; 
    private Vector3 terrainSize;
    private int numberOfBoxes = 100;

    public Transform box; 


    // Start is called before the first frame update
    void Start()
    {
        terrain = Terrain.FindObjectOfType<Terrain>();

        terrainSize = terrain.terrainData.size;

        for (int i = 0; i < numberOfBoxes; i++)
        {
            var x = Random.Range(0, terrainSize.x);
            var y = 0.5f;
            var z = Random.Range(0, terrainSize.z);

            var newPosition = new Vector3(x, y, z); 
            var newObject = Instantiate(box.gameObject, newPosition, Quaternion.identity, transform);
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}
