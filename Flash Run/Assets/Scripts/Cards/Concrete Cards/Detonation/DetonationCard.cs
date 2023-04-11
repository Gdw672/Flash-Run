using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetonationCard : AbstractCard
{
    protected override void MoveCardStart()
    {
      _rigidbody.AddForce(_direction * 8, ForceMode.Impulse);
        StartCoroutine(_colldawnService.CooldawnForTime());
    }

    internal override void CardEffect()
    {
        
    }

    private void FixedUpdate()
    {
       // _rigidbody.velocity = transform.TransformDirection(_direction * 10);
    }

    private void OnCollisionEnter(Collision collision)
    {
        print("DET CARD ACTIVATE");
    }
}
