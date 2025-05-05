using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class switcher : MonoBehaviour
{
    public bool twitter;
    public bool news;
    public Animator anim;

    public void twitterswitcher()
    {
        if (!twitter)
        {
            anim.Play("twittermove");
            news = false;
            twitter = true;
        }
    }
    public void newsswitcher()
    {
        if (!news)
        {
            anim.Play("newsmove");
            news = true;
            twitter = false;
        }
    }
}
