using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class postscript : MonoBehaviour
{
    [Header("enum")]
    [SerializeField] serversidecontroller.God.factuality istrue;
    [Header("Components")]
    public TMPro.TextMeshProUGUI tweetText;
    public TMPro.TextMeshProUGUI comnoteText;
    public Animator anim;
    public int sourcekey;
    [Header("Int")]
    [SerializeField] public int sel;

    public void Start()
    {
        sel = serversidecontroller.God.SC.sel;
        tweetText.text = serversidecontroller.God.SC.x[sel].post;
        comnoteText.text = serversidecontroller.God.SC.x[sel].communitynote;
        istrue = serversidecontroller.God.SC.x[sel].isfactual;
        sourcekey = serversidecontroller.God.SC.x[sel].sourcekey;
    }

    public void check(bool c)
    {
        anim.SetBool("rate", true);
        if (c == true && istrue == serversidecontroller.God.factuality.misinformation)
        {
            Debug.Log("no");
        }
        if (c == true && istrue == serversidecontroller.God.factuality.factual)
        {
            Debug.Log("yes");
        }
        if (c == false && istrue == serversidecontroller.God.factuality.misinformation)
        {
            Debug.Log("yes");
        }
        if (c == false && istrue == serversidecontroller.God.factuality.factual)
        {
            Debug.Log("no");
        }
    }

    public void sourcecheck()
    {
        if (sourcekey == serversidecontroller.God.SC.clipboard)
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
