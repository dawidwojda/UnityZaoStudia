using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class CubeSpawner : MonoBehaviour
{
    public GameObject cubePrefab;
    public int TotalCubes = 10;
    public float cubeSize = 1f;

    private List<Vector3> BusyPositions = new List<Vector3>();

    void Start()
    {
        for (int i = 0; i < TotalCubes; i++)
        {
            Vector3 RandomRespawn = UniquePosition();
            BusyPositions.Add(RandomRespawn);
            Instantiate(cubePrefab, RandomRespawn, Quaternion.identity);
        }
    }

    Vector3 UniquePosition()
    {
        Vector3 RandomRespawn;
        do
        {
            RandomRespawn = new Vector3(
                Mathf.Floor(Random.Range(-4f, 4f)),
                cubeSize / 2,
                Mathf.Floor(Random.Range(-4f, 4f))
            );
        } while (BusyPositions.Contains(RandomRespawn));

        return RandomRespawn;
    }
}
