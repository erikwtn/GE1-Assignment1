using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ControlPanelHandler : MonoBehaviour
{
    private Slider _ySlider, _vSlider, _mSlider;
    [SerializeField] private TextMeshProUGUI yTxt, vTxt, mTxt;

    public void SliderChanged(Slider slider)
    {
        switch (slider.maxValue)
        {
            case 50:
                yTxt.text = slider.value + "y";
                _ySlider = slider;
                break;
            case 600:
                vTxt.text = slider.value + "v";
                _vSlider = slider;
                break;
            case 35000:
                mTxt.text = slider.value + "kg";
                _mSlider = slider;
                break;
        }
    }

    public void CheckValues()
    {
        if (_ySlider != null && _vSlider != null && _mSlider != null)
        {
            
        }
    }
}
