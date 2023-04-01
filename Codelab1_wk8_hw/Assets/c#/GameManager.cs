using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public TextMeshProUGUI view;

    public CamPosScriptableObject currentPosition;

    public Image imgSprite;
    
    public Button Front;
    public Button Side;
    public Button Vertica;


    // Start is called before the first frame update
    void Start()
    {
        //TextAsset fileText = Resources.Load<TextAsset>("Data");//TextAsset is looking for a file ends in .txt
        //Debug.Log(fileText.text); //.text = string output
        UpdatePosition();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    void UpdatePosition()
    {
        view.text = currentPosition.ThreeViewName;
        imgSprite.sprite = currentPosition.thisview;
        
        //front
        if (currentPosition.Front == null)
        {
            Front.gameObject.SetActive(false);
        }

        else
        {
            Front.gameObject.SetActive(true);
        }
        //side
        if (currentPosition.Side == null)
        {
            Side.gameObject.SetActive(false);
        }

        else
        {
            Side.gameObject.SetActive(true);
        }
        //vertical
        if (currentPosition.Vertical == null)
        {
            Vertica.gameObject.SetActive(false);
        }

        else
        {
            Vertica.gameObject.SetActive(true);
        }
    }

    public void MoveDirection(int dir)
    {
        switch (dir)
        {
            case 0:
                currentPosition = currentPosition.Front;
                break;
            case 1:
                currentPosition = currentPosition.Side;
                break;
            case 2:
                currentPosition = currentPosition.Vertical;
                break;
        }
        
        UpdatePosition();
    }
}
