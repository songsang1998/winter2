using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Audios : MonoBehaviour
{
    public AudioClip[] bgm;
    int requst = 0;
    
    // Start is called before the first frame update


    // Update is called once per frame
    public void StartAudio(int i)
    {
        if(i>=1 && i <= 15)
        {
            if (requst != 1)
            {
                GetComponent<AudioSource>().clip = bgm[0];
                GetComponent<AudioSource>().Play();
                requst = 1;
            }
           
        }else if (i >= 16 && i <= 34)
        {
            if (requst != 7)
            {
                GetComponent<AudioSource>().clip = bgm[6];
                GetComponent<AudioSource>().Play();
                requst = 7;
            }

        }
        else if (i >= 35 && i <= 39)
        {
            if (requst != 1)
            {
                GetComponent<AudioSource>().clip = bgm[0];
                GetComponent<AudioSource>().Play();
                requst = 1;
            }

        }
        else if (i >= 40 && i <= 76)
        {
            if (requst != 7)
            {
                GetComponent<AudioSource>().clip = bgm[6];
                GetComponent<AudioSource>().Play();
                requst = 7;
            }

        }
        else if (i >= 77 && i <= 87)
        {
            if (requst != 1)
            {
                GetComponent<AudioSource>().clip = bgm[0];
                GetComponent<AudioSource>().Play();
                requst = 1;
            }

        }
        else if (i >= 88 && i <= 99)
        {
            if (requst != 7)
            {
                GetComponent<AudioSource>().clip = bgm[6];
                GetComponent<AudioSource>().Play();
                requst = 7;
            }

        }
        else if (i >= 100 && i <= 102)
        {
            if (requst != 4)
            {
                GetComponent<AudioSource>().clip = bgm[3];
                GetComponent<AudioSource>().Play();
                requst = 4;
            }

        }
        else if (i >= 103 && i <= 112)
        {
            if (requst != 7)
            {
                GetComponent<AudioSource>().clip = bgm[6];
                GetComponent<AudioSource>().Play();
                requst = 7;
            }

        }
        else if (i >= 113 && i <= 115)
        {
            if (requst != 4)
            {
                GetComponent<AudioSource>().clip = bgm[3];
                GetComponent<AudioSource>().Play();
                requst = 4;
            }

        }
        else if (i >= 116 && i <= 120)
        {
            if (requst != 1)
            {
                GetComponent<AudioSource>().clip = bgm[0];
                GetComponent<AudioSource>().Play();
                requst = 1;
            }

        }
        else if (i >= 121 && i <= 158)
        {
            if (requst != 9)
            {
                GetComponent<AudioSource>().clip = bgm[8];
                GetComponent<AudioSource>().Play();
                requst = 9;
            }

        }
        else if (i >= 159 && i <= 167)
        {
            if (requst != 1)
            {
                GetComponent<AudioSource>().clip = bgm[0];
                GetComponent<AudioSource>().Play();
                requst = 1;
            }

        }
        else if (i >= 168 && i <= 202)
        {
            if (requst != 7)
            {
                GetComponent<AudioSource>().clip = bgm[6];
                GetComponent<AudioSource>().Play();
                requst = 7;
            }

        }
        else if (i >= 203 && i <= 206)
        {
            if (requst != 4)
            {
                GetComponent<AudioSource>().clip = bgm[3];
                GetComponent<AudioSource>().Play();
                requst = 4;
            }

        }
        else if (i >= 207 && i <= 208)
        {
            if (requst != 7)
            {
                GetComponent<AudioSource>().clip = bgm[6];
                GetComponent<AudioSource>().Play();
                requst = 7;
            }

        }
        else if (i >= 209 && i <= 210)
        {
            if (requst != 8)
            {
                GetComponent<AudioSource>().clip = bgm[7];
                GetComponent<AudioSource>().Play();
                requst = 8;
            }

        }
        else if (i >= 211 && i <= 213)
        {
            if (requst != 1)
            {
                GetComponent<AudioSource>().clip = bgm[0];
                GetComponent<AudioSource>().Play();
                requst = 1;
            }

        }
        else if (i >= 214 && i <= 243)
        {
            if (requst != 4)
            {
                GetComponent<AudioSource>().clip = bgm[3];
                GetComponent<AudioSource>().Play();
                requst = 4;
            }

        }
        else if (i >= 244 && i <= 249)
        {
            if (requst != 1)
            {
                GetComponent<AudioSource>().clip = bgm[0];
                GetComponent<AudioSource>().Play();

                requst = 1;
            }

        }
        else if (i == 250)
        {
            if (requst != 6)
            {
                GetComponent<AudioSource>().clip = bgm[5];
                GetComponent<AudioSource>().Play();
                requst =6;
            }

        }
        else if (i == 251)
        {
            if (requst != 3)
            {
                GetComponent<AudioSource>().clip = bgm[2];
                GetComponent<AudioSource>().Play();
                requst = 3;
            }

        }
        else if (i >= 252 && i <= 260)
        {
            if (requst != 1)
            {
                GetComponent<AudioSource>().clip = bgm[0];
                GetComponent<AudioSource>().Play();
                requst = 1;
            }

        }
        else if (i >= 261 && i <= 280)
        {
            if (requst != 7)
            {
                GetComponent<AudioSource>().clip = bgm[6];
                GetComponent<AudioSource>().Play();
                requst = 7;
            }

        }
        else if (i >= 281 && i <= 285)
        {
            if (requst != 4)
            {
                GetComponent<AudioSource>().clip = bgm[3];
                GetComponent<AudioSource>().Play();
                requst = 4;
            }

        }
        else if (i ==286)
        {
            if (requst != 1)
            {
                GetComponent<AudioSource>().clip = bgm[0];
                GetComponent<AudioSource>().Play();
                requst = 1;
            }

        }
        else if (i >= 287 && i <= 308)
        {
            if (requst != 7)
            {
                GetComponent<AudioSource>().clip = bgm[6];
                GetComponent<AudioSource>().Play();
                requst = 7;
            }

        }
        else if (i >= 309 && i <= 327)
        {
            if (requst != 4)
            {
                GetComponent<AudioSource>().clip = bgm[3];
                GetComponent<AudioSource>().Play();
                requst = 4;
            }

        }
        else if (i >= 328 && i <= 333)
        {
            if (requst != 2)
            {
                GetComponent<AudioSource>().clip = bgm[1];
                GetComponent<AudioSource>().Play();
                requst = 2;
            }

        }
        else if (i >= 334 && i <= 341)
        {
            if (requst != 1)
            {
                GetComponent<AudioSource>().clip = bgm[0];
                GetComponent<AudioSource>().Play();
                requst = 1;
            }

        }
        else if (i >= 342 && i <= 361)
        {
            if (requst != 2)
            {
                GetComponent<AudioSource>().clip = bgm[1];
                GetComponent<AudioSource>().Play();
                requst = 2;
            }

        }
        else if (i >= 362 && i <= 363)
        {
            if (requst != 4)
            {
                GetComponent<AudioSource>().clip = bgm[3];
                GetComponent<AudioSource>().Play();
                requst = 4;
            }

        }
        else if (i >= 364 && i <= 376)
        {
            if (requst != 1)
            {
                GetComponent<AudioSource>().clip = bgm[0];
                GetComponent<AudioSource>().Play();
                requst = 1;
            }

        }
        else if (i >= 377 && i <= 396)
        {
            if (requst != 4)
            {
                GetComponent<AudioSource>().clip = bgm[3];
                GetComponent<AudioSource>().Play();
                requst = 4;
            }

        }
        else if (i == 397)
        {
            if (requst != 5)
            {
                GetComponent<AudioSource>().clip = bgm[4];
                GetComponent<AudioSource>().Play();
                requst = 5;
            }

        }
        else if (i >= 398 && i <= 404)
        {
            if (requst != 4)
            {
                GetComponent<AudioSource>().clip = bgm[3];
                GetComponent<AudioSource>().Play();
                requst = 4;
            }

        }
        else if (i == 405)
        {
            if (requst != 6)
            {
                GetComponent<AudioSource>().clip = bgm[5];
                GetComponent<AudioSource>().Play();
                requst = 6;
            }

        }
        else if (i ==406)
        {
            if (requst != 4)
            {
                GetComponent<AudioSource>().clip = bgm[3];
                GetComponent<AudioSource>().Play();
                requst = 4;
            }

        }
        else if (i >= 407 && i<= 418)
        {
            if (requst != 5)
            {
                GetComponent<AudioSource>().clip = bgm[4];
                GetComponent<AudioSource>().Play();
                requst = 5;
            }

        }
        else if (i >= 419 && i <= 424)
        {
            if (requst != 1)
            {
                GetComponent<AudioSource>().clip = bgm[0];
                GetComponent<AudioSource>().Play();
                requst = 1;
            }

        }
        else if (i >= 425 && i <= 426)
        {
            if (requst != 8)
            {
                GetComponent<AudioSource>().clip = bgm[7];
                GetComponent<AudioSource>().Play();
                requst = 8;
            }

        }
        else if (i >= 427 && i <= 428)
        {
            if (requst != 1)
            {
                GetComponent<AudioSource>().clip = bgm[0];
                GetComponent<AudioSource>().Play();
                requst = 1;
            }

        }
        else if (i >= 429 && i <= 440)
        {
            if (requst != 4)
            {
                GetComponent<AudioSource>().clip = bgm[3];
                GetComponent<AudioSource>().Play();
                requst = 4;
            }

        }
        else if (i >= 441 && i <= 442)
        {
            if (requst != 1)
            {
                GetComponent<AudioSource>().clip = bgm[0];
                GetComponent<AudioSource>().Play();
                requst = 1;
            }

        }
        else if (i >= 443 && i <= 444)
        {
            if (requst != 5)
            {
                GetComponent<AudioSource>().clip = bgm[4];
                GetComponent<AudioSource>().Play();
                requst = 5;
            }

        }
        else if (i >= 445 && i<=449)
        {
            if (requst != 6)
            {
                GetComponent<AudioSource>().clip = bgm[2];
                GetComponent<AudioSource>().Play();
                requst = 6;
            }

        }
        else if (i >= 450 && i <= 456)
        {
            if (requst != 1)
            {
                GetComponent<AudioSource>().clip = bgm[0];
                GetComponent<AudioSource>().Play();
                requst = 1;
            }

        }
        else if (i >= 457 && i <= 460)
        {
            if (requst != 8)
            {
                GetComponent<AudioSource>().clip = bgm[7];
                GetComponent<AudioSource>().Play();
                requst = 8;
            }

        }
        else if (i >= 461 && i <= 466)
        {
            if (requst != 1)
            {
                GetComponent<AudioSource>().clip = bgm[0];
                GetComponent<AudioSource>().Play();
                requst = 1;
            }

        }
        else if (i >= 467 && i <= 475)
        {
            if (requst != 4)
            {
                GetComponent<AudioSource>().clip = bgm[3];
                GetComponent<AudioSource>().Play();
                requst = 4;
            }

        }
        else if (i >= 476 && i <= 479)
        {
            if (requst != 1)
            {
                GetComponent<AudioSource>().clip = bgm[0];
                GetComponent<AudioSource>().Play();
                requst = 1;
            }

        }
        else if (i >= 480 && i <= 486)
        {
            if (requst != 4)
            {
                GetComponent<AudioSource>().clip = bgm[3];
                GetComponent<AudioSource>().Play();
                requst = 4;
            }

        }
        else if (i >= 487 && i <= 489)
        {
            if (requst != 6)
            {
                GetComponent<AudioSource>().clip = bgm[2];
                GetComponent<AudioSource>().Play();
                requst = 6;
            }

        }
        else if (i >= 490 && i <= 491)
        {
            if (requst != 4)
            {
                GetComponent<AudioSource>().clip = bgm[3];
                GetComponent<AudioSource>().Play();
                requst = 4;
            }

        }
        else if (i >= 492 && i <= 494)
        {
            if (requst != 1)
            {
                GetComponent<AudioSource>().clip = bgm[0];
                GetComponent<AudioSource>().Play();
                requst = 1;
            }

        }
        else if (i >= 495 && i <= 497)
        {
            if (requst != 6)
            {
                GetComponent<AudioSource>().clip = bgm[2];
                GetComponent<AudioSource>().Play();
                requst = 6;
            }

        }
        else if (i >=498 && i<=501)
        {
            if (requst != 4)
            {
                GetComponent<AudioSource>().clip = bgm[3];
                GetComponent<AudioSource>().Play();
                requst = 4;
            }

        }

    }
       
        



}
