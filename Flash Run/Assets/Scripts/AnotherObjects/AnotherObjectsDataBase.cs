using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

[CreateAssetMenu(fileName = "ScriptableObject", order = 0)]
public class AnotherObjectsDataBase : ScriptableObject, IAnotherObjectsDataBase
{
    [SerializeField] private List<Object> objects;
    public List<Object> Objects => objects;
}

public enum ETypeOfAnotherObject
{
    EndOfLevel
} 

[Serializable]
public class Object
{
    public GameObject prefab;
    public ETypeOfAnotherObject typeOfAnotherObject;
}
public interface IAnotherObjectsDataBase
{
    List<Object> Objects { get; }
}