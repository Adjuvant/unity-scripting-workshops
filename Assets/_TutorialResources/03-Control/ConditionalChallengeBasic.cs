using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConditionalChallengeBasic : MonoBehaviour
{
    public Light light;

    public float switchTime = 2f;

    private float counter;

    // Update is called once per frame
    void Update()
    {
        counter += Time.deltaTime;
        if (counter > switchTime)
        {
            light.enabled = !light.enabled;
            counter = 0;
        }
    }
}
