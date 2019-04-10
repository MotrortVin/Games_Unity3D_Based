using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TrainCPR : MonoBehaviour
{
    public float trainTime = 60f;
    public bool trainFinished = false;

    private const float tolerance = 0.001f; //Chattering tolerance
    private const float maxPeriod = 60.0f;  //Maximum period
    private Vector3 posStart;
    private Vector3 prePos;
    private Vector3 period;
    private Vector3 preShift;
    public float locomotionTime = 0;
    private int lessThanFive = 0;
    private int improperFrequency = 0;
    public AudioClip wrongDepth;
    public AudioClip wrongFrequency;
    public AudioSource suggest;
    private bool isPlay = false;
    //public GameObject pressPoint;
    private bool ifpoint;
    private class Redirection
    {
        public bool x;
        public bool y;
        public bool z;
        public Redirection()
        {
            x = false;
            y = false;
            z = false;
        }
    }
    private Redirection redirection;

    public Vector3 shift;
    public Vector3 depth;
    public Vector3 frequency;
    private Text freqText;
    private Text depthText;
    private Text timeText;
    private int depthCalibration = 50;
    //public bool xr, yr, zr; //use for debug

    void Awake()
    {
        freqText = GameObject.Find("InformationGUI").transform.Find("InformationGUI/FreqText").gameObject.GetComponent<Text>();
        depthText = GameObject.Find("InformationGUI").transform.Find("InformationGUI/DepthText").gameObject.GetComponent<Text>();
        timeText = GameObject.Find("InformationGUI").transform.Find("InformationGUI/TimeText").gameObject.GetComponent<Text>();
        shift = new Vector3(0, 0, 0);
        preShift = new Vector3(0, 0, 0);
        depth = new Vector3(0, 0, 0);
        period = new Vector3(0, 0, 0);
        posStart = transform.localPosition;
        prePos = transform.localPosition;
        redirection = new Redirection();
    }




    public IEnumerator LocomotionTracker()
    {
        if (!trainFinished) do
            {
                locomotionTime += Time.deltaTime;
                //Chattering elimination
                if (Vector3.Distance(transform.localPosition, prePos) >= tolerance)
                {
                    shift = transform.localPosition - prePos;
                }

                //Judging the redirection of game object with tolerance
                //Compute the depth of the completed motion
                if (redirection.x = shift.x * preShift.x < 0)   //if redirect, compute the frequency and record the depth
                {
                    period.x += Time.deltaTime; //Accumulate motion time
                    depth.x = depthCalibration * System.Math.Abs(transform.localPosition.x - posStart.x);
                    posStart.x = transform.localPosition.x;
                    frequency.x = 60 / (2 * period.x);
                    period.x = 0;
                }
                else    //if maintain, just accumulate motion time
                {
                    period.x += Time.deltaTime; //Accumulate motion time
                                                //Avoid overflow
                    if (period.x >= maxPeriod)
                    {
                        period.x = 0;
                    }
                }

                if (redirection.y = shift.y * preShift.y < 0)   //if redirect, compute the frequency and record the depth
                {
                    period.y += Time.deltaTime; //Accumulate motion time
                    depth.y = depthCalibration * System.Math.Abs(transform.localPosition.y - posStart.y) < 1 ? depth.y : depthCalibration * System.Math.Abs(transform.localPosition.y - posStart.y);
                    posStart.y = transform.localPosition.y;
                    frequency.y = 60 / (2 * period.y) > 200 ? frequency.y : 60 / (2 * period.y);
                    period.y = 0;
                    if (depth.y < 5) { ++lessThanFive; }
                    if (frequency.y < 100) { ++improperFrequency; }
                }
                else    //if maintain, just accumulate motion time
                {
                    period.y += Time.deltaTime; //Accumulate motion time
                                                //Trick to avoid overflow
                    if (period.y >= maxPeriod)
                    {
                        period.y = 0;
                    }
                }

                if (redirection.z = shift.z * preShift.z < 0)
                {
                    period.z += Time.deltaTime; //Accumulate motion time
                    depth.z = depthCalibration * System.Math.Abs(transform.localPosition.z - posStart.z);
                    posStart.z = transform.localPosition.z;
                    frequency.z = 60 / (2 * period.z);
                    period.z = 0;
                }
                else    //if maintain, just accumulate motion time
                {
                    period.z += Time.deltaTime; //Accumulate motion time
                                                //Avoid overflow
                    if (period.z >= maxPeriod)
                    {
                        period.z = 0;
                    }
                }

                prePos = transform.localPosition;
                preShift = shift;
       
               
                freqText.text = "<b>Frequency</b>   " + System.Math.Floor(frequency.y).ToString();
                depthText.text = "<b>Depth</b>  " + System.Math.Floor(depth.y).ToString();
                timeText.text = "<b>Time</b>  " + System.Math.Floor(locomotionTime).ToString();
                if (lessThanFive ==20&&!isPlay) { suggest.clip = wrongDepth; isPlay = true; suggest.Play();isPlay = false; lessThanFive = 0; }
                if (improperFrequency == 20&&!isPlay) { suggest.clip = wrongFrequency;isPlay = true; suggest.Play(); isPlay = false; improperFrequency = 0; }
                yield return null;
                /*xr = redirection.x;
                yr = redirection.y;
                zr = redirection.z;*/
            } while (locomotionTime < trainTime);
        trainFinished = true;
    }
}

