using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class GridMManager : MonoBehaviour //monobehavor is a Base class. So in this case, GridMang inheranctens from the base class Monohevhavour.
{
    public GridPoint[] gridPoints = new GridPoint[0];

    public static GridMManager current;

    [Serializable] //needs "using System"
    public class GridPoint // This class only contains the following 
    {
        public Transform transform;
        public Vector3 offset;
        public Vector2Int gridPosition;
    }

    private void Start()
    {
        current = this;
    }

    public Vector3 GetPosition(Vector2Int position)
    {
        GridPoint gridPoint = GetGridPoint(position);
        return gridPoint.transform.position + gridPoint.offset;
    }

    public GridPoint GetGridPoint(Vector2Int position)
    {
        try
        {
            return gridPoints.First(g => g.gridPosition == position);
        }
        catch
        {
            throw new Exception("Grid position not found bby");
        }
    }

    private void OnDrawGizmos()
    {
        foreach (var gridPoint in gridPoints)
        {
            if (gridPoint.transform != null)
            {
                Gizmos.DrawWireSphere(gridPoint.transform.position + gridPoint.offset, 0.25f);
            }
        }
    }

}
