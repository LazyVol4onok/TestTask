using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Distance : MonoBehaviour
{
    // Start is called before the first frame update
    public TMP_InputField distance;
    public GameObject prefab;

    public void chagnedistance()
    {
        int buf = int.Parse(distance.text);
        prefab.GetComponent<MoveObject>().distance = buf;
    }
    public void FixedUpdate()
    {

    }
}
