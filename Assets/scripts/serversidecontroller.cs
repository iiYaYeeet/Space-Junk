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
        [TextArea(3, 10)] public string post;
        [TextArea(3, 10)] public string communitynote;
        public God.factuality isfactual;
        public int sourcekey;
    }
    [System.Serializable] public class news
    {
        public string source;
        [TextArea(3, 10)] public string article;
        [TextArea(3, 10)] public string link;
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
}
