using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rayo : MonoBehaviour
{
    

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        Vector3 forward = transform.TransformDirection(Vector3.forward) * Mathf.Infinity;
        Debug.DrawRay(transform.position, forward, Color.green);

        if(Input.GetButtonDown("Fire1"))
        {
            RaycastTest();
        }
    }

    void RaycastTest()
    {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;

        if (Physics.Raycast(ray, out hit, Mathf.Infinity))
        {
            if(hit.transform.gameObject.layer == 3)
            {
                Debug.Log(hit.transform.name);
            }

            else if(hit.transform.gameObject.layer == 6)
            {
                Debug.Log(hit.transform.name);
            }
        
            else if(hit.transform.gameObject.layer == 7)
            {
                Debug.Log(hit.transform.name);
            }
        }
        
    }
}
