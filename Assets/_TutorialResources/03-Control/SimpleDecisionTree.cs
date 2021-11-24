using UnityEngine;

public class SimpleDecisionTree : MonoBehaviour
{

    // Update is called once per frame
    void Update()
    {
        // Use a random number test to make slight movement changes
        var testLeftRight = Random.value;
        var testUpDown = Random.value;
        var testFwdBack = Random.value;

        var colourChange = Random.value;
        

        if (testLeftRight < .5f)
        {
            transform.Translate(Vector3.left*Time.deltaTime);
            
        }
        else if (testLeftRight > .5f)
        {
            transform.Translate(Vector3.right*Time.deltaTime);
        }
        
        if (testUpDown < .5f)
        {
            transform.Translate(Vector3.up*Time.deltaTime);
        }
        else if (testUpDown > .5f)
        {
            transform.Translate(Vector3.down*Time.deltaTime);
        }
        
        if (testFwdBack < .5f)
        {
            transform.Translate(Vector3.forward*Time.deltaTime);
        }
        else if (testFwdBack > .5f)
        {
            transform.Translate(Vector3.back*Time.deltaTime);
        }
        
        if(colourChange > .9f)
            GetComponent<Renderer> ().material.color = new Color(testLeftRight,testUpDown,testFwdBack);
    }
}
