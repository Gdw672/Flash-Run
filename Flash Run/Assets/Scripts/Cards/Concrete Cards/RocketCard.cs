using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RocketCard : AbstractCard
{
    public override void CardEffect()
    {
        var rigidbody = GetComponent<Rigidbody>();
        rigidbody.AddForce(_direction * 20, ForceMode.Impulse);
        StartCoroutine(_colldawnService.CooldawnForTime());
      
    }

    private void FixedUpdate()
    {
        if(Input.touchCount > 0)
        {
        }
    }
}

