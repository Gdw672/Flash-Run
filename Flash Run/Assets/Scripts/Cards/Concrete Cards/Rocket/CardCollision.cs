using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardCollision : MonoBehaviour
{
    [SerializeField] private AbstractCard card;

    private void OnCollisionEnter(Collision collision)
    {
        card.CardEffect();
    }
}
