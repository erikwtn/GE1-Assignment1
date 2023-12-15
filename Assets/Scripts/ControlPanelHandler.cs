using System;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ControlPanelHandler : MonoBehaviour
{
    private Slider _ySlider, _vSlider, _mSlider;
    [SerializeField] private TextMeshProUGUI yTxt, vTxt, mTxt;
    
    [SerializeField] private float currentYear = 0;

    [SerializeField] private ParticleSystem vParticle, sParticle, bParticle1, bParticle2;
    [SerializeField] private Animator sphereAnim;
    
    private static readonly int Failed = Animator.StringToHash("Failed");

    private void Start()
    {
        vParticle.Stop();
        bParticle1.Stop();
        bParticle2.Stop();
        sParticle.Stop();
    }

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
        if (CheckYear())
        {
            bParticle1.Play();
            bParticle2.Play();
            if (CheckVoltage())
            {
                vParticle.Play();
                if (CheckMass())
                {
                    sParticle.Play();
                    WinCondition();
                }
                else
                {
                    FailCondition();  
                }
            }
            else
            {
                FailCondition();
            }
        }
        else
        {
            FailCondition();
        }
    }

    private bool CheckYear()
    {
        if (_ySlider == null || _vSlider == null || _mSlider == null) return false; // check if sliders have been changed
        
        if (currentYear + Mathf.Abs(_ySlider.value) > currentYear + 10) // check if the year has been changed too much
        {
            return false;
        }

        if (currentYear + Mathf.Abs(_ySlider.value) <= currentYear + 10) // if the year has been changed to an allowed range
        {
            if (currentYear + _ySlider.value <= -30) // check  if the year has been changed too far back
            {
                SceneManager.LoadScene(sceneBuildIndex: 2);
            }
            
            return true;
        }

        return false;
    }

    private bool CheckVoltage()
    {
        float[] voltagesAllowed = {240, 400, 480, 600};
        var hasPassed = false;
        float j = 0;

        foreach (var f in voltagesAllowed) // check if the input is within range of allowed voltages
        {
            if (Math.Abs(_vSlider.value - f) < 20) // check tolerance
            {
                j = f;
                hasPassed = true;
            }
        }

        if (!hasPassed) return false;
        
        var d = (Mathf.Abs(currentYear) + Mathf.Abs(_ySlider.value));
        
        if (j == voltagesAllowed[0] && d is >= 0 and < 10)
        {
            return true;
        }

        if (j == voltagesAllowed[1] && d is >= 10 and < 20)
        {
            return true;
        }

        if (j == voltagesAllowed[2] && d is >= 20 and < 30)
        {
            return true;
        }

        if (j == voltagesAllowed[3] && d is >= 30 and <= 50)
        {
            return true;
        }

        return false;
    }

    private bool CheckMass() // check if abs(years * voltage) is within tolerance and correct
    {
        var t = Mathf.Abs(_ySlider.value) * Mathf.Abs(_vSlider.value);
        var c = (t / 100) * 10;
        
        Debug.Log("Checked mass");

        return Math.Abs(_mSlider.value - t) < c;
    }

    private void FailCondition()
    {
       sphereAnim.SetTrigger(Failed);
    }

    private void WinCondition()
    {
        SceneManager.LoadScene(sceneBuildIndex: 1);
    }
}
