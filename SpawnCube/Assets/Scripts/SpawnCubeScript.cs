using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnCubeScript : MonoBehaviour
{
    [SerializeField]
    public GameObject cube;

    private float nextSpawn = 0.0f;

    void Update()
    {
        SpawnCube();
    }

    private void SpawnCube()
    {
        if (Time.time > nextSpawn)
        {
            nextSpawn = Time.time + getSpawnRateValue();

            Instantiate(cube, transform.position, Quaternion.identity);
        }
    }

    private float getSpawnRateValue()
    {
        if (PlayerPrefs.HasKey("SpawnRate"))
        {
            return PlayerPrefs.GetFloat("SpawnRate");
        }
        else return 0f;
    }
}
