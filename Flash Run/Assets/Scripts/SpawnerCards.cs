using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Zenject;

public class SpawnerCards : MonoBehaviour
{
    [Inject] private ITypeOfCardDataBase typeOfCardDataBase;
     private GameObject prefab;

    private void Start()
    {
        var Card = typeOfCardDataBase.Card.Find(card => card.typeOfCard == ETypeOfCards.TestCard);
        prefab = Card.card;
    }

    private void Update()
    {
        if (Input.touchCount > 0)

        {
            if (Input.GetTouch(0).phase == TouchPhase.Began)
            {
                Ray ray = Camera.main.ScreenPointToRay(Input.GetTouch(0).position);
                print(ray.direction);

                //   Instantiate(prefab, ray.direction, Quaternion.identity);

                var prefabTest = Instantiate(prefab, new Vector3(ray.origin.x, ray.origin.y, ray.origin.z), Quaternion.identity);
                var Rigidbosdy = prefabTest.GetComponent<Rigidbody>();
                Rigidbosdy.AddForce(ray.direction * 10, ForceMode.Impulse);

            }
        }
    }
}
