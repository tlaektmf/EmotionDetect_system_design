using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class HMDSceneController : MonoBehaviour
{
    GameObject loadImage;
    int WAIT_TIME10 = 10;
    int WAIT_TIME60 = 60;
    int LBUTT = 0;
    // Start is called before the first frame update
    void Start()
    {
        this.loadImage = GameObject.Find("sceneImage");
        this.loadImage.GetComponent<Image>().sprite = Resources.Load<Sprite>("design1/11");
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

    public void LButtonClick()
    {
        StartCoroutine(showScreen());
    }

    public IEnumerator showScreen()
    {
        this.loadImage.GetComponent<Image>().sprite = Resources.Load<Sprite>("design1/12");
        yield return new WaitForSeconds(WAIT_TIME10);//WaitForSeconds객체를 생성해서 반환
        this.loadImage.GetComponent<Image>().sprite = Resources.Load<Sprite>("design1/13");
        yield return new WaitForSeconds(WAIT_TIME60);//WaitForSeconds객체를 생성해서 반환

    }

}
