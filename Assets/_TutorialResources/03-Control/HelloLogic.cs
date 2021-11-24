// using statements gather things needed for that script in libraries, APIs etc.
using UnityEngine;

public class HelloLogic : MonoBehaviour 
{ // <- Blocks of code are enclosed by curly brackets: { }
    public Renderer outputViz; // Connect this in the editor!
    
    float coffeeTemperature = 85.0f;
    float hotLimitTemperature = 70.0f;
    float coldLimitTemperature = 40.0f;

    void Update()
    {
        TemperatureTest();

        coffeeTemperature -= Time.deltaTime * 5f;
    }

    // IF statement example
    void TemperatureTest()
    {
        // If the coffee's temperature is greater than the hottest drinking temperature...
        if (coffeeTemperature > hotLimitTemperature)
        {
            // ... do this.
            print("Coffee is too hot.");
            outputViz.material.color = Color.red;
        }
        // If it isn't, but the coffee temperature is less than the coldest drinking temperature...
        else if (coffeeTemperature < coldLimitTemperature)
        {
            // ... do this.
            print("Coffee is too cold.");
            outputViz.material.color = Color.blue;
        }
        // If it is neither of those then...
        else
        {
            // ... do this.
            print("Coffee is just right.");
            outputViz.material.color = Color.green;
        }
    }
}
