using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TeamModel
{
    public int Id { get; set; }
    public HandModel Hand { get;set; }
    public List<BattlelineModel> Deployments { get; set; }
}
