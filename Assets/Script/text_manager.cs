using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class text_manager : MonoBehaviour
{
    public GameObject Mainmenu, Ingame, decision1_0, decision1_1, decision1_2, decision1_3, decision1_4, decision1_5, decision1_6, decision1_7;
    public string Story_1;
    public TextMeshProUGUI Story, Hp_value;
    public int hp;

    // Start is called before the first frame update
    void Start()
    {
        Ingame.SetActive(false);

    }

    // Update is called once per frame
    void Update()
    {
        Story.text = Story_1;
        Hp_value.text = hp.ToString();
        if (hp == 0)
        {
            SceneManager.LoadScene("LoseScreen");
        }
        

    }
    public void start()
    {
        Ingame.SetActive(true);
        Mainmenu.SetActive(false);
        decision1_1.SetActive(false);
        decision1_2.SetActive(false);
        decision1_3.SetActive(false);
        decision1_4.SetActive(false);
        decision1_5.SetActive(false);
        decision1_6.SetActive(false);
        decision1_7.SetActive(false);
        
        
    }
    public void exit()
    {
        Application.Quit();
    }
    public void choice1_0() //Enter the Cave
    {
        Story_1 = "You encountered a\r\nKing Chimera";
        decision1_0.SetActive(false);
        decision1_1.SetActive(true);
    }
    public void choice1_1() //Look for a different quest
    {
        Story_1 = "You chose a hunting quest\r\nand proceeds to hunt in the\r\nforest and see the 3 headed\r\ndeer";
        decision1_0.SetActive(false);
        decision1_3.SetActive(true);
        
    }
    public void choice1_2() // Fight
    {
        Story_1 = "You have beaten the\r\nChimera and found a\r\ntreasure chest";
        decision1_1.SetActive(false);
        decision1_2.SetActive(true);
    }   
    public void choice1_3() // Run away
    {
        Story_1 = "Look for a different\r\nquest";
        decision1_1.SetActive(false);
        decision1_0.SetActive(true);
    }
    
    public void choice1_4() // Open
    {
        Story_1 = "You have opened it\r\nand have been eaten\r\nby a Mimic and you have died";
        decision1_2.SetActive(true);
        decision1_2.SetActive(false);
        
        hp -= 100;

    }
    public void choice1_5() // Don't open 
    {
        Story_1 = "Run away";
        decision1_2.SetActive(false);
        decision1_1.SetActive(true);
    }
    public void choice1_6() // Kill
    {
        Story_1 = "You go back to the guild to get\r\nyour bounty, You received your\r\nbounty and get blocked by 3\r\nadventurers";
        decision1_3.SetActive(false);
        decision1_4.SetActive(true);
    }
    public void choice1_7() //Trap it 
    {
        Story_1 = "You go back to the guild to get\r\nyour bounty, You received your\r\nbounty and get blocked by 3\r\nadventurers";
        decision1_3.SetActive(false);
        decision1_4.SetActive(true);   
    }
    public void choice1_8() //Fight them all
    {
        Story_1 = "You lost and died";
        decision1_4.SetActive(false);
        
        hp -= 100;

    }
    public void choice1_9() //Run away
    {
        Story_1 = "You start Training to get stronger\r\nin the forest\r\nSuddenly you start to hear an\r\neerie sound";
        decision1_4.SetActive(false);
        decision1_5.SetActive(true);
    }
    public void choice1_10() // Look where is the origin of the sound

    {
        Story_1 = "You wander into the mysterious forest,\r\nAnd get closer to the sound and encountered\r\nA mysterious beast";
        decision1_5.SetActive(false);
        decision1_6.SetActive(true);
    }
    public void choice1_11() // Ignore it and continue training 
    {
        Story_1 = "You finished your training routine and\r\nlooked for a different beast to hunt, Upon\r\nexploring the forest you saw a beast\r\nthat has a high bounty value";
        decision1_5.SetActive(false);
        decision1_7.SetActive(true);

    }
    public void choice1_12()  // Interact with the beast
    {
        Story_1 = "You interacted with the beast and it\r\nglances at you\r\nIt’s face is split into 3 and eat you alive";
       
        hp -= 100;
    }
    public void choice1_13() // Go back into training
    {
        Story_1 = "Ignore it and continue training";
        decision1_6.SetActive(false);
        decision1_5.SetActive(true);
    }
    public void choice1_14()
    {
        Story_1 = "You have killed a beast and get\r\nit's bounty";
        decision1_7.SetActive(false);
        
    }
    public void choice1_15()
    {
        Story_1 = "You have killed a beast and get\r\nit's bounty";
        decision1_7.SetActive(false);
        SceneManager.LoadScene("WinScreen");
    }


}





    