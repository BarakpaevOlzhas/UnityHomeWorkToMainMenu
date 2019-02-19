using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainPanel : MonoBehaviour
{
    [SerializeField]
    private Transform root;

    [SerializeField]
    private SettingMenu settingMenu;

    [SerializeField]
    private Button continueButton, settingButton, exitButton;   

    void Start()
    {
        exitButton.onClick.AddListener(ButtonClickExit);
        continueButton.onClick.AddListener(ButtonClickContinue);
        settingButton.onClick.AddListener(ButtonClickSetting);
    }

    private void ButtonClickContinue()
    {
        SceneManager.LoadScene("Level1");
    }

    private void ButtonClickExit()
    {
        Application.Quit();
    }

    public void Init()
    {
        root.gameObject.SetActive(true);
    }

    private void ButtonClickSetting()
    {
        root.gameObject.SetActive(false);
        settingMenu.Init();
    }

    private void OnDestroy()
    {
        exitButton.onClick.RemoveAllListeners();
        continueButton.onClick.RemoveAllListeners();
        settingButton.onClick.RemoveAllListeners();
    }
}
