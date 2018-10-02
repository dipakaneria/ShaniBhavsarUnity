using System.IO;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using System.Text;
using UnityEngine.UI;
using System.Runtime.Serialization.Formatters.Binary;


public class FinalScene : MonoBehaviour
{

    private static Score data;
    public int gameScore;
    public Text scoreText;
    public Text kCoinText;
    public Text noKCoinText;
    public GameObject kCoin;




    private void Start()
    {
        if (File.Exists(Application.persistentDataPath + "/save.dat"))
        {
            BinaryFormatter bf = new BinaryFormatter();
            FileStream file = File.Open(Application.persistentDataPath + "/save.dat", FileMode.Open);
            ScoreData scoredata = (ScoreData)bf.Deserialize(file);
            gameScore = scoredata.gameScore;
            file.Close();
        }
        else
        {
            gameScore = 0;
        }

        //ScoreText();
        scoreText.text = "You scored " + gameScore.ToString() + " points - great job!\n" +
            "Sign in to add your score\nto the leaderboard\n" +
            "to win the monthly\nhigh score prize.";
        print("Final Scene - Kcoin caught = " + Score.kCoinCaught);
        if(Score.kCoinCaught == true)
        {
            kCoin.SetActive(true);
            kCoinText.gameObject.SetActive(true);
            kCoinText.text = "You also caught a Kcoin!\nShow this screen\n" +
            "(or grab a screenshot)\n and show it to your barista\n" +
            "for a free drip coffee.";
        }
        else
        {
            noKCoinText.gameObject.SetActive(true);
            noKCoinText.text = "Catch the gold KCoin next time\n" +
                "and win a special prize immediately.";
        }

    }


    private void Update()
    {

    }

    //public void ScoreText ()
    //{
    //    scoreText.text = "You scored\n" + gameScore.ToString() + " points!\nGreat job!";
    //}


    public void StartNewSession()
    {
        File.Delete(Application.persistentDataPath + "/gameCount.dat");
        File.Delete(Application.persistentDataPath + "/save.dat");
        Score.kCoinCaught = false;
        print("Final Scene - StartNewSession - kCoinCaught = " + Score.kCoinCaught);
        SceneManager.LoadScene("Gameplay");
    }

}
