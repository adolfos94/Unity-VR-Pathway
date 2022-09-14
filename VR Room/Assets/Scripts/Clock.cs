using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Clock : MonoBehaviour
{
    // Start is called before the first frame update

    public GameObject hoursArrow;
    public GameObject minutesArrow;
    public GameObject secondsArrow;

    // Update is called once per frame
    private void Update()
    {
        int hours = DateTime.Now.Hour;
        int minutes = DateTime.Now.Minute;
        int seconds = DateTime.Now.Second;

        var angleHours = Quaternion.Euler(0.5f * (60 * hours + minutes), 0, 0);
        hoursArrow.transform.localRotation = angleHours;

        var angleMinutes = Quaternion.Euler(6 * minutes, 0, 0);
        minutesArrow.transform.localRotation = angleMinutes;

        var angleSeconds = Quaternion.Euler(6 * seconds, 0, 0);
        secondsArrow.transform.localRotation = angleSeconds;
    }
}