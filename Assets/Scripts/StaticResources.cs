using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;
using System;

public static class StaticResources
{
    private static List<UnitModel> unitPile = InitializeUnitPile();
    public static List<UnitModel> UnitPile { get {return unitPile;} set {unitPile = value;} }

    public static int MaxHandCards = 5;

    public static List<UnitModel> InitializeUnitPile (){
        List<UnitModel> _unitPile =  new List<UnitModel>();
        for(int unit=1;unit<=9;unit++)
            for(int faction=1;faction<=6;faction++)
            {
                var unitInstance = new UnitModel { Rank = unit, Faction =faction};
                _unitPile.Add( unitInstance);
                GameObject spawnedobj = (GameObject)Resources.Load("Unit");
            }
        return _unitPile.OrderBy(x => Guid.NewGuid()).ToList();
    }

    public static UnitModel DrawCard() {
        var card = UnitPile.Last();
        UnitPile.Remove(card);
        return card;
    }
}
