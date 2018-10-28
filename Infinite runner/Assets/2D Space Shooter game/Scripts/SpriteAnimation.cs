using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpriteAnimation : MonoBehaviour
{

    public string animationName = "Sprite Animation Name!";
    public Material sheetMaterial;
    public Texture sheetTexture;
    public bool loop = true;
    public bool playOnAwake = true;
    public float updateRate = 1f; // update rate in seconds
    public int totalFrames;
    public int currentFrame = 1; //used as the starting frame and progress tracker
    public float sheetWidth = 8f; //number of tiles across
    public float sheetHeight = 8f;//number of tiles tall
    public int tileWidth; // width in pixels of individual tiles
    public int tileHeight; // height in pixels of individual tiles
    private bool isPlaying;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log("Update: " + animationName);
    }
    void Awake()

    {

        GetComponent<Renderer>().material = sheetMaterial;

        if (playOnAwake) //used to trigger simple animated sprits on creation

        {

            Play();

        }

    }

    // play an animation!

    public void Play()

    {

#if DEBUG

        Debug.Log("Play: " + animationName);

#endif

        if (!isPlaying)

        {

            isPlaying = true;

            sheetMaterial.mainTexture = sheetTexture;

            StartCoroutine(Draw());
        }
    }
    //Draw Coroutine

    public IEnumerator Draw()

    {

        while (isPlaying)

        {

#if DEBUG

            Debug.Log("Draw: " + animationName);

#endif

            //Determine the frame position

            int offsetX = (currentFrame - 1) % (int)sheetWidth;

            int offsetY = (currentFrame - 1) / (int)sheetWidth;

            //Set the texture to the indicated offset

            sheetMaterial.mainTextureOffset = new Vector2(offsetX / sheetWidth,

            1f - ((offsetY + 1) / sheetHeight));

            //Set the scale of the texture

            sheetMaterial.mainTextureScale = new Vector2(1f / sheetWidth, 1f / sheetHeight);


            //post increment the frame counter for our next loop iteration

            currentFrame++;

            if (currentFrame > totalFrames)

            {

                if (loop)

                {

                    currentFrame = 1;

                }

                else

                {

                    // stop at the last frame

                    currentFrame = totalFrames;

                    isPlaying = false;

                }

            }

            // run the loop again after a short delay based on our frame rate.

            if (isPlaying)

            {

                yield return new WaitForSeconds(updateRate);

            }

        }//End of While Loop


        #if DEBUG

        Debug.Log("Ended: " + animationName);

        #endif

        //exit drawing coroutine

        yield return null;
    }


        //stop the animation!

        public void Stop()

        {

            #if DEBUG

             Debug.Log("Stop: " + animationName);

            #endif

             isPlaying = false;

            currentFrame = 1;

        }

}//end of sprite animation class

