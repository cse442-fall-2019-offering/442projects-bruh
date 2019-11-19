using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class PlayerNameDisplay : MonoBehaviour
{
    public TMP_Text playerName;
    // Start is called before the first frame update
    void Start()
    {
        playerName.text = GameInfo.PlayerName;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
}
