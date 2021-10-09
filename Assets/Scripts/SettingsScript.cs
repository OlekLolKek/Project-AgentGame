using DefaultNamespace;
using UnityEngine;
using UnityEngine.UI;

public class SettingsScript : MonoBehaviour
{
    public Button SettingsButton;
    public GameObject SettingsButtonGO;
    public Button BackButton;
    public GameObject BackButtonGO;
    public Button StartButton;
    public GameObject StartButtonGO;
    public Button SoundONButton;
    public GameObject SoundONButtonGO;
    public Button SoundOFFButton;
    public GameObject SoundOFFButtonGO;
    public Slider VolumeSlider;
    public GameObject VolumeSliderGO;
    public Text UItext;
    public GameObject UItextGO;
    public Text SettingsText;
    public GameObject SettingsTextGO;
    public InputField NameInput;
    public GameObject NameInputGO;
    public Text InputText;
    public string Nickname;
    public AITarget ait;

    [SerializeField] private Button _exitButton;

    private void Start()
    {
        VolumeSlider.value = PlayerPrefs.GetFloat(SettingsParameterNames.VOLUME);
    }

    public void SettingsMenu()
    {
        SettingsButtonGO.SetActive(false);
        StartButtonGO.SetActive(false);
        UItextGO.SetActive(false);
        SoundONButtonGO.SetActive(true);
        SettingsTextGO.SetActive(true);
        VolumeSliderGO.SetActive(true);
        NameInputGO.SetActive(true);
        BackButtonGO.SetActive(true);
        _exitButton.gameObject.SetActive(false);
    }
    public void BackButtonAction()
    {
        SettingsButtonGO.SetActive(true);
        StartButtonGO.SetActive(true);
        UItextGO.SetActive(true);
        SoundONButtonGO.SetActive(false);
        SoundOFFButtonGO.SetActive(false);
        SettingsTextGO.SetActive(false);
        VolumeSliderGO.SetActive(false);
        NameInputGO.SetActive(false);
        BackButtonGO.SetActive(false);
        _exitButton.gameObject.SetActive(true);
    }
    public void SoundONButtonAction()
    {
        AITarget.MusicON = false;
        SoundONButtonGO.SetActive(false);
        SoundOFFButtonGO.SetActive(true);
        VolumeSlider.value = 0;
        PlayerPrefs.SetFloat(SettingsParameterNames.VOLUME, 0.0f);
        PlayerPrefs.Save();
    }
    public void SoundOFFButtonAction()
    {
        AITarget.MusicON = true;
        SoundONButtonGO.SetActive(true);
        SoundOFFButtonGO.SetActive(false);
        VolumeSlider.value = VolumeSlider.maxValue;
        PlayerPrefs.SetFloat(SettingsParameterNames.VOLUME, 1.0f);
        PlayerPrefs.Save();
    }
    public void VolumeSliderAction()
    {
        AITarget.Volume = VolumeSlider.value;
        PlayerPrefs.SetFloat(SettingsParameterNames.VOLUME, VolumeSlider.value);
        PlayerPrefs.Save();
    }
    public void ExitButtonAction()
    {
        Application.Quit();
    }
    public void Update()
    {
        Nickname = NameInput.text;
    }
}
