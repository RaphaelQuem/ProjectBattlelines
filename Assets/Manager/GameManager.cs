using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        if (StaticResources.PlayerHandObject == null)
        {
            GameObject hand = GameObjectHelper.PlaceNew(PrefabEnum.PlayerHand, Constants.HAND_POSITION);
            StaticResources.PlayerHandObject = hand;
        }
    }

    // Update is called once per frame
    void Update()
    { 

    }

    void InstantiateCards(){
        foreach (var unit in StaticResources.UnitPile)
        {
            GameObject spawnedobj = (GameObject)Resources.Load("Prefabs/Unit");
            spawnedobj.transform.position = new Vector3(Random.value, Random.value, 0);
            spawnedobj.GetComponent<UnitBehavior>().setModel (new UnitModel
            {
                Faction = unit.Faction,
                Rank = unit.Rank
            });
            GameObject.Instantiate(spawnedobj);
        }
    }
}
