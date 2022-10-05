using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ThisSucksUI : MonoBehaviour
{
    private ThisSucksPlayer playerScript;
    
    [SerializeField] TextMeshProUGUI HPtext;
    private int HP;
    
    [SerializeField] TextMeshProUGUI uselessPointsText;
    private int uselessPoints;
    
    [SerializeField] TextMeshProUGUI timeText;
    int time;
    bool ticking;
    
    // Start is called before the first frame update
    void Start()
    {
        playerScript = this.GetComponent<ThisSucksPlayer>();

        time = 0;
        ticking = true;
        StartCoroutine(Clock());
    }

    // Update is called once per frame
    void Update()
    {
        HP = playerScript.ReturnHP();
        HPtext.text = HP.ToString();
        
        uselessPoints = playerScript.UselessPoints();
        uselessPointsText.text = (uselessPoints.ToString());
        timeText.text = (time.ToString());
    }
    
    private IEnumerator Clock()
    {
        if (ticking)
        {
            yield return new WaitForSeconds(1f);

            time++;
            StartCoroutine(Clock());
        }


    }
}
