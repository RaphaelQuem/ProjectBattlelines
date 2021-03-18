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
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
