using System;
using System.IO;
using System.Collections;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization;
using UnityEngine;
using UnityEngine.UI;
using System.Text;
using System.Security.Principal;




public class Score : MonoBehaviour
{

    public static Score data; // static (?)

    public int itemValue;
    public int gameScore;
    public static bool kCoinCaught;

    public Text scoreText;

    private void Awake()
    {
        //print("Score.cs - Awake() had just been called.");
    }


    // Use this for initialization
    void Start()
    {
        data = this;
        //print("Score.cs - Start() has just been called.");
        if (File.Exists(Application.persistentDataPath + "/save.dat"))
            {
                BinaryFormatter bf = new BinaryFormatter();
                FileStream file = File.Open(Application.persistentDataPath + "/save.dat", FileMode.Open);
                ScoreData data = (ScoreData)bf.Deserialize(file);
                gameScore = data.gameScore;
                //kCoinCaught = data.kCoinCaught;
                file.Close();
            }
            //LoadWithSerializer();
        else
        {
            gameScore = 0;
            kCoinCaught = false;
        }
        UpdateScore();
        print("kCoinCaught = " + kCoinCaught);


    }

    private void SaveWithSerializer()
    {
        BinaryFormatter bf = new BinaryFormatter();
        //print("Save location for score via Score.cs:" + Application.persistentDataPath + " - in folder '/save.dat'");
        FileStream file = File.Create(Application.persistentDataPath + "/save.dat");

        ScoreData data = new ScoreData();
        data.itemValue = itemValue;
        data.gameScore = gameScore;
        //data.kCoinCaught = kCoinCaught;


        bf.Serialize(file, data);
        //print("SaveWithSerializer() just pushed the value: " + data);
        file.Close();
    }

    private void LoadWithSerializer()
    {
        if (File.Exists(Application.persistentDataPath + "/save.dat"))
        {
            BinaryFormatter bf = new BinaryFormatter();
            FileStream file = File.Open(Application.persistentDataPath + "/save.dat", FileMode.Open);
            ScoreData data = (ScoreData)bf.Deserialize(file);
            //print("LoadWithSerializer() just returned the value: " + gameScore);
            file.Close();

            itemValue = data.itemValue;
            gameScore = data.gameScore;
            //kCoinCaught = data.kCoinCaught;
        }

    }

    void OnTriggerEnter2D(Collider2D trigger)
    {
		AudioSource audio = GetComponent<AudioSource>();

        if (trigger.gameObject.tag == "CatchLevel1")
        {
            data.gameScore += data.itemValue;
            UpdateScore();
        }

        else if (trigger.gameObject.tag == "AvoidLevel1")
        {
			audio.Play();
			data.gameScore -= data.itemValue;
            UpdateScore();
        }

        else if (trigger.gameObject.tag == "CatchLevel2")
        {
            data.gameScore += data.itemValue * 2;
            UpdateScore();
        }

        if (trigger.gameObject.tag == "AvoidLevel2")
        {
			audio.Play();
			data.gameScore -= data.itemValue * 2;
            UpdateScore();
        }

        if (trigger.gameObject.tag == "CatchLevel3")
        {
			data.gameScore += data.itemValue * 3;
            UpdateScore();
        }

        if (trigger.gameObject.tag == "AvoidLevel3")
        {
			audio.Play();
			data.gameScore -= data.itemValue * 3;
            UpdateScore();
        }

        if (trigger.gameObject.tag == "CatchLevel4")
        {
            data.gameScore += data.itemValue * 4;
            UpdateScore();
        }

        if (trigger.gameObject.tag == "AvoidLevel4")
        {
			audio.Play();
			data.gameScore -= data.itemValue * 4;
            UpdateScore();
        }

        if (trigger.gameObject.tag == "K_coin")
        {
            kCoinCaught = true;
            print("A Kcoin has just been caught.");
            print("kCoinCaught value = " + kCoinCaught);
        }
         
    }
 
	//void OnCollisionEnter2D(Collision2D collision)
    //{
    //    if (collision.gameObject.tag == "Bomb")
    //    {
    //        data.gameScore -= data.itemValue * 2;
    //        UpdateScore();
    //    }
    //}

    void UpdateScore()
    {
        scoreText.text = "Score:\n" + data.gameScore;
        SaveWithSerializer();
        LoadWithSerializer();
        //print("UpdateScore() 'gameScore' = " + gameScore);
    }
    // Update is called once per frame
    //  void Update()
    //  {
    //print("Update is running.");

    //}     
}

[Serializable]
class ScoreData
{
    public int itemValue;
    public int gameScore;
    public bool kCoinCaught;
}