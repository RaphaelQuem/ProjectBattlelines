using System.Collections;
using System.Collections.Generic;
using UnityEditor.AssetImporters;
using UnityEngine;

public class SpotBehavior : MonoBehaviour
{

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("entrou");
        var unit = collision.otherCollider.gameObject.GetComponent<UnitBehavior>();

        unit.pinTo = this.transform;

    }
}
