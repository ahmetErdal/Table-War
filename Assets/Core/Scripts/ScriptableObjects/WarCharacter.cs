using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName ="New Character",menuName ="CharacterCard")]
public class WarCharacter : ScriptableObject
{
    public new string name;
    public string description;

    public Sprite artwork;
    public GameObject cardCharacterPrefab;
    public enum ClassType {close,middle,far,tower, wwall,castle }
    public ClassType type;

    public int upgradeLevel;
    public int attack;
    public int health;
    public int range;
    public int durabilty;
}
