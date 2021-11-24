//Attach this script to anyGameObject in your scene to spawn a cube and change the material color

using UnityEngine;

public class ColorCubesRed : MonoBehaviour
{
    void Start()
    {
        //Create a new cube primitive to set the color on
        GameObject cube = GameObject.CreatePrimitive(PrimitiveType.Cube);

        cube.transform.position = transform.position;

        //Get theRenderer component from the new cube
        var cubeRenderer = cube.GetComponent<Renderer>();

        //Call SetColor using the shader property name "_Color" and setting the color to red
        cubeRenderer.material.SetColor("_Color", Color.red);
    }
}