using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class startSceneController : MonoBehaviour
{
    GameObject loadImage;
    int WAIT_TIME10 = 10;
    int WAIT_TIME5 = 5;
    

    // Start is called before the first frame update
    void Start()
    {
        this.loadImage = GameObject.Find("sceneImage");
        StartCoroutine(showScreen());
    }

    // Update is called once per frame
    void Update()
    {
        
        
    }

    public IEnumerator showScreen()
    {
        this.loadImage.GetComponent<Image>().sprite = Resources.Load<Sprite>("design1/1");
        yield return new WaitForSeconds(WAIT_TIME10);//WaitForSeconds객체를 생성해서 반환
        this.loadImage.GetComponent<Image>().sprite = Resources.Load<Sprite>("design1/2");
        yield return new WaitForSeconds(WAIT_TIME5);//WaitForSeconds객체를 생성해서 반환
       
        SceneManager.LoadScene("selectModeScene");

    }
}
