using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Loops : MonoBehaviour
{
    // For loop

    int numEnemies = 3;

    void ForLoop()
    {
        for (int i = 0; i < numEnemies; i++)
        {
            Debug.Log("Creating enemy number: " + i);
        }
    }

    // While Loop

    int cupsInTheSink = 4;

    void WhileLoop()
    {
        while (cupsInTheSink > 0)
        {
            Debug.Log("I've washed a cup!");
            cupsInTheSink--;
        }
    }

    // For each loop

    void ForEachLoop()
    {
        var strings = new List<string>(3);

        strings.Add("First string");
        strings.Add("Second string");
        strings.Add("Third string");

        foreach (string item in strings)
        {
            print(item);
        }
    }

    private IEnumerator Start()
    {
        ForLoop();

        yield return new WaitForSeconds(5f);

        WhileLoop();

        yield return new WaitForSeconds(5f);

        ForEachLoop();
    }
}