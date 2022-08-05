using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scoring : MonoBehaviour
{
    public static int score = 0;
    //public static int pinsDown = 0;
    public static int strikes = 0;
    public static int[][] game = new int[2][] {new int[5] {0,0,0,0,0},new int[5] {0,0,0,0,0}};
    // public void scoring() {
    //     game = [[0;0;0;0;0;];[0;0;0;0;0;]];
    // }
    //not doing spares yet || Nono im doing them...
    //}

    public int calc(int[][] gameScores) {
        int currentScore = 0;
        int addedScore = 0;
        for(int j=0;j<gameScores.Length/2;j++) {
            if (gameScores[0][j]+gameScores[1][j] == 10) {
                addedScore+=gameScores[0][j];
            } else {
                currentScore+=gameScores[0][j]+gameScores[1][j]+addedScore;
            }
        }
        return currentScore;
    }
    private void Update() {
            print(calc(game));
        //print(game);
    }
}
