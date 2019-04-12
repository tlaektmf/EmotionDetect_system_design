using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.IO;

public class resultSceneController : MonoBehaviour
{
    int WAIT_TIME10 = 10;
    string emotion;
    GameObject loadImage;
    // Start is called before the first frame update
    void Start()
    {
        this.loadImage = GameObject.Find("sceneImage");
       
    }

    // Update is called once per frame
    void Update()
    {
        readFile();
    }

    public void readFile()
    {
        //파일을 읽어서 감정 보여주기(string emotion에 저장)
        TextAsset data = Resources.Load("emotion", typeof(TextAsset)) as TextAsset;
        StringReader sr = new StringReader(data.text);

        string line;
        emotion = sr.ReadLine();
        //while (line != null)
        //{
        //    Debug.Log(line);
        //    line = sr.ReadLine();
        //}
       /// emotion = line;
        Debug.Log(emotion);
        this.loadImage.GetComponent<Image>().sprite = Resources.Load<Sprite>("design1/"+emotion);
        StartCoroutine(showScreen());
    }

    public IEnumerator showScreen()
    {
        
        yield return new WaitForSeconds(WAIT_TIME10);//WaitForSeconds객체를 생성해서 반환
      
        SceneManager.LoadScene("HMDScene");

    }
}
