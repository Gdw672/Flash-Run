using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Zenject;
using System.Linq;

public class CardGeneratorService : ICardGeneratorService
{
    public List<Card> GenerateStartKit(List<Card> Card, int numOfCarts)
    {
        var array = Card.ToArray();
        List<Card> Cards = new List<Card>();
        for (int i = 0; i < numOfCarts; i++)
        {
            var number = GenerateRandomElements(array.Length);
            Cards.Add(array[number]);
        }
        return Cards;
    }

    private int GenerateRandomElements(int lenght) 
    {
        var element = Random.Range(0, lenght);
        return element;
    }

}

public interface ICardGeneratorService
{
    public List<Card> GenerateStartKit(List<Card> Card, int numOfCarts);
}
