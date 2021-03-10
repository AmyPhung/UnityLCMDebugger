using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;
public class DataCanvas : MonoBehaviour
{
    public LCMListener listener;
    public Text deltaText;
    public Text depthText;
    public Text rollText;
    public Text pitchText;
    public Text yawText;

    public Text debugText;

    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        double deltaValue = Math.Round(listener.ClumpDelta, 3);
        deltaText.text = "Clump Delta: " + deltaValue.ToString();

        double depthValue = Math.Round(listener.Depth, 3);
        depthText.text = "Depth: " + depthValue.ToString();

        double rollValue = Math.Round(listener.Roll, 3);
        rollText.text = "Roll: " + rollValue.ToString();

        double pitchValue = Math.Round(listener.Pitch, 3);
        pitchText.text = "Pitch: " + pitchValue.ToString();

        double yawValue = Math.Round(listener.Yaw, 3);
        yawText.text = "Yaw: " + yawValue.ToString();
    }

    public void printDebug(String msg)
    {
        debugText.text = debugText.text + "\n" + msg;
    }
}
