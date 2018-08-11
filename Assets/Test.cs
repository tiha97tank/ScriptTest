using UnityEngine;
using System.Collections;

public class Test : MonoBehaviour {
    // Use this for initialization
    void Start() {
        // 要素数5の配列を初期化する
        int[] array = { 10, 20, 30, 40, 50, 60 };

        // 条件１、配列の要素を順番に表示する
        for (int i = 0; i < array.Length; i++) {
            Debug.Log(array[i]);
        }
        //条件２、配列の要素を逆順に表示する
        for (int d = array.Length - 1; 0 <= d; d--) {
            Debug.Log(array[d]);
        }

    }
    
    // Update is called once per frame
    void Update() {

    }
}