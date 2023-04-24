using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Player : MonoBehaviour
{
    #region Singleton

    public static Player instance;

    private void Awake()
    {
        instance = this;
    }

    #endregion
    
    public GameObject LosePanrl;
    public GameObject player;
    public int score;
    public int life;
    public int level;
    public float xp;
    public float maxXP;
    public Text scoreText;
    public Text lifeText;
    public Text levelText;
    

    // Start is called before the first frame update
    void Start()
    {
        
        level = 1;
        score = 0;
        life = 3;
        CaculatorXP();
        levelText.text = "Level: " + level;
        scoreText.text = "Score: " + score;
        lifeText.text = "Live: " + life;
        
    }

    // Update is called once per frame
    void Update()
    {
        if(score > 100)
        {
            score -= 100;
            Addlife();
        }
        if(xp > maxXP)
        {
            LevelUp();
        }
        if(life == 0)
        {
            LosePanrl.SetActive(true);

            Time.timeScale = 0f;
        }
    }
    public void Addscore()
    {
        score++;
        scoreText.text = "Score: "+ score;
    }
    public void Addlife()
    {
        life++;
        lifeText.text = "Live: "+life;
    }
    public void Reducelife()
    {
        life--;
        lifeText.text = "Live: " + life;
    }
    public void AddXP(float XPreceive)
    {
        xp += XPreceive;
    }
    public void CaculatorXP()
    {
        maxXP = (20 + level) / 2;
    }
    public void LevelUp()
    {
        
            level++;
            xp-=maxXP;
            CaculatorXP();
            levelText.text = "Level: " + level;
        
    }
}
