using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DirtPile : MonoBehaviour
{
    public GameObject dirtPile;
    public float health = 5f;
    public float yScale = 2f;
    void Update () 
    {
        Debug.Log(yScale);
        if (health <= 0) 
        {
            if (yScale > 0) 
            {
                yScale -= 0.02f;
                transform.localScale += new Vector3(0f, -0.02f, 0f);
            } else
            {
                Destroy(transform.gameObject);
            }
        } else 
        {
            if (yScale < 2) 
            {
                yScale += 0.01f;
                transform.localScale += new Vector3(0f, 0.01f, 0f);
            }
        }
    }
}
