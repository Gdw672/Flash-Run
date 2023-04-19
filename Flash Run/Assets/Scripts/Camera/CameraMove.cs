using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
public class CameraMove : MonoBehaviour
{
    void Start()
    {
        gameObject.transform.DOLocalMoveZ(80, 80);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
