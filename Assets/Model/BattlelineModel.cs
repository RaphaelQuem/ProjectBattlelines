using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class BattlelineModel
{
    public List<UnitModel> Deployments { get; set; }

    public int GetTeamPower(TeamModel team)
    {
        var deployments = this.Deployments.Where(u => u.Hand.Team.Equals(team));

        return deployments.Sum(d => d.Rank);
    }
}
