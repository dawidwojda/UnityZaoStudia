using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class Zadanie_1 : MonoBehaviour
{
    List<Vector3> positions = new List<Vector3>();
    public float delay = 3.0f;
    public int objectCounter = 8;
    public GameObject block;
    public Material[] materials;
    public GameObject floor;

    void Start()
    {
        Bounds floorBounds = floor.GetComponent<Renderer>().bounds;

        List<int> pozycje_x = new List<int>(Enumerable.Range(0, 20).OrderBy(x => Guid.NewGuid()).Take(objectCounter));
        List<int> pozycje_z = new List<int>(Enumerable.Range(0, 20).OrderBy(x => Guid.NewGuid()).Take(objectCounter));

        for (int i = 0; i < objectCounter; i++)
        {
            float randomX = UnityEngine.Random.Range(floorBounds.min.x, floorBounds.max.x);
            float randomZ = UnityEngine.Random.Range(floorBounds.min.z, floorBounds.max.z);
            positions.Add(new Vector3(randomX, floorBounds.max.y, randomZ));
        }

        StartCoroutine(GenerateObject());
    }

    IEnumerator GenerateObject()
    {
        foreach (Vector3 position in positions)
        {
            GameObject CreateCube = Instantiate(block, position, Quaternion.identity);
            CreateCube.GetComponent<Renderer>().material = materials[UnityEngine.Random.Range(0, materials.Length)];
            yield return new WaitForSeconds(delay);
        }
    }
}
