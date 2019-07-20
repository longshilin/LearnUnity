using UnityEngine;
using System.Collections;

public class CountdownTimerUtility : MonoBehaviour
{
    private float countdownTimerStartTime;
    private int countdownTimerDuration;

    /// <summary>
    /// Gets the total seconds.
    /// </summary>
    /// <returns>The total seconds.</returns>
    public int GetTotalSeconds()
    {
        return countdownTimerDuration;
    }

    /// <summary>
    /// Resets the timer.
    /// </summary>
    /// <param name="seconds">Seconds.</param>
    public void ResetTimer(int seconds)
    {
        countdownTimerStartTime = Time.time;
        countdownTimerDuration = seconds;
    }

    /// <summary>
    /// Gets the seconds remaining.
    /// </summary>
    /// <returns>The seconds remaining.</returns>
    public int GetSecondsRemaining()
    {
        int elapsedSeconds = (int)(Time.time - countdownTimerStartTime);
        int secondsLeft = (countdownTimerDuration - elapsedSeconds);
        return secondsLeft;
    }

    /// <summary>
    /// Gets the fraction seconds remaining.
    /// </summary>
    /// <returns>The fraction seconds remaining.</returns>
    public float GetFractionSecondsRemaining()
    {
        float elapsedSeconds = (Time.time - countdownTimerStartTime);
        float secondsLeft = (countdownTimerDuration - elapsedSeconds);
        return secondsLeft;
    }

    /// <summary>
    /// Gets the proportion time remaining.
    /// </summary>
    /// <returns>The proportion time remaining.</returns>
    public float GetProportionTimeRemaining()
    {
        float proportionLeft = (float)GetFractionSecondsRemaining() / (float)GetTotalSeconds();
        return proportionLeft;
    }
}