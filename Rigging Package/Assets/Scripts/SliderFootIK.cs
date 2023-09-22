using System.Collections;
using System.Collections.Generic;
using System.Linq;
using TMPro;
using UnityEngine;
using UnityEngine.Animations.Rigging;
using UnityEngine.UI;

public class SliderFootIK : MonoBehaviour
{
    public static SliderFootIK Instance;
    [SerializeField] private TMP_Text[] weightConstraint;
    [SerializeField] private TwoBoneIKConstraint[] twoBoneIKConstraint;
    [SerializeField] private Slider[] sliderIKFoot;

    private void Awake()
    {
        Instance = this;
    }

    private void Start()
    {
        foreach(var slider in sliderIKFoot)
        {
            slider.minValue = 0;
            slider.maxValue = 1;
            slider.value = 0;
        }
    }

    private void Update()
    {
        for (int i = 0; i < sliderIKFoot.Length; i++)
            twoBoneIKConstraint[i].weight = sliderIKFoot[i].value;

        weightConstraint[0].text = "Left Foot IK Value: " + twoBoneIKConstraint[0].weight;
        weightConstraint[1].text = "Right Foot IK Value: " + twoBoneIKConstraint[1].weight;
        weightConstraint[2].text = "Left Hand IK Value: " + twoBoneIKConstraint[2].weight;
        weightConstraint[3].text = "Right Hand IK Value: " + twoBoneIKConstraint[3].weight;
    }



}
