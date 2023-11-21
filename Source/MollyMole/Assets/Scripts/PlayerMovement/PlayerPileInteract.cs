using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerPileInteract : MonoBehaviour

    
{
    // Update is called once per frame
    void Update()
    {
        Ray ray = new Ray(transform.position, transform.forward);
        if (Physics.Raycast(ray, 1))
        {
            RaycastHit hit;
            if (Physics.Raycast(transform.position, transform.forward, out hit))
            {
                if (hit.transform.GetComponent<HightlightAble>().highLighted == false)
                {
                    hit.transform.GetComponent<HightlightAble>().highLighted = true;
                }

                if (Input.GetKeyDown(KeyCode.Mouse0)) 
                { 
                    if (hit.collider.tag == "DirtPiles") 
                    {
                        if (hit.transform.GetComponent<DirtPile>().health > 0)
                        {
                            hit.transform.GetComponent<DirtPile>().health -= 1f;
                            hit.transform.GetComponent<DirtPile>().yScale = 1.5f;
                            hit.transform.localScale = new Vector3(2f, 1.5f, 2f);
                        }
                    }
                }
            }
        } 
    }
}
