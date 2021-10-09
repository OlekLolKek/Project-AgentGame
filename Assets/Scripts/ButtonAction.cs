using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ButtonAction : MonoBehaviour
{
    public Button TestButton;
    public Toggle IsOn;
    public Toggle IsOff;
    public InputField InputFieldText;
    public Slider Slider;
    public Dropdown Dropdown;

    public void SceneChange(int sceneNum)
    {
        SceneManager.LoadScene(sceneNum);
    }


    public void UIElementsCheck()
    {
        Debug.Log("IsOn "+ IsOn.isOn);
        Debug.Log("IsOff " + IsOff.isOn);
        Debug.Log("Slider value " + Slider.value);
        Debug.Log("Dropdown " + Dropdown.value);
        Debug.Log("Input " + InputFieldText.text);
    }
}
