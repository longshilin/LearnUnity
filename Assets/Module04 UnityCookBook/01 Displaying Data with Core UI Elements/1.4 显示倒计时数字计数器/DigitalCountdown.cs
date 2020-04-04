using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DigitalCountdown : MonoBehaviour
{
    private Text textClock;

    private float countdownTimeDuration;

    private float countdownTimeStartTime;

    // Start is called before the first frame update
    void Start()
    {
        textClock = GetComponent<Text>();
        CountdownTimerReset(30);
    }

    // Update is called once per frame
    void Update()
    {
        // default - timer finished
        string timerMessage = "Countdown has finished";
        int timeLeft = (int) CountdownTimerSecondsRemaining();

        if (timeLeft > 0)
        {
            timerMessage = string.Format("{0}{1}", "Countdown seconds remaining = ", LeadingZero(timeLeft));
        }

        textClock.text = timerMessage;
    }

    /// <summary>
    /// 重置开始时间
    /// </summary>
    /// <param name="delayInSeconds">计数初始时间</param>
    private void CountdownTimerReset(float delayInSeconds)
    {
        countdownTimeDuration = delayInSeconds;
        countdownTimeStartTime = Time.time;
    }

    /// <summary>
    /// 计算剩余时间
    /// </summary>
    /// <returns>剩余时间</returns>
    private float CountdownTimerSecondsRemaining()
    {
        float elapsedSeconds = Time.time - countdownTimeStartTime;
        float timeLeft = countdownTimeDuration - elapsedSeconds;
        return timeLeft;
    }

    private string LeadingZero(int n)
    {
        return n.ToString().PadLeft(2, '0');
    }
}