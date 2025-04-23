using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class postscript : MonoBehaviour
{
    [Header("Text")] 
    [SerializeField] private string tweet;
    [SerializeField] private string comnote;
    [Header("enum")]
    [SerializeField] twittercontroller.God.factuality istrue;
    [Header("Components")]
    public TMPro.TextMeshProUGUI tweetText;
    public TMPro.TextMeshProUGUI comnoteText;
    public Animator anim;
    [Header("Int")]
    [SerializeField] private int tweetsel;

    public void Start()
    {
        Debug.Log(twittercontroller.God.TC.dictionary.Count);
        tweetsel = Random.Range(0, twittercontroller.God.TC.dictionary.Count);
        Debug.Log(tweetsel);
        tweetText.text = twittercontroller.God.TC.dictionary[tweetsel].post;
        comnoteText.text = twittercontroller.God.TC.dictionary[tweetsel].communitynote;
        istrue = twittercontroller.God.TC.dictionary[tweetsel].isfactual;
    }

    public void check(bool c)
    {
        if (c == true && istrue == twittercontroller.God.factuality.misinformation)
        {
            Debug.Log("no");
        }
        if (c == true && istrue == twittercontroller.God.factuality.factual)
        {
            anim.SetBool("rated", true);
        }
        if (c == false && istrue == twittercontroller.God.factuality.misinformation)
        {
            anim.SetBool("rated", true);
        }
        if (c == false && istrue == twittercontroller.God.factuality.factual)
        {
            Debug.Log("no");
        }
    }

    public void dropdown()
    {
        anim.SetBool("rate", true);
    }
}
