using System.Collections;
using UnityEngine;

public class ObjectSpawner : MonoBehaviour
{
    public GameObject water;
    public GameObject salt;
    float spawnTime;
    float location;
    int which;

    void Start()
    {
        Invoke("spawn", 0.0f);
    }
    //Instantiate(water, new Vector3(location, 5, 0), Quaternion.identity);
    void spawn()
    {
        spawnTime = Random.Range(0.0f, 0.5f);
        location = Random.Range(-8.4f, 8.4f);
        which = Random.Range(0, 2);

        if (which == 0)
        {
            Instantiate(water, new Vector3(location, 6, 0), Quaternion.identity);
        }
        else
        {
            Instantiate(salt, new Vector3(location, 6, 0), Quaternion.identity);
        }

        Invoke("spawn", spawnTime);
    }

}
