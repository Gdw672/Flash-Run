using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RocketCollision : MonoBehaviour
{
    [SerializeField] private RocketCard _rocketCard;

    private void OnCollisionEnter(Collision collision)
    {
        _rocketCard.CardEffect();
    }
}
