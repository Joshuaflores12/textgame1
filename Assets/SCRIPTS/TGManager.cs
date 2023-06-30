using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEditor.Search;

public class TGManager : MonoBehaviour
{
    public TextMeshProUGUI storyTextMeshPro, hpTextMeshPro, statTextMeshPro;
    public string storyText;
    public int HPVAL, STAVAL;
    public GameObject Lvl1Choices,hp,st,hpv,stval, Lvl2Choices; //CALL LEVEL 1 BUTTONS

    // Start is called before the first frame update
    void Start()
    {
        Lvl2Choices.SetActive(false);
        storyText = "The Cave of Avalon was said to be the most\r\ndangerous cave out there, It is filled with\r\ndangerous and powerful mythical creatures";
    }

    // Update is called once per frame
    void Update()
    {
        storyTextMeshPro.text = storyText; // MAIN TEXT FOR STORY, THIS IS WHERE YOU INSERT BODY TEXT ETC ETC
        hpTextMeshPro.text = HPVAL.ToString(); //CALL FOR HP
        statTextMeshPro.text = STAVAL.ToString(); //CALL FOR STAMINA
    }

    public void start() //BUTTON3 
    {


        Lvl1Choices.SetActive(false);
        Lvl2Choices.SetActive(true); // shows second choices
        hp.SetActive(true);
        st.SetActive(true);
        hpv.SetActive(true);
        stval.SetActive(true) ;    
    }
    


    public void Exit() //BUTTON3 
    {


        Application.Quit();

    }
    public void EntertheCave() //BUTTON 1 
    {
        storyText = "You encountered a\r\nKing Chimera";
        HPVAL += 2;

        Lvl1Choices.SetActive(false); // level 1 buttons will disappear
        Lvl2Choices.SetActive(true); // shows second choices


    }
    public void Lookforadifferentquest() //BUTTON 2
    {
        storyText = "You chose a hunting quest\r\nand proceeds to hunt in the\r\nforest and see the 3 headed\r\ndeer";
        HPVAL += 10;

        Lvl1Choices.SetActive(false);
        Lvl2Choices.SetActive(true); // shows second choices
    }
    

    }


    
