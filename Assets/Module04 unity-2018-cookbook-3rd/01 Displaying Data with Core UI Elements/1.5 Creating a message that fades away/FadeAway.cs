using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(CountdownTimer))]
public class FadeAway : MonoBehaviour
{
    private CountdownTimer m_CountdownTimer;
    private Text m_TextUI;
    private readonly int m_FadeDuration = 5;
    private bool m_Fading = false;

    void Awake()
    {
        m_TextUI = GetComponent<Text>();
        m_CountdownTimer = GetComponent<CountdownTimer>();
    }

    // Start is called before the first frame update
    void Start()
    {
        m_CountdownTimer.ResetTimer(m_FadeDuration);
        m_Fading = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (m_Fading)
        {
            // get the current proportion of the total time.
            float alphaRemaining = m_CountdownTimer.GetProportionTimeRemaining();
            print(alphaRemaining);
            Color c = m_TextUI.material.color;
            c.a = alphaRemaining;
            m_TextUI.material.color = c;

            // stop fading when very small number
            if (alphaRemaining < 0.01)
            {
                m_Fading = false;
            }
        }
    }
}