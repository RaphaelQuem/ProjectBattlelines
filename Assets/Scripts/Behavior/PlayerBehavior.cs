using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using System.Linq;

public class PlayerBehavior : MonoBehaviour
{


    public List<UnitModel> playerHand;
    void Awake()
    {
        DontDestroyOnLoad(this.gameObject);
    }
    // Start is called before the first frame update
    void Start()
    {
        playerHand =  new List<UnitModel>();
        DrawCards();
    }

    // Update is called once per frame
    void Update()
    {

    }
    void DrawCards()
    {
        while (playerHand.Count < StaticResources.MaxHandCards)
        {
            playerHand.Add(StaticResources.DrawCard());
            Debug.Log(string.Format("Drawn card: Faction {0} Rank {1} ", playerHand.Last().Faction, playerHand.Last().Rank));

            GameObject spawnedobj = (GameObject)Resources.Load("Prefabs/Unit");
            spawnedobj.GetComponent<UnitBehavior>().setModel (new UnitModel
            {
                Faction = playerHand.Last().Faction,
                Rank = playerHand.Last().Rank
            });
            var unit = GameObject.Instantiate(spawnedobj);
            unit.transform.parent = gameObject.transform;
            unit.transform.localScale = new Vector3(4,4,4);
            unit.transform.position = new Vector3(0,0,0);
        }

        Debug.Log("Remaining cards: "  + StaticResources.UnitPile.Count);
    } 

}
