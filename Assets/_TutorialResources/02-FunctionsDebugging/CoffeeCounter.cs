// using statements gather things needed for that script in libraries, APIs etc.
using UnityEngine;

public class CoffeeCounter : MonoBehaviour 
{ // <- Blocks of code are enclosed by curly brackets: { }

    float coffeeTemperature = 85.0f;
    float hotLimitTemperature = 70.0f;
    float coldLimitTemperature = 40.0f;

    void Update()
    {
        // If the coffee's temperature is greater than the hottest drinking temperature...
        if (coffeeTemperature > hotLimitTemperature)
        {
            // ... do this.
            print("Coffee is too hot.");
        }
        // If it isn't, but the coffee temperature is less than the coldest drinking temperature...
        else if (coffeeTemperature < coldLimitTemperature)
        {
            // ... do this.
            print("Coffee is too cold.");
        }
        // If it is neither of those then...
        else
        {
            // ... do this.
            print("Coffee is just right.");
        }
        coffeeTemperature -= 0.01f;
    }
}