using UnityEngine;

public class SwitchRenderersEnabled : MonoBehaviour
{
    public Renderer[] things;

    bool thingsVisible = true;
    bool processComplete = true;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
            thingsVisible = !thingsVisible;
            processComplete = false;
        }

        if (!processComplete)
        {
            for (int i = 0; i < things.Length; i++)
            {
                things[i].enabled = thingsVisible;
            }

            processComplete = true;
        }
    }
}