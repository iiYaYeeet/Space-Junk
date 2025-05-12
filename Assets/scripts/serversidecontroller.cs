using System;
using System.Collections;
using System.Collections.Generic;
using AYellowpaper.SerializedCollections;
using UnityEngine;
using Random = UnityEngine.Random;

public class serversidecontroller : MonoBehaviour
{
    #region dictionary
    [System.Serializable] public class twitter
    {
        [TextArea(2, 10)] public string post;
        [TextArea(2, 10)] public string communitynote;
        public God.factuality isfactual;
        public int sourcekey;
    }
    [System.Serializable] public class news
    {
        public string source;
        [TextArea(2, 10)] public string article;
        [TextArea(2, 10)] public string link;
    }
    public SerializedDictionary<int, twitter> x;
    public SerializedDictionary<int, news> nws;
    #endregion
    public static class God
    {
        public static twittercontroller TC;
        public static newscontroller NC;
        public static serversidecontroller SC;
        public enum factuality
        {
            factual,
            misinformation,
        }
    }

    public List<postscript> postsc;
    public List<newsscript> newssc;
    public void Awake()
    {
        God.SC = this;
    }

    public int clipboard;
    public int sel;
    void Start()
    {
        Application.targetFrameRate = 60;
    }
    public void rand()
    {
        sel = Random.Range(0, x.Count);
    }

    public void freeze(postscript caller)
    {
        foreach (postscript ps in postsc)
        {
            ps.cg.blocksRaycasts = false;
            ps.cg.interactable = false;
        }
        caller.cg.blocksRaycasts = true;
        caller.cg.interactable = true;
        God.TC.freeze = true;
        God.NC.freeze = true;
    }
    public void thaw(postscript caller)
    {
        foreach (postscript ps in postsc)
        {
            ps.cg.blocksRaycasts = true;
            ps.cg.interactable = true;
        }
        God.TC.freeze = false;
        God.NC.freeze = false;
    }
}
