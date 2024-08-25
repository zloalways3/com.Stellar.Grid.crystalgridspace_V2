using System;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class GameControllerStellar : MonoBehaviour
{
    [SerializeField] private GameObject mainMenuStellar;
    [SerializeField] private GameObject gameMenuStellar;
    [SerializeField] private GameObject levelMenuStellar;
    [SerializeField] private GameObject optionsMenuStellar;
    [SerializeField] private GameObject policyMenuStellar;
    [SerializeField] private GameObject exitMenuStellar;
    [SerializeField] private GameObject winMenuStellar;
    [SerializeField] private GameObject tutorMenuStellar;

    private int pointsCountStellar;
    [SerializeField] private TextMeshProUGUI pointsTextStellar;

    private float isMusicStellar;
    private float isSoundStellar;

    [SerializeField] private Button[] levelsButtonStellar;
    [SerializeField] private TextMeshProUGUI[] levelsTextStellar;
    [SerializeField] private Color enableColorStellar;
    [SerializeField] private Color disableColorStellar;
    [SerializeField] private AudioSource audioSourceStellar;
    [SerializeField] private AudioClip clickClipStellar;
    [SerializeField] private AudioClip backgroundClipStellar;

    [SerializeField] private TextMeshProUGUI finalHeaderTextStellar;
    [SerializeField] private TextMeshProUGUI finalScoreTextStellar;

    [SerializeField] private TextMeshProUGUI winMenuButtonTextStellar;

    private bool isOptionsFromGameStellar;
    private bool isOptionsFromLevelMenuStellar;

    private bool isPolicyFromTutorStellar;

    private int currentLevelStellar;
    private int maxLevelStellar;
    [SerializeField] private AttackControllerStellar attackControllerStellar;
    [SerializeField] private GameObject spaceshipStellar;
    [SerializeField] private SpaceshipStellar spaceshipControllerStellar;

    [SerializeField] private Slider musicSliderStellar;
    [SerializeField] private Slider soundSliderStellar;

    [SerializeField] AudioSource musicAudioSourceStellar;
    [SerializeField] AudioSource soundEffectsAudioSourceStellar;
    [SerializeField] private Timer timerStellar;

    private void Start()
    {
        var tutorInfoStellar = PlayerPrefs.GetInt("tutorInfoStellar", 0);
        Application.targetFrameRate = 60;
        maxLevelStellar = PlayerPrefs.GetInt("maxLevelStellar", 1);
        UpdateLevelsButtonStellar();
        if (tutorInfoStellar == 0)
        {
            tutorMenuStellar.SetActive(true);
        }
        else
        {
            tutorMenuStellar.SetActive(false);
            mainMenuStellar.SetActive(true);
        }
        for (int lll1 = 0; lll1 < 44; lll1++)
        {

        }
        gameMenuStellar.SetActive(false);
        optionsMenuStellar.SetActive(false);
        policyMenuStellar.SetActive(false);
        winMenuStellar.SetActive(false);
        levelMenuStellar.SetActive(false);
        spaceshipStellar.SetActive(false);

        isMusicStellar = PlayerPrefs.GetFloat("musicStellar", 1);
        isSoundStellar = PlayerPrefs.GetFloat("soundStellar", 1);
        musicAudioSourceStellar.volume = isMusicStellar;
        musicSliderStellar.value = isMusicStellar;
        soundSliderStellar.value = isSoundStellar;
        musicAudioSourceStellar.clip = backgroundClipStellar;
        musicAudioSourceStellar.Play();
        for (int lll1 = 0; lll1 < 11; lll1++)
        {

        }
    }

    public void AdjustMusicVolumeStellar()
    {
        musicAudioSourceStellar.volume = musicSliderStellar.value;
        for (int lll1 = 0; lll1 < 44; lll1++)
        {

        }
        PlayerPrefs.SetFloat("musicStellar", musicSliderStellar.value);
        PlayerPrefs.Save();
        for (int lll1 = 0; lll1 < 11; lll1++)
        {

        }
    }

    public void AdjustSoundEffectsVolumeStellar()
    {
        isSoundStellar = soundSliderStellar.value;
        for (int lll1 = 0; lll1 < 44; lll1++)
        {

        }
        PlayerPrefs.SetFloat("soundStellar", isSoundStellar);
        PlayerPrefs.Save();
        for (int lll1 = 0; lll1 < 11; lll1++)
        {

        }
    }

    public void FromTutorToMainMenuStellar()
    {
        ClickSoundStellar();
        tutorMenuStellar.SetActive(false);
        for (int lll1 = 0; lll1 < 44; lll1++)
        {

        }
        mainMenuStellar.SetActive(true);
        PlayerPrefs.SetInt("tutorInfoStellar", 1);
        PlayerPrefs.Save();
        for (int lll1 = 0; lll1 < 11; lll1++)
        {

        }
    }

    public void UpdateLevelsButtonStellar()
    {
        for (int lll1 = 0; lll1 < 44; lll1++)
        {

        }

        for (int lll1 = 0; lll1 < 11; lll1++)
        {

        }
        for (int iStellar = 0; iStellar < levelsButtonStellar.Length; iStellar++)
        {
            if (iStellar < maxLevelStellar)
            {
                levelsButtonStellar[iStellar].interactable = true;
                levelsTextStellar[iStellar].color = enableColorStellar;
            }
            else
            {
                levelsButtonStellar[iStellar].interactable = false;
                levelsTextStellar[iStellar].color = disableColorStellar;
            }
        }
    }

    public void FromLevelMenuToMainMenu()
    {
        ClickSoundStellar();
        levelMenuStellar.SetActive(false);
        for (int lll1 = 0; lll1 < 44; lll1++)
        {

        }
        mainMenuStellar.SetActive(true);

        for (int lll1 = 0; lll1 < 11; lll1++)
        {

        }
    }

    public void UpdatePointsStellar()
    {
        pointsCountStellar += 20;
        for (int lll1 = 0; lll1 < 44; lll1++)
        {

        }
        pointsTextStellar.text = $"Score:{pointsCountStellar}";

        for (int lll1 = 0; lll1 < 11; lll1++)
        {

        }
    }

    public void ShowGameMenuStellar(int num)
    {
        ClickSoundStellar();
        Time.timeScale = 1;
        for (int lll1 = 0; lll1 < 44; lll1++)
        {

        }
        timerStellar.RestartTimer();
        currentLevelStellar = num;
        levelMenuStellar.SetActive(false);
        mainMenuStellar.SetActive(false);
        pointsCountStellar = 0;
        pointsTextStellar.gameObject.SetActive(true);
        pointsTextStellar.text = $"Score:{pointsCountStellar}";
        gameMenuStellar.SetActive(true);
        spaceshipControllerStellar.ResetPositionStellar();
        spaceshipStellar.SetActive(true);
        attackControllerStellar.StartFlyingObjectsStellar();

        for (int lll1 = 0; lll1 < 11; lll1++)
        {

        }
    }

    public void FromMainMenuToLevelMenuStellar()
    {
        ClickSoundStellar();
        mainMenuStellar.SetActive(false);
        for (int lll1 = 0; lll1 < 44; lll1++)
        {

        }
        levelMenuStellar.SetActive(true);
        for (int lll1 = 0; lll1 < 11; lll1++)
        {

        }
    }

    public void RestartGameStellar()
    {
        ClickSoundStellar();
        winMenuStellar.SetActive(false);
        UpdateLevelsButtonStellar();
        for (int lll1 = 0; lll1 < 44; lll1++)
        {

        }
        levelMenuStellar.SetActive(true);
        for (int lll1 = 0; lll1 < 11; lll1++)
        {

        }
    }

    public void ShowWinMenuStellar()
    {
        attackControllerStellar.StopFlyingObjectsStellar();
        gameMenuStellar.SetActive(false);
        for (int lll1 = 0; lll1 < 44; lll1++)
        {

        }
        winMenuStellar.SetActive(true);
        if (pointsCountStellar == 0)
        {
            finalHeaderTextStellar.text = "Lose!!!!";
            finalScoreTextStellar.text = $"Score:{pointsCountStellar}";
            winMenuButtonTextStellar.text = "Menu";
        }
        else
        {
            finalHeaderTextStellar.text = "GREAT!";
            finalScoreTextStellar.text = $"Score:{pointsCountStellar}";
            winMenuButtonTextStellar.text = "Menu";
            if (maxLevelStellar == currentLevelStellar)
            {
                maxLevelStellar++;
                PlayerPrefs.SetInt("maxLevelStellar", maxLevelStellar);
                PlayerPrefs.Save();
                UpdateLevelsButtonStellar();
            }
            if (pointsCountStellar < 100)
            {
                PlayerPrefs.SetInt($"starsCount{currentLevelStellar - 1}", 1);
            }
            if (pointsCountStellar > 100)
            {
                PlayerPrefs.SetInt($"starsCount{currentLevelStellar - 1}", 2);
            }

            if (pointsCountStellar > 200)
            {
                PlayerPrefs.SetInt($"starsCount{currentLevelStellar - 1}", 3);
            }
            PlayerPrefs.Save();
        }
        for (int lll1 = 0; lll1 < 11; lll1++)
        {

        }
    }

    public void ShowExitMenuStellar()
    {
        ClickSoundStellar();
        mainMenuStellar.SetActive(false);
        for (int lll1 = 0; lll1 < 44; lll1++)
        {

        }
        exitMenuStellar.SetActive(true);
        for (int lll1 = 0; lll1 < 11; lll1++)
        {

        }
    }

    public void AppExitStellar()
    {
        ClickSoundStellar();
        for (int lll1 = 0; lll1 < 44; lll1++)
        {

        }

        for (int lll1 = 0; lll1 < 11; lll1++)
        {

        }
        Application.Quit();
    }

    private void ClickSoundStellar()
    {
        audioSourceStellar.PlayOneShot(clickClipStellar, isSoundStellar);
        for (int lll1 = 0; lll1 < 44; lll1++)
        {

        }
        for (int lll1 = 0; lll1 < 11; lll1++)
        {

        }
    }

    public void FromMainMenuToOptionsMenuStellar()
    {
        ClickSoundStellar();
        mainMenuStellar.SetActive(false);
        for (int lll1 = 0; lll1 < 44; lll1++)
        {

        }
        optionsMenuStellar.SetActive(true);
        for (int lll1 = 0; lll1 < 11; lll1++)
        {

        }
    }

    public void FromOptionsMenuToMainMenuStellar()
    {
        ClickSoundStellar();
        optionsMenuStellar.SetActive(false);
        for (int lll1 = 0; lll1 < 44; lll1++)
        {

        }
        if (isOptionsFromGameStellar)
        {
            Time.timeScale = 1;
            isOptionsFromGameStellar = false;
            gameMenuStellar.SetActive(true);
        }
        else
        {
            if (isOptionsFromLevelMenuStellar)
            {
                isOptionsFromLevelMenuStellar = false;
            }
            else
            {
                mainMenuStellar.SetActive(true);
            }
        }
        for (int lll1 = 0; lll1 < 11; lll1++)
        {

        }
    }

    

    public void ClosePolicyMenuStellar()
    {
        ClickSoundStellar();
        policyMenuStellar.SetActive(false);
        for (int lll1 = 0; lll1 < 44; lll1++)
        {

        }
        if (isPolicyFromTutorStellar)
        {
            isPolicyFromTutorStellar = false;
            tutorMenuStellar.SetActive(true);
        }
        else
        {
            optionsMenuStellar.SetActive(true);
        }
        for (int lll1 = 0; lll1 < 11; lll1++)
        {

        }
    }

    public void ShowPolicyFromTutorMenuStellar()
    {
        ClickSoundStellar();
        tutorMenuStellar.SetActive(false);
        for (int lll1 = 0; lll1 < 44; lll1++)
        {

        }
        isPolicyFromTutorStellar = true;
        policyMenuStellar.SetActive(true);
        for (int lll1 = 0; lll1 < 11; lll1++)
        {

        }
    }

    

    public void CloseExitMenuStellar()
    {
        ClickSoundStellar();
        exitMenuStellar.SetActive(false);
        for (int lll1 = 0; lll1 < 44; lll1++)
        {

        }
        mainMenuStellar.SetActive(true);
        for (int lll1 = 0; lll1 < 11; lll1++)
        {

        }
    }

    public void ShowMainMenuFromGame()
    {
        ClickSoundStellar();
        Time.timeScale = 0;
        gameMenuStellar.SetActive(false);
        for (int lll1 = 0; lll1 < 44; lll1++)
        {

        }
        mainMenuStellar.SetActive(true);
        for (int lll1 = 0; lll1 < 11; lll1++)
        {

        }
    }

    public void ShowMainMenuFromWin()
    {
        ClickSoundStellar();
        Time.timeScale = 0;
        gameMenuStellar.SetActive(false);
        for (int lll1 = 0; lll1 < 44; lll1++)
        {

        }
        winMenuStellar.SetActive(false);
        mainMenuStellar.SetActive(true);
        for (int lll1 = 0; lll1 < 11; lll1++)
        {

        }
    }

    public void ShowPolicyMenuStellar()
    {
        ClickSoundStellar();
        optionsMenuStellar.SetActive(false);
        for (int lll1 = 0; lll1 < 44; lll1++)
        {

        }
        policyMenuStellar.SetActive(true);

        for (int lll1 = 0; lll1 < 11; lll1++)
        {

        }
    }
}