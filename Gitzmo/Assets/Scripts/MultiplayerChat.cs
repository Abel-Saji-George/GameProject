using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Fusion;


public class MultiplayerChat : NetworkBehaviour
{
    public Text _messages;
    public Text input;
    public Text usernameInput;
    public string username='Default';
    public void SetUserName(){
        username=usernameInput.text;
    }
}
