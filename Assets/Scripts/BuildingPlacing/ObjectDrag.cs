using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectDrag : MonoBehaviour
{
    private Vector3 offset;
    public bool isDragged = false;

    private void Update()
    {
        if (!isDragged) return;
        
        Vector3 pos = BuildingSystem.GetMouseWorldPosition() + offset;
        transform.position = BuildingSystem.current.SnapCoordinateToGrid(pos);
    }

    public void StartDragging()
    {
        isDragged = true;
        offset = transform.position - BuildingSystem.GetMouseWorldPosition();
    }

    private void OnMouseDown()
    {
        //offset = transform.position - BuildingSystem.GetMouseWorldPosition();
    }

    // private void OnMouseDrag()
    // {
    //     Vector3 pos = BuildingSystem.GetMouseWorldPosition() + offset;
    //     transform.position = BuildingSystem.current.SnapCoordinateToGrid(pos);
    // }
    
}
