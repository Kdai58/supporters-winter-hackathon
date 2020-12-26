using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ResultScript : MonoBehaviour
{
    public Text ResultText;
    void Start()
    {

        if(PlayerScript.HP==100){
            ResultText.text="評価:S　グゥゥゥレェィトゥ!!!!!\n"+
            "クリア時間:"+ TimeController.minute.ToString("00") + ":" + ((int) TimeController.seconds).ToString ("00");
        }else if(PlayerScript.HP>=50){
            ResultText.text="評価:A　よくできました。\n"+
            "クリア時間:"+ TimeController.minute.ToString("00") + ":" + ((int) TimeController.seconds).ToString ("00");
        }else{
            ResultText.text="評価:B　もうちょっと頑張ろうね。\n"+
            "クリア時間:"+ TimeController.minute.ToString("00") + ":" + ((int) TimeController.seconds).ToString ("00");
        }
    }

}
