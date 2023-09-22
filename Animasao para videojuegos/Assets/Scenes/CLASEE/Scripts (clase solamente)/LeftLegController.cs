using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.Animations.Rigging;
using UnityEngine.UI;

public class LeftLegController : MonoBehaviour
{
    public string weightParameterName = "Weight";
    public Rig rig;
    public Slider slider;
    public TextMeshProUGUI sliderLeftText;

    private void Start()
    {
        slider.onValueChanged.AddListener(ChangeRightWeightValue);
    }
    private void Update()
    {
        sliderLeftText.text = slider.value.ToString();
    }

    private void ChangeRightWeightValue(float value)
    {
        rig.weight = value;
    }
}
