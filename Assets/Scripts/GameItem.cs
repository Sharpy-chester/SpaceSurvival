using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[CreateAssetMenu(fileName = "GameItem", menuName = "Items/GameItem")]
public class GameItem : ScriptableObject
{
    public string itemName;
    public string description;
    public Sprite icon;
}
