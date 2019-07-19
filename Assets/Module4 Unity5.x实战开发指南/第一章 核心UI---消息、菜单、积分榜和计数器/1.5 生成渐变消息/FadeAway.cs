using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FadeAway : MonoBehaviour
{
    private CountdownTimer countdownTimer;
    private Text textUI;
    private int fadeDuration = 5;
    private bool fading = false;

    // Start is called before the first frame update
    void Start()
    {
        textUI = GetComponent<Text>();
        countdownTimer = GetComponent<CountdownTimer>();
        StartFading(fadeDuration);

    }

    // Update is called once per frame
    void Update()
    {
        if (fading)
        {
            // get the current proportion of the total time.
            float alphaRemaining = countdownTimer.GetProportionTimeRemaining();
            print(alphaRemaining);
            Color c = textUI.material.color;
            c.a = alphaRemaining;
            textUI.material.color = c;

            // stop fading when very small number
            if (alphaRemaining < 0.01)
            {
                fading = false;
            }
        }
    }

    /// <summary>
    /// Starts the fading.
    /// </summary>
    /// <param name="timerTotal">Timer total.</param>
    public void StartFading(int timerTotal)
    {
        countdownTimer.ResetTimer(timerTotal);
        fading = true;
    }

}
