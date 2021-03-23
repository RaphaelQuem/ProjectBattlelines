using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class UnitModel 
{
    public HandModel Hand { get; set; }
    public int Rank { get; set; }
    public int Faction { get; set; }
    public BattlelineModel Battleline { get; set; }
}
