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
    public GameObject source;
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
        source = twittercontroller.God.TC.dictionary[tweetsel].source;
    }

    public void check(bool c)
    {
        anim.SetBool("rate", true);
        if (c == true && istrue == twittercontroller.God.factuality.misinformation)
        {
            Debug.Log("no");
        }
        if (c == true && istrue == twittercontroller.God.factuality.factual)
        {
            Debug.Log("yes");
        }
        if (c == false && istrue == twittercontroller.God.factuality.misinformation)
        {
            Debug.Log("yes");
        }
        if (c == false && istrue == twittercontroller.God.factuality.factual)
        {
            Debug.Log("no");
        }
    }

    public void sourcecheck()
    {
        if (source == twittercontroller.God.TC.clipboard)
        {
            anim.SetBool("rated", true);
        }
    }

    public void dropdown()
    {
        if (anim.GetBool("selected"))
        {
            anim.SetBool("selected", false);
        }
        else
        {
            anim.SetBool("selected", true);
        }
    }

    public void OnCollisionEnter2D(Collision2D other)
    {
        Destroy(gameObject);
    }
}
