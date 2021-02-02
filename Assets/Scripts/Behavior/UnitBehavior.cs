using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class UnitBehavior : MonoBehaviour
{
    private string unitSprite;

    public UnitModel model;
    public Sprite[] spriteMap;
    public bool dragging = false;
    public Vector3 screenPoint;
    public Vector3 offset;
    public bool pinned;
    public GameObject pinTo;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(pinned)
            return;
        if (dragging)
        {
            Vector3 curScreenPoint = new Vector3(Input.mousePosition.x, Input.mousePosition.y, screenPoint.z);
            Vector3 curPosition = Camera.main.ScreenToWorldPoint(curScreenPoint) + offset;
            transform.position = curPosition;
        }
    }

    public void setModel(UnitModel unit) 
    {
        this.model = unit;
        GetComponent<SpriteRenderer>().sprite = spriteMap[((this.model.Faction -1) * 9) + (this.model.Rank -1)];
    }

    void OnMouseDown()
    {
        if (!dragging)
        {
            this.screenPoint = Camera.main.WorldToScreenPoint(this.transform.position);
            this.offset = transform.position - Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, screenPoint.z));
        }
        else
        {
            if (this.pinTo != null)
            {
                this.transform.position = this.pinTo.transform.position;
                this.pinTo.GetComponent<SpotBehavior>().used = true;
                this.pinned = true;
            }
            this.screenPoint = Vector3.zero;
            this.offset = Vector3.zero;
        }
        this.dragging = !this.dragging;
    }
}
