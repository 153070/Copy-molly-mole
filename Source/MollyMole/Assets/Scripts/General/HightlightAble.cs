using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HightlightAble : MonoBehaviour
{
    public bool highLighted = false;
    void Update()
    {
        if (highLighted == true)
        {
            GetComponent<Renderer>().material.color = Color.red;
            highLighted = false;
        } else {
            GetComponent<Renderer>().material.color = Color.white;
        }
    }
}
