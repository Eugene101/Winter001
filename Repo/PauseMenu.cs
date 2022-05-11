using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class PauseMenu 
{
    

   public static void StopGame()
    {
        Time.timeScale = 0;
  
    }

    public static void ResumeGame()
    {
        Time.timeScale = 1;
  
    }
}
