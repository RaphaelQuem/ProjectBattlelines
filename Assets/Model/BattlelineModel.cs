using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class BattlelineModel
{
    public BattlelineModel()
    {
        this.Deployments = new List<UnitModel>();
    }
    public List<UnitModel> Deployments { get; set; }

    public int GetTeamPower(TeamModel team)
    {
        var totaldep = this.Deployments.Sum(d => d.Rank);
        var teamdep = this.Deployments.Where(u => u.Hand.Team.Equals(team)).Sum(d => d.Rank);

        return (teamdep / totaldep * 100);
    }
}
