using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Speed : MonoBehaviour
{
    public TMP_InputField speed;
    public GameObject prefab;

    public void chagnespeed()
    {
        int buf = int.Parse(speed.text);
        prefab.GetComponent<MoveObject>().speed = buf;
    }
}
