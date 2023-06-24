using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory_System
{
    class license
    {
        string[] randomCode;
        char[] baseNumbers;
        string[] numbersCode;

        char[] baseLetters;
        string[] lettersCode;

        string dateValidity = "";
        string duration = "";
        string licenseTo = "";
        string dateValidity2 = "";

        public license()
        {
            this.baseNumbers = "0123456789".ToCharArray();
            this.numbersCode = new string[15];

            numbersCode[0] = "ewmauskpgjlofribztnxcdvhqy";
            numbersCode[1] = "wcikopxbqrsnjuvadftgmeyzlh";
            numbersCode[2] = "utwymfnxleavziqkrochgjpsbd";
            numbersCode[3] = "kfrjoszeimvbwplxtyqgandhuc";
            numbersCode[4] = "aivehwdbzymljgortnkcqfuxsp";
            numbersCode[5] = "ftbducahwykorzgmiejqvnpsxl";
            numbersCode[6] = "uqdkaoflygnbvwteimhxjscpzr";
            numbersCode[7] = "xtrvgpekjdlzwqhnyfscmaouib";
            numbersCode[8] = "noezibfjrypxqhkwutcavslmgd";
            numbersCode[9] = "beqwzikdlpcuotxgrsvyhfamnj";
            numbersCode[10] = "nevfwqcpgoluxsayrihzjdkbtm";
            numbersCode[11] = "xcbvknhrtsdpzowyaqiujmegfl";
            numbersCode[12] = "efqtuplirwyjszdxvaomcgkhnb";
            numbersCode[13] = "dweqblugfnzsachrjiktyomxvp";
            numbersCode[14] = "rqvcyomuzedlashgwxptknjbif";

            this.baseLetters = "abcdefghijklmnopqrstuvwxyz_".ToCharArray();
            this.lettersCode = new string[15];

            lettersCode[0] = "hwbjngkmyqolcfautsxvrdziep0";
            lettersCode[1] = "ojbszlefayikpvcgqmrhnudtwx0";
            lettersCode[2] = "dfpyrhmclbktuvonaigwxszeqj0";
            lettersCode[3] = "agtybuwcrmodfzhvxklpinjsqe0";
            lettersCode[4] = "phyjlowmuvzrbdcixqekgsfatn0";
            lettersCode[5] = "teagqzduvohnycrwxikjfmlpsb0";
            lettersCode[6] = "bchsexuptmzgiwfrlyvqkoanjd0";
            lettersCode[7] = "dkoashgieluvmqnycrwjpzfbxt0";
            lettersCode[8] = "mzjrhsnkxigtvfepuqcdlboyaw0";
            lettersCode[9] = "peqlstgcjhmiuokrxfdazvwybn0";
            lettersCode[10] = "ikjnlbeqvdsmpzcgyhurtxafow0";
            lettersCode[11] = "gdnycshqkjumzpevwfbiaotxrl0";
            lettersCode[12] = "ngbsofzaxjqywdirlucvmehpkt0";
            lettersCode[13] = "spzcfxleotwbmganvdyrhkqjiu0";
            lettersCode[14] = "emkspufhcgxdjabwzyloqnritv0";

            randomCode = new string[15];
            randomCode[0] = "kx";
            randomCode[1] = "ij";
            randomCode[2] = "ox";
            randomCode[3] = "wf";
            randomCode[4] = "hc";
            randomCode[5] = "he";
            randomCode[6] = "jy";
            randomCode[7] = "qb";
            randomCode[8] = "xb";
            randomCode[9] = "bn";
            randomCode[10] = "xw";
            randomCode[11] = "mz";
            randomCode[12] = "rt";
            randomCode[13] = "sf";
            randomCode[14] = "yt";
        }

        int decodeRandom(string input)
        {
            for (int i = 0; i < this.randomCode.Length; i++)
            {
                if (input == this.randomCode[i])
                {
                    return i;
                }
            }

            return -1;
        }

        string decryptNumbers(string input, int r)
        {
            string output = "";
            char[] n = input.ToCharArray();
            for (int i = 0; i < n.Length; i++)
            {
                int key = this.numbersCode[r].IndexOf(n[i]);
                if (key > -1 && key < 10)
                {
                    output += this.baseNumbers[key].ToString();
                }
            }

            return output;
        }

        string decryptLetters(string input, int r)
        {
            string output = "";
            char[] n = input.ToCharArray();

            for (int i = 0; i < n.Length; i++)
            {
                int key = this.lettersCode[r].IndexOf(n[i]);
                if (key > -1 && key < 28)
                {
                    string letter = this.baseLetters[key].ToString();
                    int parseNumber = -1;
                    bool isNumber = int.TryParse(n[i].ToString(), out parseNumber);

                    if (isNumber)
                    {
                        if (parseNumber == 0)
                        {
                            letter = " ";
                        }
                        else
                        {
                            break;
                        }
                    }

                    output += letter;
                }
                else
                {
                    break;
                }
            }

            return output;
        }

        public bool validate(string input)
        {
            input = input.ToLower();

            if (input.Length != 45)
            {
                return false;
            }

            this.dateValidity = input.Substring(0, 8);
            this.duration = input.Substring(8, 7);
            this.licenseTo = input.Substring(15, 22);
            this.dateValidity2 = input.Substring(37, 8);

            int randomKey = -1;

            randomKey = this.decodeRandom(dateValidity.Substring(0, 2));

            this.dateValidity = dateValidity.Substring(2, dateValidity.Length - 2);
            this.dateValidity = this.decryptNumbers(dateValidity, randomKey);

            randomKey = this.decodeRandom(duration.Substring(0, 2));
            this.duration = duration.Substring(2, duration.Length - 2);
            this.duration = this.decryptNumbers(duration, randomKey);

            randomKey = this.decodeRandom(licenseTo.Substring(0, 2));

            this.licenseTo = licenseTo.Substring(2, licenseTo.Length - 2);
            this.licenseTo = this.decryptLetters(licenseTo, randomKey);

            randomKey = this.decodeRandom(dateValidity2.Substring(0, 2));
            this.dateValidity2 = dateValidity2.Substring(2, dateValidity2.Length - 2);
            this.dateValidity2 = this.decryptNumbers(dateValidity2, randomKey);

            if (dateValidity != dateValidity2 || licenseTo.Trim() == "")
            {
                return false;
            }

            string formattedDate = string.Format(
                "20{0}-{1}-{2}",
                this.dateValidity.Substring(0, 2),
                this.dateValidity.Substring(2, 2),
                this.dateValidity.Substring(4, 2)
            );

            string formattedLicenseTo = "";
            string[] words = licenseTo.Split(' ');
            for (int i = 0; i < words.Length; i++)
            {
                formattedLicenseTo += words[i].Substring(0, 1).ToUpper() + words[i].Substring(1) + " ";
            }

            this.licenseTo = formattedLicenseTo.Trim();
            this.dateValidity = formattedDate;

            //MessageBox.Show("Availablity: " + formattedDate + "\r\nLicense To :" + formattedLicenseTo + "\r\nDuration: " + duration);

            return true;
        }

        public string getDateValidity()
        {
            return this.dateValidity;
        }

        public string getLicenseTo()
        {
            return this.licenseTo;
        }

        public int getDuration()
        {
            int d = 0;

            bool isNumber = int.TryParse(this.duration, out d);

            return d;
        }
    }
}
