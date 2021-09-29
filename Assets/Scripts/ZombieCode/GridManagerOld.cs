using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ZombieCode
{
    public class GridManager : MonoBehaviour
    {
        public float gridSpacing = 0.5f;

        public Vector2Int gridSize = new Vector2Int(3, 3);
        Vector2Int previousGridSize = new Vector2Int(3, 3);

        private enum GridState { };

        //[SerializeField] allows privite fuilds to be shown in the inpector
        public bool[,] grid = new bool[0, 0]; //[] is an array. Anything to do with an array is accesed via these.

        private void OnValidate()
        {
            if (gridSize != previousGridSize) //Resets and updates the new grid size on the inpector 
            {
                grid = new bool[gridSize.x, gridSize.y];

                previousGridSize = gridSize;
            }
        }

        // Start is called before the first frame update
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {

        }

        private void OnDrawGizmos()
        {
            for (int x = 0; x <= grid.GetUpperBound(0); x++)
            {
                for (int y = 0; y <= grid.GetUpperBound(1); y++)
                {
                    if (grid[x, y] == true)
                    {
                        Gizmos.DrawWireSphere(transform.position + new Vector3(x * gridSpacing, 0f, y * gridSpacing), 0.25f);
                    }
                }
            }
        }
    }
}
