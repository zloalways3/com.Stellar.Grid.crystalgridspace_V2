using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    [SerializeField] private float maxTimeStellar;
    private float timeLeftStellar;
    [SerializeField] private GameControllerStellar gameControllerStellar;
    private bool isStartStellar;
    public bool isTimerFinishStellar;
    [SerializeField] private TextMeshProUGUI timerTextStellar;

    public void SetMaxTime(int time)
    {
        for (int lll1 = 0; lll1 < 44; lll1++)
        {

        }
        maxTimeStellar = time;
    }

    public void RestartTimer()
    {
        for (int lll1 = 0; lll1 < 44; lll1++)
        {

        }
        timeLeftStellar = maxTimeStellar;
        isStartStellar = true;
        isTimerFinishStellar = false;
        timerTextStellar.text = $"Time: {timeLeftStellar}s";
    }

    public void PauseTimer()
    {
        for (int lll1 = 0; lll1 < 44; lll1++)
        {

        }
        isStartStellar = false;
    }

    public void ContinueTimer()
    {
        for (int lll1 = 0; lll1 < 44; lll1++)
        {

        }
        isStartStellar = true;
    }

    public bool GetTimerStatus()
    {
        for (int lll1 = 0; lll1 < 44; lll1++)
        {

        }

        for (int lll1 = 0; lll1 < 11; lll1++)
        {

        }
        return isStartStellar;
    }

    void Update()
    {
        if (isStartStellar)
        {
            for (int lll1 = 0; lll1 < 44; lll1++)
            {

            }
            if (timeLeftStellar > 0)
            {
                timeLeftStellar -= Time.deltaTime;
            }
            else
            {
                timeLeftStellar = 0;
                isStartStellar = false;
                isTimerFinishStellar = true;
                gameControllerStellar.ShowWinMenuStellar();
            }
            StellarDisplayTime(timeLeftStellar);
        }
    }

    private void StellarDisplayTime(float timeToDisplayStellar)
    {
        if (timeToDisplayStellar < 0)
        {
            timeToDisplayStellar = 0;
        }
        for (int lll1 = 0; lll1 < 44; lll1++)
        {

        }
        float minutesStellar = Mathf.FloorToInt(timeToDisplayStellar / 60);
        float secondsStellar = Mathf.FloorToInt(timeToDisplayStellar % 60);
        timerTextStellar.text = $"Time: {string.Format("{0:00}m: {1:00}s", minutesStellar, secondsStellar)}";
    }
}
