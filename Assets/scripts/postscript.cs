using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class postscript : MonoBehaviour
{
    [Header("Text")] 
    [TextArea(3, 10)] public string tweet;
    [TextArea(3, 10)] public string comnote;
    [Header("enum")]
    public factuality istrue;
    public enum factuality
    {
        factual,
        misinformation,
    }
    [Header("Components")]
    public TMPro.TextMeshProUGUI tweetText;
    public TMPro.TextMeshProUGUI comnoteText;

    public void Start()
    {
        tweetText.text = tweet;
        comnoteText.text = comnote;
    }

    public void check(bool c)
    {
        if (c == true && istrue == factuality.misinformation)
        {
            //wrong
        }
        if (c == true && istrue == factuality.factual)
        {
            //yippiee
        }
        if (c == false && istrue == factuality.misinformation)
        {
            //yippiee
        }
        if (c == false && istrue == factuality.factual)
        {
            //wrong
        }
    }
}
