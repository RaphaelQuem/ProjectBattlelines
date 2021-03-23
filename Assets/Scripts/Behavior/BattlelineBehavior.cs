using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BattlelineBehavior : MonoBehaviour
{
    public BattlelineModel battleline;
    // Start is called before the first frame update
    void Start()
    {
        //Bug generated when switching back to the map scene
        // should be solved getting the battleline model from the list instead of creating a new one here when the list is already populated
        if (!StaticResources.SwitchedScene)
        {
            this.battleline = new BattlelineModel();
            StaticResources.Battlelines.Add(this.battleline);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnMouseDown()
    {
        StaticResources.CurrentBattleline = this.battleline;
        StaticResources.SwitchedScene = true;
        SceneManager.LoadScene("Battle");
    }
}
