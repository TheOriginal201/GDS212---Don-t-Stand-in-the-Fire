using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GridPoint : MonoBehaviour
{
    public Vector3 offset;
    public Vector2Int gridPosition;

    public MeshRenderer indicator;
    public Color attackColour;
    public Color safeColour;

    private void Start()
    {
        ShowSafe();
    }
    public Vector3 GetPosition()
    {
        return transform.position + offset;
    }
    public void ShowAttack()
    {
        indicator.material.color = attackColour; 
    }
    public void ShowSafe()
    {
        indicator.material.color = safeColour; 
    }
}
