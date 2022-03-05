using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Runtime.InteropServices;

public class JavaScriptUtility : MonoBehaviour
{
  [DllImport("__Internal")]
  private static extern void OpenLink(string link);
  void Start(){
  }

  public void SendToJs(string url){

    #if UNITY_WEBGL && !UNITY_EDITOR
    OpenLink(url);
    #endif
  }
}
