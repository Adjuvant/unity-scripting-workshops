using UnityEngine;

public class ConditionalChallengeBonus : MonoBehaviour
{
    public Light left, right;
    public float switchTime = 2f;
    private float counter;

    // Start is called before the first frame update
    void Start()
    {
        left.enabled = false;
        right.enabled = true;
    }

    // Update is called once per frame
    void Update()
    {
        counter+=Time.deltaTime;
        if (counter > switchTime)
        {
            left.enabled = !left.enabled;
            right.enabled = !right.enabled;
            counter = 0;
        }
    }
}
