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
        this.battleline = new BattlelineModel();
        StaticResources.Battlelines.Add(this.battleline);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnMouseDown()
    {
        SceneManager.LoadScene("Battle");
    }
}
