using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class middleSceneController : MonoBehaviour
{
    GameObject loadImage;
    float DETECT_TIME = 0.0003f;
    public Image progressBar;
    int LBUTT = 0;
    // Start is called before the first frame update
    void Start()
    {
        this.loadImage = GameObject.Find("sceneImage");
        this.loadImage.GetComponent<Image>().sprite = Resources.Load<Sprite>("design1/5");



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
        this.loadImage.GetComponent<Image>().sprite = Resources.Load<Sprite>("design1/6");

        //30초짜리 프로그래스바 진행
        StartCoroutine(LoadScene());

    }

    IEnumerator LoadScene()
    {
        yield return null;

        AsyncOperation oper = SceneManager.LoadSceneAsync("resultScene");
        //LoadSceneAsync ("게임씬이름"); 입니다.
        oper.allowSceneActivation = false;
        //allowSceneActivation 이 true가 되는 순간이 바로 다음 씬으로 넘어가는 시점입니다.

        float timer = 0.0f;
        while (!oper.isDone)
        {
            yield return null;

            timer += Time.deltaTime;
            Debug.Log(timer);

            if (progressBar.fillAmount == 1.0f)
            {
                oper.allowSceneActivation = true;
            }
            else
            {
                progressBar.fillAmount += DETECT_TIME;
            }

        }
    }
}
