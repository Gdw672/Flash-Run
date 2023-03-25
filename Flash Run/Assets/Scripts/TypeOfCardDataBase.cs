using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

[CreateAssetMenu(fileName = "ScriptableObject", order = 0)]
public class TypeOfCardDataBase : ScriptableObject, ITypeOfCardDataBase
{
    [SerializeField] public List<Card> card;
    public List<Card> Card => card;
}

public enum ETypeOfCards
{
    Rocket,
    Stone,
    MiniGame,
    ExplodingCard,
    BoostSpeed,
    TestCard
}

[Serializable]
public class Card
{
    public GameObject card;
    public ETypeOfCards typeOfCard;
}
internal interface ITypeOfCardDataBase
{
    List<Card> Card { get; }
}