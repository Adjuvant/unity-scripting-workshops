using UnityEngine;

public class DebugDotLogWarningExample :MonoBehaviour
{
    public Transform targetTransform;

    void Start()
    {
        if (targetTransform== null){
            Debug.LogError("Transform not found, it is needed for operations, please assign in editor!", this);
            return;
        }

        // Move this transform to position of target one.
        transform.position = targetTransform.position;
    }
}