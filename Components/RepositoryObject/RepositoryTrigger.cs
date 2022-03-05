using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RepositoryTrigger : MonoBehaviour
{
    public string repoUrl;
    public string pagesUrl;
    JavaScriptUtility jsUtility;
    [SerializeField]
    private bool _occupied = false;
    void Start()
    {
        jsUtility = FindObjectOfType<JavaScriptUtility>();
    }
    void Update()
    {
        if(Input.GetButtonDown("Repository") && _occupied)
        {
            OpenLink(repoUrl);
        }
        if(Input.GetButtonDown("Pages") && _occupied && pagesUrl != "")
        {
            OpenLink(pagesUrl);
        }
    }


    void OnTriggerEnter2D(Collider2D collider)
    {
        if(collider.tag == "Player")
        {
        _occupied = true;
        }
    }
    void OnTriggerExit2D(Collider2D collider)
    {
        if(collider.tag == "Player")
        {
            _occupied = false;
        }
    }
    void OpenLink(string url)
    {
        Debug.Log(url);
        jsUtility.SendToJs(url);
    }
}
