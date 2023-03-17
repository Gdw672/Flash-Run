using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestTouch : MonoBehaviour
{
    void Update()
    {

     if(Input.touchCount > 0)

        {
            if(Input.GetTouch(0).phase == TouchPhase.Began)
            {
                Ray ray = Camera.main.ScreenPointToRay(Input.GetTouch(0).position);
                RaycastHit raycastHit;
                if (Physics.Raycast(ray, out raycastHit))
                {
                  print(  raycastHit.collider.gameObject.name);
                }
            }
        }
    }
}
