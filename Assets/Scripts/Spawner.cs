using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject prefab;
    public float buf2;
    public void Spawn()
    {      
        if (buf2 == 0)
            buf2 = 1f;
        StartCoroutine(Wait());
    }
    IEnumerator Wait()
    {
 
        yield return new WaitForSeconds(buf2);
        SpawnCube();

    }
    public void SpawnCube()
    {
        Instantiate(prefab, transform.position, transform.rotation);
    }
}
