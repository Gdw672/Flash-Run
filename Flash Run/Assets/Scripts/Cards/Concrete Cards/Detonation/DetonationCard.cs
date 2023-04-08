using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetonationCard : AbstractCard
{
    internal override void CardEffect()
    {
        var rigidbody = GetComponent<Rigidbody>();
        rigidbody.AddForce(_direction * 20, ForceMode.Impulse);
        StartCoroutine(_colldawnService.CooldawnForTime());
    }

    private void OnCollisionEnter(Collision collision)
    {
        print("DET CARD ACTIVATE");
    }
}
