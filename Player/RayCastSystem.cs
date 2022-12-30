using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RayCastSystem : MonoBehaviour
{
    private Ray ray;
    private float distance = 2.5f;

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            CreateRayCast();
        }
    }

    void CreateRayCast()
    {
        ray = new Ray(transform.position, transform.forward);
        Debug.DrawRay(transform.position, transform.forward * distance, Color.green);

        RaycastHit hit;

        if (Physics.Raycast(ray, out hit, distance))
        {
            var activate = hit.collider.gameObject.GetComponent<ActivateAnswer>();
            if(activate)
            {
                activate.Activate();
            }

            var keyActivate = hit.collider.gameObject.GetComponent<KeyActivate>();
            if(keyActivate)
            {
                keyActivate.Activate();
            }             
        }
    }
}
