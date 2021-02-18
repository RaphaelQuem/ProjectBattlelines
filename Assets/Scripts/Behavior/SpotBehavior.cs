using System.Collections;
using System.Collections.Generic;
using UnityEditor.AssetImporters;
using UnityEngine;

public class SpotBehavior : MonoBehaviour
{
    public bool used;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (used) return;
        ChangePinTo(collision);
    }
    private void OnTriggerStay2D(Collider2D collision){
        if (used) return;
        ChangePinTo(collision);
    }
    void ChangePinTo(Collider2D collision){
        var unit = collision.gameObject.GetComponent<UnitBehavior>();
        if(unit.pinTo == null)
            unit.pinTo = this.gameObject;
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        var unit = collision.gameObject.GetComponent<UnitBehavior>();
        if(unit.pinTo == this.gameObject)
            unit.pinTo = null;
    }
}
