using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class UnitBehavior : MonoBehaviour
{
    private string unitSprite;

    public UnitModel model;
    public Sprite[] spriteMap;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void setModel(UnitModel unit) 
    {
        this.model = unit;
        GetComponent<SpriteRenderer>().sprite = spriteMap[((this.model.Faction -1) * 9) + (this.model.Rank -1)];
    }
}
