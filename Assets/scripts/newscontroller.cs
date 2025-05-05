using System.Collections;
using System.Collections.Generic;
using AYellowpaper.SerializedCollections;
using UnityEngine;

public class newscontroller : MonoBehaviour
{
    #region Declerations
    [Header("Components")] 
    public Rigidbody2D parentrb;
    //[Header("Bools")]
    //Bools
    //[Header("Floats")]
    //Floats
    //[Header("Ints")]
    //Floats
    [Header("Objects")] 
    public GameObject parent;
    public GameObject postprefab;
    public Transform spawnpos;
    public Collider2D col;
    //[Header("Audio")] 
    //Audio
    public bool freeze;
    #endregion

    void Awake()
    {
        serversidecontroller.God.NC = this;
    }

    void Start()
    {
        Application.targetFrameRate = 60;
    }

    void Update()
    {
        if (!freeze)
        {
            if (Input.GetMouseButton(0))
            {
                parentrb.AddForce(transform.up*Mathf.Abs(Input.GetAxis("Mouse Y")*20));
            }
        }
    }

    public void OnTriggerExit2D(Collider2D other)
    {
        if (parentrb.velocity.y >= 0)
        {
            GameObject post = Instantiate(postprefab, spawnpos.transform.position, Quaternion.identity);
            post.transform.parent = parent.transform;
        }
    }
}
