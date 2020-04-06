using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

public class finish : MonoBehaviour
{
    public LevelChanger levelChanger;
    public GameObject Screen;
    public GameObject Player;

    void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.tag == "Player")
        {
            if (Player.GetComponent<PlayerMovement>().hasGiveKey == true)
            {
                Screen.transform.Find("Key").gameObject.SetActive(false);
                Player.GetComponent<HealthScore>().SavePlayerBoy();

                string boyElems = Application.persistentDataPath + "/saves.boy";
                string girlElems = Application.persistentDataPath + "/saves.girl";

                if (File.Exists(boyElems) && File.Exists(girlElems))
                {
                    BinaryFormatter formatter = new BinaryFormatter();
                    FileStream streamBoy = new FileStream(boyElems, FileMode.Open);
                    FileStream streamGirl = new FileStream(girlElems, FileMode.Open);

                    PlayerDataBoy dataBoy = formatter.Deserialize(streamBoy) as PlayerDataBoy;
                    PlayerDataBoy dataGirl = formatter.Deserialize(streamGirl) as PlayerDataBoy;

                    streamBoy.Close();
                    streamGirl.Close();

                    if (dataBoy.score == 3 && dataGirl.score == 3)
                    {
                        levelChanger.FadeToNextLevel(9);
                    }
                    else
                        levelChanger.FadeToNextLevel(8);
                }

                
            }
        }
    }
}
