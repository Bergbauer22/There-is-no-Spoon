using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LöffelSpawner : MonoBehaviour
{
    public GameObject objectToSpawn; //Variable zum Speichern des zu spawnenden Objekts
    public float minInterval = 1.0f; //Variable zum Speichern des minimalen Spawn-Intervalls
    public float maxInterval = 3.0f; //Variable zum Speichern des maximalen Spawn-Intervalls
    public Vector3 minPosition; //Variable zum Speichern der minimalen Spawn-Position
    public Vector3 maxPosition; //Variable zum Speichern der maximalen Spawn-Position

    // Start is called before the first frame update
    void Start()
    {
        float randomInterval = Random.Range(minInterval, maxInterval); 
        InvokeRepeating("SpawnObject", 0, randomInterval);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void SpawnObject()


    {
        Vector3 randomPosition = new Vector3(Random.Range(minPosition.x, maxPosition.x), Random.Range(minPosition.y, maxPosition.y),Random.Range(minPosition.z, maxPosition.z)); //Generieren der zufälligen Spawn-Position
        Instantiate(objectToSpawn, randomPosition, Quaternion.identity); 
    }
}
