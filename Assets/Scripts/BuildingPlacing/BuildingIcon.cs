using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BuildingIcon : MonoBehaviour
{
    [SerializeField] private GameObject prefab;

    [SerializeField] private BuildingSystem buildingSystem;

    public void Clicked()
    {
        buildingSystem.InitializeWithObject(prefab);
    }
}
