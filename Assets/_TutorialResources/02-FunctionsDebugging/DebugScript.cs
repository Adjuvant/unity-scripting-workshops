using UnityEngine;

// Scripts shows how to post custom messages to the console.
// Also simple example of using a UI button event call

public class DebugScript : MonoBehaviour
{
    int numOfClicks = 0;

    public void ButtonClicked()
    {
        numOfClicks++;
        Debug.Log("Clicked " + gameObject.name + " " + numOfClicks + " times.");
//		Same thing but different 
//		Debug.LogFormat("Clicked {0} {1} times.",gameObject.name,numOfClicks);
    }
}