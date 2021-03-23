using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BattlelineManager : MonoBehaviour
{
    public BattlelineModel battleline;
    // Start is called before the first frame update
    void Start()
    {
        this.battleline = StaticResources.CurrentBattleline;
        foreach (var deployment in this.battleline.Deployments)
        {
            foreach (var spot in GameObject.FindGameObjectsWithTag("Spot"))
            {
                if(deployment.SpotId.Equals(spot.GetComponent<SpotBehavior>().Id))
                {
                    GameObject spawnedobj = (GameObject)Resources.Load("Prefabs/Unit");
                    spawnedobj.transform.position = spot.transform.position;
                    spawnedobj.GetComponent<UnitBehavior>().setModel(deployment.Unit);
                    GameObject.Instantiate(spawnedobj);
                }
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
