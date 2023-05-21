using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

[CreateAssetMenu(fileName = "ScriptableObject", order = 0)]
public class ObstructionsDataBase : ScriptableObject, IObstructionsDataBase
{
    [SerializeField] public List<Obstruction> obstructions;
    public List<Obstruction> Obstructions => obstructions;
}
[Serializable]
public class Obstruction
{
    public GameObject prefab;
    public ETypeOfObstruction typeOfObstruction;
}

public enum ETypeOfObstruction
{
    TestObst,
    Move
}

public interface IObstructionsDataBase
{
    List<Obstruction> Obstructions { get; }
}

