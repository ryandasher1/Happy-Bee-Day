using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuildingSelector : MonoBehaviour
{
    public GameObject selectedBuilding;
    void SelectBuildingA(GameObject building)
    {
        selectedBuilding = building;
    }

    void SelectBuildingB(GameObject building)
    {
        selectedBuilding = building;
    }
}
