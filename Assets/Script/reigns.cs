using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class reigns : DualBehaviour 
{
    #region Public Members
    public Image avatarImage;
    public Image [] avatars;
    public Image _avatarImage;
    public int _number;
    public string _nomImg;
    public Button _yesButton;
    public Button _noButton;
    public int _conteurYes;
    public int _conteurNo;
    #endregion

    #region Public Void

    #endregion

    #region System
    private void Awake()
    {
        _yesButton.onClick.AddListener(YesClick);
        _noButton.onClick.AddListener(NoClick);
    }


    void Start () 
    {
        _avatarImage.sprite = avatars[2];
      

       

    }

    void Update () 
    {
       
	}
   
    #endregion

    #region Tools Debug and Utility

    #endregion

    #region Private and Protected Members
   private void YesClick ()
    {

        Debug.Log("you cliked yes" + _conteurYes);
        changePic();
      

    }

    private void NoClick()
    {
        Debug.Log("you cliked no" + _conteurNo);
        changePic();

    }
    public void  changePic()
    {
        _number = Random.Range(2, 9);
        // _nomImg = _number.ToString() + ".png";
        _avatarImage.sprite = avatars[_number];

    }
    #endregion
}
