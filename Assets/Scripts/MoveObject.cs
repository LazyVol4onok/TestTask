using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System;

public class MoveObject : MonoBehaviour
{
    public GameObject spawner;
    public GameObject Prefab;
    public int distance;
    public int speed;
    public string dis;


    public void Start()
    {
        if (distance == 0)
            distance = 10;
        if (speed == 0)
            speed = 1;
    }

    private void FixedUpdate()
    {
        if (Prefab.transform.position.z != distance)
            Prefab.GetComponent<Rigidbody>().velocity = transform.forward * speed;
        if (Prefab.transform.position.z >= distance)
        {
            spawner = GameObject.Find("Spawner");
            spawner.GetComponent<Spawner>().Spawn();
            Destroy(Prefab);
        }
    }
}
