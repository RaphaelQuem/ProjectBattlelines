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
        // SHOULD CREATE NEW BATTLE LINE AND ADD IT TO THE BATTLELINE LIST
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
