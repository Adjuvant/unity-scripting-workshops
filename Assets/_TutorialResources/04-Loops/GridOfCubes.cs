using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GridOfCubes : MonoBehaviour
{
    // Make public data to control size of grids, and optionally the size of created cubes
    
    
    // Start is called before the first frame update
    void Start()
    {
        // Make for loop to generate cubes
            // Use CreateCube method to generate shape, you must supply it with position and size data
            
    }

    void CreateCube(float x, float y, float z, float size)
    {
        var cube = GameObject.CreatePrimitive(PrimitiveType.Cube);
        cube.transform.position = new Vector3(x, y, z);
        cube.transform.localScale = new Vector3(size, size, size);
    }
}
