using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class objectif : MonoBehaviour
{
    private int state;

    public static float finalScore;
    private float[] listX,listZ;

    private float SoundTimer;
    private float MaxST = 2f;

    [SerializeField]
    private AudioSource dingSource;
    // Start is called before the first frame update
    void Start()
    {
        dingSource = GetComponent<AudioSource>();

        SoundTimer = MaxST;

        state = 0;
        listX = new float[10];
        listZ = new float[10];

        listX[0] = 25;
        listX[1] = 50;
        listX[2] = 75;
        listX[3] = 100;
        listX[4] = 125;
        listX[5] = 150;
        listX[6] = 175;
        listX[7] = 200;
        listX[8] = 225;
        listX[9] = 250;

        listZ[0] = 0;
        listZ[1] = 25;
        listZ[2] = -6;
        listZ[3] = -32;
        listZ[4] = 38;
        listZ[5] = -5;
        listZ[6] = 32;
        listZ[7] = -36;
        listZ[8] = 4;
        listZ[9] = 50;

        transform.position = new Vector3(listX[0],0,listZ[0]);
    }

    // Update is called once per frame
    void Update()
    {
        SoundTimer -= Time.deltaTime;
        if (SoundTimer < 0f){
            SoundTimer = MaxST;
            dingSource.Play();
        }
    }

    void OnTriggerStay(Collider other){
        if (state <= 8){
            Timer.remainingTime += 10f;
            CacheTimer.remaining += 10f;
            state ++;
            ChangeObjectif(state);
        }else{
            finalScore = Mathf.Floor(100f * Timer.remainingTime);
        }
    }
    
    void ChangeObjectif(int target){
        transform.position = new Vector3(listX[target],0,listZ[target]);
    }
}
