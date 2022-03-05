using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RepositoryTrigger : MonoBehaviour
{
    public string url;
    JavaScriptUtility jsUtility;
    void Start()
    {
        jsUtility = FindObjectOfType<JavaScriptUtility>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter2D(Collider2D collider)
    {
        if(collider.tag == "Player"){
            Debug.Log(url);
            jsUtility.SendToJs(url);
        }
    }
}
