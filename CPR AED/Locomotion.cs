using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Locomotion : MonoBehaviour
{
	private const float tolerance = 0.001f; //Chattering tolerance
    private const float maxPeriod = 60.0f;  //Maximum period
	private Vector3 posStart;
	private Vector3 prePos;
    private Vector3 period;
    private Vector3 preShift;
    public float locomotionTime = 0;
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
    public Text freqText;
    public Text depthText;
    //public bool xr, yr, zr; //use for debug

    void Awake()
	{
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
        locomotionTime += Time.deltaTime;
        //Chattering elimination
        if (Vector3.Distance(transform.localPosition, prePos) >= tolerance)
		{
			shift = transform.localPosition - prePos;
		}

        //Judging the redirection of game object with tolerance
        //Compute the depth of the completed motion
        if (redirection.x = shift.x * preShift.x < 0)	//if redirect, compute the frequency and record the depth
		{
            period.x += Time.deltaTime;	//Accumulate motion time
            depth.x = System.Math.Abs(transform.localPosition.x - posStart.x);
			posStart.x = transform.localPosition.x;
            frequency.x = 60 / (2 * period.x);
            period.x = 0;
        }
        else	//if maintain, just accumulate motion time
        {
            period.x += Time.deltaTime;	//Accumulate motion time
            //Avoid overflow
            if (period.x >= maxPeriod)
            {
                period.x = 0;
            }
        }

		if (redirection.y = shift.y * preShift.y < 0)	//if redirect, compute the frequency and record the depth
		{
            period.y += Time.deltaTime;	//Accumulate motion time
            depth.y = System.Math.Abs(transform.localPosition.y - posStart.y);
            posStart.y = transform.localPosition.y;
            frequency.y = 60 / (2 * period.y);
            period.y = 0;
        }
        else	//if maintain, just accumulate motion time
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
            period.z += Time.deltaTime;	//Accumulate motion time
            depth.z = System.Math.Abs(transform.localPosition.z - posStart.z);
            posStart.z = transform.localPosition.z;
            frequency.z = 60 / (2 * period.z);
            period.z = 0;
        }
        else	//if maintain, just accumulate motion time
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
        freqText.text = "<b>Frequency</b>   " + System.Math.Floor(frequency.x).ToString();
        depthText.text = "<b>Depth</b>  "+ System.Math.Floor(depth.x).ToString();

        return null;
        /*xr = redirection.x;
        yr = redirection.y;
        zr = redirection.z;*/
    }
}