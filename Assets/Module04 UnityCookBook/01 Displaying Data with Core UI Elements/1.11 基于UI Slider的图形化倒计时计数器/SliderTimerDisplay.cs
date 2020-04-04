using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace c110
{
    public class SliderTimerDisplay : MonoBehaviour
    {
        private CountdownTimer countdownTimer;
        private Slider sliderUI;
        private int startSeconds = 30;

        // Start is called before the first frame update
        void Start()
        {
            SetupSlider();
            SetupTimer();
        }

        // 初始化Timer计时器
        private void SetupTimer()
        {
            countdownTimer = GetComponent<CountdownTimer>();
            countdownTimer.ResetTimer(startSeconds);
        }

        // 初始化slider
        private void SetupSlider()
        {
            sliderUI = GetComponent<Slider>();
            sliderUI.minValue = 0;
            sliderUI.maxValue = 1;
            sliderUI.wholeNumbers = false;
        }

        // Update is called once per frame
        void Update()
        {
            float proportionTimeRemaining = countdownTimer.GetProportionTimeRemaining();
            if (proportionTimeRemaining > 0)
            {
                sliderUI.value = proportionTimeRemaining;
                print(proportionTimeRemaining);
            }
            else
            {
                sliderUI.value = 0;
            }
        }
    }
}