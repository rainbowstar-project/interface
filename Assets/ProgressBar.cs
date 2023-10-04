using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ProgressBar : MonoBehaviour
{
    private Slider slider;

    private void Awake() {
        slider = gameObject.GetComponent<Slider>();
    }

    void Start() {
        slider.value = 0;
    }

    public void IncrementProgress() {
        slider.value += 0.2f;
    }
}
