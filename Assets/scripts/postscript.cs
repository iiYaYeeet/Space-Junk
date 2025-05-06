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
    public CanvasGroup cg, correct_misninfo,wrong_misninfo,correct_truth,wrong_truth;

    public void Start()
    {
        serversidecontroller.God.SC.postsc.Add(this);
        sel = serversidecontroller.God.SC.sel;
        tweetText.text = serversidecontroller.God.SC.x[sel].post;
        comnoteText.text = serversidecontroller.God.SC.x[sel].communitynote;
        istrue = serversidecontroller.God.SC.x[sel].isfactual;
        sourcekey = serversidecontroller.God.SC.x[sel].sourcekey;
    }

    public void check(bool c)
    {
        if (c == true && istrue == serversidecontroller.God.factuality.misinformation)
        {
            wrong_misninfo.alpha = 1;
        }
        if (c == true && istrue == serversidecontroller.God.factuality.factual)
        {
            correct_truth.alpha = 1;
            serversidecontroller.God.SC.freeze(this);
            anim.SetBool("rate", true);
        }
        if (c == false && istrue == serversidecontroller.God.factuality.misinformation)
        {
            correct_misninfo.alpha = 1;
            serversidecontroller.God.SC.freeze(this);
            anim.SetBool("rate", true);
        }
        if (c == false && istrue == serversidecontroller.God.factuality.factual)
        {
            wrong_truth.alpha = 1;
        }
    }

    public void sourcecheck()
    {
        if (sourcekey == serversidecontroller.God.SC.clipboard)
        {
            anim.SetBool("rated", true);
        }
    }
    public void softlockprevention()
    {
        anim.SetBool("rate",false);
        serversidecontroller.God.SC.thaw(this);
    }

    public void dropdown()
    {
        if (anim.GetBool("selected"))
        {
            serversidecontroller.God.SC.thaw(this);
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
