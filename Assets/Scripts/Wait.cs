using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Wait : MonoBehaviour
{
    public TMP_InputField wait;
    public GameObject prefab;

    public void chagnewait()
    {
        int buf = int.Parse(wait.text);
        float buf2 = (float)buf;
        prefab.GetComponent<Spawner>().buf2 = buf;
    }
}
