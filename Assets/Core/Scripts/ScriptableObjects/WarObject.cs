using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName ="New Object",menuName ="WarObject")]
public class WarObject : ScriptableObject
{
    public new string name;
    public string description;

    public Sprite artWork;
    public GameObject objectPrefab;

    public int durabilty;
}
