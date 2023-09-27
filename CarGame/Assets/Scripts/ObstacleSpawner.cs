using System.Collections;
using System.Collections.Generic;
using UnityEngine;
// Howdy, I'm not doing my Job LOL! <3
public class ObstacleSpawner : MonoBehaviour
{
    public GameObject obstacle;
    private long pastFrame;

    // Start is called before the first frame update
    void Start()
    {
        pastFrame = Time.frameCount;
    }

    // Update is called once per frame
    void Update()
    {
        if (Time.frameCount - pastFrame == 50)
        {
            Instantiate(obstacle);
            pastFrame = Time.frameCount;
        }
    }
}
