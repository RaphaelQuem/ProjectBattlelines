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
        var unit = collision.gameObject.GetComponent<UnitBehavior>();

        unit.pinTo = this.gameObject;
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        var unit = collision.gameObject.GetComponent<UnitBehavior>();
        unit.pinTo = null;
    }
}
