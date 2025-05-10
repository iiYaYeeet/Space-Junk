using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class newsscript : MonoBehaviour
{
    [Header("Components")]
    public TMPro.TextMeshProUGUI source;
    public TMPro.TextMeshProUGUI article;
    public string link;
    [Header("Int")]
    [SerializeField] public int sel;
    public CanvasGroup cg;

    public void Start()
    {
        serversidecontroller.God.SC.rand();
        serversidecontroller.God.SC.newssc.Add(this);
        sel = serversidecontroller.God.SC.sel;
        source.text = serversidecontroller.God.SC.nws[sel].source;
        article.text = serversidecontroller.God.SC.nws[sel].article;
        link = serversidecontroller.God.SC.nws[sel].link;
    }

    public void OnCollisionEnter2D(Collision2D other)
    {
        Destroy(gameObject);
    }

    public void copy()
    {
        serversidecontroller.God.SC.clipboard = sel;
    }

    public void openlink()
    {
        Application.OpenURL(link);
    }
}
