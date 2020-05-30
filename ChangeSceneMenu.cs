using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeSceneMenu : MonoBehaviour
{
    public int a;

   public void Change()
   {
        Application.LoadLevel(a);
   }

}
