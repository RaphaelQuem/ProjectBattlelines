using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class debug : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnMouseDown()
    {
        Debug.Log($"Current: {StaticResources.CurrentBattleline.Deployments.Count}");
        var ix = 1;
        foreach(var bl in StaticResources.Battlelines)
            Debug.Log($"BL {ix++}: {bl.Deployments.Count}");
    }
}
