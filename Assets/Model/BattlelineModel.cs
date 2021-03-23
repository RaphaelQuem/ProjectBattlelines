using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class BattlelineModel
{
    public BattlelineModel()
    {
        this.Deployments = new List<DeploymentModel>();
    }
    public List<DeploymentModel> Deployments { get; set; }

}
