using UnityEngine;
using UnityEngine.UI;
using System.Collections;


public class NPC : MonoBehaviour
{
    [Header("NPC 資料")]
    public NPCData Data;
    [Header("對話框")]
    public GameObject dialog;
    [Header("對話內容")]
    public Text textContent;
    [Header("對話間隔")]
    public float interval = 0.2f;

    public bool playerInArea;

/**
    private void Start()
    {
        StartCoroutine(Test());

    }

    private IEnumerator Test()
    {
        print("嗨");
        yield return new WaitForSeconds(1.5f);
        print("嗨!我是一點五秒後");
        yield return new WaitForSeconds(2);
        print("嗨，又過去兩秒了");
    }
*/

    private void OnTriggerEnter(Collider other)
    {
        if (other.name =="小明")
        {
            playerInArea = true;
            StartCoroutine(Dialog());
        }
    }
    
    private void OnTriggerExit(Collider other)
    {
        if (other.name =="小明")
        {
            playerInArea = false;
        }      
    }

    private IEnumerator Dialog()
    {

        //print(Data.dialogA);
        //print(Data.dialogA[10]);

        //for(int i=0; i<10;i++)
        //{
        //    print("我是迴圈:" + 1);
        //}

        dialog.SetActive(true);
        textContent.text = "";

        for (int i = 0; i < Data.dialougA.Length; i++) 
        {
            //print(Data.dialougA[i]);
            textContent.text = Data.dialougA[i] + "";
            yield return new WaitForSeconds(interval);
        }
    }


}
