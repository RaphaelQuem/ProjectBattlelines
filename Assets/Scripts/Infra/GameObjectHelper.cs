using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameObjectHelper
{
    public static GameObject PlaceNew(PrefabEnum prefab, float x=0, float y=0, float z=0)
    {
        GameObject obj = (GameObject)Resources.Load($"Prefabs/{prefab}");
        obj.transform.position = new Vector3(x, y, z);

        return GameObject.Instantiate(obj);

    }
    public static GameObject PlaceNew(PrefabEnum prefab, Vector3 position)
    {
        GameObject obj = (GameObject)Resources.Load($"Prefabs/{prefab}");
        obj.transform.position = position;

        return GameObject.Instantiate(obj);

    }
}
