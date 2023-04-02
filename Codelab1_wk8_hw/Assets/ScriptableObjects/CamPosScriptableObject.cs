using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


[CreateAssetMenu(
    fileName = "New CamPos",
    menuName = "ScriptableObjects/CamPos",
    order = 0)]
public class CamPosScriptableObject : ScriptableObject
{
    public string ThreeViewName;
    public Sprite thisview;

    public Camera camera;// cannot attach any asset to here


    public CamPosScriptableObject Front;
    public CamPosScriptableObject Side;
    public CamPosScriptableObject Vertical;
}
