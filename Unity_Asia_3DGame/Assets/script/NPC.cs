using UnityEngine;
using UnityEngine.UI;

public class NPC : MonoBehaviour
{
    [Header("NPC 資料")]
    public NPCData Data;
    [Header("對話框")]
    public GameObject dialog;
    [Header("對話內容")]
    public Text textContent;

    public bool playerInArea;

    private void OnTriggerEnter(Collider other)
    {
        if (other.name =="小明")
        {
            playerInArea = true;
            Dialog();
        }
    }
    
    private void OnTriggerExit(Collider other)
    {
        if (other.name =="小明")
        {
            playerInArea = false;
        }      
    }

    private void Dialog()
    {

        //print(Data.dialogA);
        //print(Data.dialogA[10]);

        //for(int i=0; i<10;i++)
        //{
        //    print("我是迴圈:" + 1);
        //}
        for (int i = 0; i < Data.dialogA.Length; i++) 
        {
            print(Data.dialogA[i]);
        }
    }


}
