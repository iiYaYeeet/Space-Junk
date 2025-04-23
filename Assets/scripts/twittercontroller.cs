using System.Collections;
using System.Collections.Generic;
using AYellowpaper.SerializedCollections;
using UnityEngine;

public class twittercontroller : MonoBehaviour
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
    //[Header("Audio")] 
    //Audio

        #region dictionary
        [System.Serializable] public class serializableClass
        {
            [TextArea(3, 10)] public string post;
            [TextArea(3, 10)] public string communitynote;
            public God.factuality isfactual;
        }
        public SerializedDictionary<int, serializableClass> dictionary;
        #endregion
    #endregion

    public static class God
    {
        public static twittercontroller TC;
        public enum factuality
        {
            factual,
            misinformation,
        }
    }
    void Awake()
    {
        God.TC = this;
    }

    void Start()
    {
        Debug.Log(dictionary[0].post);
        Debug.Log(dictionary[0].communitynote);
        Debug.Log(dictionary[0].isfactual);
    }

    void Update()
    {
        if (Input.GetMouseButton(0))
        {
            Debug.Log(Input.GetAxis("Mouse X"));
            parentrb.AddForce(transform.up*Input.GetAxis("Mouse Y")*20);
        }
    }
}

