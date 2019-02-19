using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SettingMenu : MonoBehaviour
{
    [SerializeField]
    private Transform Root;

    [SerializeField]
    private MainPanel mainPanel;

    [SerializeField]
    private Button buttonBack;

    void Start()
    {
        buttonBack.onClick.AddListener(ButtonClickBack);
    }    

    private void ButtonClickBack()
    {
        Root.gameObject.SetActive(false);
        mainPanel.Init();
    }

    public void Init()
    {
        Root.gameObject.SetActive(true);
    }

    private void OnDestroy()
    {
        buttonBack.onClick.RemoveAllListeners();
    }
}
