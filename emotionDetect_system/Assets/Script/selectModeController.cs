using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.IO;
public class selectModeController : MonoBehaviour
{
    static int BRAIN_WAVE = 0;
    static int FACE = 1;
    static int BOTH = 2;
    static int select;

    GameObject loadImage;
    string m_strPath = "Assets/Resources/select.txt";

    // Start is called before the first frame update
    void Start()
    {
        this.loadImage = GameObject.Find("sceneImage");
        ///this.loadImage.GetComponent<Image>().sprite = Resources.Load<Sprite>("design1/3");
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void brainWaveEmotion()
    {
        select = BRAIN_WAVE;
        ///////////////////////////////////
        /*
         * 파일 입출력 부분
         * 
         */
        writeData(select);
        ///////////////////////////////////////
        SceneManager.LoadScene("BrainWaveScene");
    }

    public void faceEmotion()
    {
        select = FACE;
        ///////////////////////////////////
        /*
         * 파일 입출력 부분
         */
        writeData(select);
        ///////////////////////////////////////
        SceneManager.LoadScene("FaceScene");
    }
    public void both()
    {
        select = BOTH;
        ///////////////////////////////////
        /*
         * 파일 입출력 부분
         */
        writeData(select);
        ///////////////////////////////////////
        SceneManager.LoadScene("BothScene");
    }

    public void writeData(int strData)
    {
        string data = null;
        if (strData == BRAIN_WAVE)
        {
            data = "brain";
        }
        else if (strData == FACE)
        {
            data = "face";
        }else if (strData == BOTH)
        {
            data = "both";
        }

        StreamWriter sw = new StreamWriter(m_strPath,false);
        sw.WriteLine(data);
        sw.Close();



    }
}
