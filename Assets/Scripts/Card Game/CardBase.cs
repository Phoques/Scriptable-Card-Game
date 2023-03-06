using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Variable;

[CreateAssetMenu(menuName = "Cards/Card", fileName = "New Card")]
public class CardBase : ScriptableObject
{
    //name
    public String name;

    //description
    public String description;

    //Icon
    public SpriteImage icon;

    //Background
    public SpriteImage background;

    //cost
    public Int cost;

    //attack
    public Int attackBase;

    //health
    public Int healthBase;
    




}
