using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Zenject;

public class SpawnerCards : MonoBehaviour
{
    [Inject] private ITypeOfCardDataBase _typeOfCardDataBase;
    [Inject] private ICardGeneratorService _cardGeneratorService;
    internal Card[] cards;
    int test = 0;

    private void Start()
    {
          var x = _cardGeneratorService.GenerateStartKit(_typeOfCardDataBase.Card, 10);
        cards = x.ToArray();
    }

    private void Update()
    {
        if (Input.touchCount > 0)

        {
            if (Input.GetTouch(0).phase == TouchPhase.Began)
            {
                Ray ray = Camera.main.ScreenPointToRay(Input.GetTouch(0).position);

             
                var prefabTest = Instantiate(cards[test].card, new Vector3(ray.origin.x, ray.origin.y, ray.origin.z), Quaternion.identity);
                var Rigidbosdy = prefabTest.GetComponent<Rigidbody>();
                Rigidbosdy.AddForce(ray.direction * 10, ForceMode.Impulse);
                test++;

            }
        }
    }

    public GameObject GetCard(ETypeOfCards eTypeOfCards)
    {
        var Card = _typeOfCardDataBase.Card.Find(card => card.typeOfCard == eTypeOfCards);
        return Card.card;
    }
}
