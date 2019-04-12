using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class BothSceneController : MonoBehaviour
{
    GameObject loadImage;
    float DETECT_TIME = 0.0003f;
    public Image progressBar;

    int WAIT_TIME10 = 10;
    int LBUTT = 0;
    int count = 5;
    // Start is called before the first frame update
    void Start()
    {
        this.loadImage = GameObject.Find("sceneImage");

        this.loadImage.GetComponent<Image>().sprite = Resources.Load<Sprite>("design1/4");


    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButton(LBUTT))
        {
            Debug.Log("Left Mouse Button Down");
            LButtonClick();
        }

    }

    void LButtonClick()
    {
        SceneManager.LoadScene("middleScene");
      

    }
   

}