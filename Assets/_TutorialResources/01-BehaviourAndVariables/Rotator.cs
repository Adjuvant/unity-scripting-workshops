using UnityEngine;

public class Rotator : MonoBehaviour
{
    public Vector3 rotationAmount;

    // Update is called once per frame
    private void Update()
    {
        transform.Rotate(rotationAmount * Time.deltaTime);
    }
}