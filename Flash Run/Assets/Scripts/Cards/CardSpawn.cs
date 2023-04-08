using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardSpawn : AbstractCard
{
    protected override void MoveCardStart()
    {
        var rigidbody = GetComponent<Rigidbody>();
        rigidbody.AddForce(_direction * 10, ForceMode.Impulse);
        StartCoroutine(_colldawnService.CooldawnForTime());
        transform.localEulerAngles = Vector3.zero;
    }

  
}
