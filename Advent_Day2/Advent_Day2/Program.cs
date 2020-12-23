using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Advent_Day2
{
    class Program
    {
        static void Main(string[] args)
        {
            var counter = 0;

            //string[,] inputs = new string[2, 4]
            List<List<string>> inputs = new List<List<string>>();
            inputs.Add(new List<string> { "5", "9", "g", "ggccggmgn" });
            inputs.Add(new List<string> { "11", "16", "l", "llllqllllllllflq" });
            inputs.Add(new List<string> { "3", "6", "q", "qvqqqpzqd" });
            inputs.Add(new List<string> { "6", "11", "f", "ffffpcffffp" });
            inputs.Add(new List<string> { "7", "8", "l", "lllqlwtqll" });
            inputs.Add(new List<string> { "8", "10", "q", "qqglqqqqqqqjqmdbq" });
            inputs.Add(new List<string> { "4", "6", "w", "hflwkwplswcnhb" });
            inputs.Add(new List<string> { "6", "15", "w", "wwswwxlwwwwwwww" });
            inputs.Add(new List<string> { "3", "5", "f", "fffvnpvf" });
            inputs.Add(new List<string> { "6", "8", "b", "bhwsshbp" });
            inputs.Add(new List<string> { "1", "2", "l", "lhll" });
            inputs.Add(new List<string> { "5", "6", "s", "wpsxsss" });
            inputs.Add(new List<string> { "2", "4", "w", "wswwtwww" });
            inputs.Add(new List<string> { "9", "12", "x", "xxxxxfxxxxrnx" });
            inputs.Add(new List<string> { "9", "10", "s", "sssscsqssshsppzsc" });
            inputs.Add(new List<string> { "1", "3", "w", "wgwtwbksqrrcpvtfbbw" });
            inputs.Add(new List<string> { "2", "9", "r", "wrrtcmzcrdtlmkldsckq" });
            inputs.Add(new List<string> { "4", "6", "g", "gttdhlfgpcgrgtwc" });
            inputs.Add(new List<string> { "1", "2", "f", "fpbcjczfwmrrxk" });
            inputs.Add(new List<string> { "9", "10", "z", "zzzzzzzzzt" });
            inputs.Add(new List<string> { "1", "8", "m", "mjjlsbmg" });
            inputs.Add(new List<string> { "5", "7", "p", "ppkpprp" });
            inputs.Add(new List<string> { "3", "6", "w", "wwwtwzwww" });
            inputs.Add(new List<string> { "17", "18", "q", "cqqjvhqhrpqlqvqdjlbb" });
            inputs.Add(new List<string> { "2", "3", "n", "dnphwnfz" });
            inputs.Add(new List<string> { "3", "4", "r", "blqrrrr" });
            inputs.Add(new List<string> { "4", "5", "v", "lsrvvpghqsdwrvppsm" });
            inputs.Add(new List<string> { "5", "15", "n", "hclnngnhmfnjzqnvz" });
            inputs.Add(new List<string> { "6", "7", "d", "kddmddd" });
            inputs.Add(new List<string> { "15", "17", "v", "vvvvvvvvvvvvvvpvl" });
            inputs.Add(new List<string> { "3", "4", "q", "kndwvq" });
            inputs.Add(new List<string> { "12", "19", "t", "tktxcppccjlwnnmmntt" });
            inputs.Add(new List<string> { "6", "8", "p", "ppplpcpc" });
            inputs.Add(new List<string> { "3", "6", "p", "npprhpsxkq" });
            inputs.Add(new List<string> { "4", "6", "v", "bvfvvv" });
            inputs.Add(new List<string> { "1", "2", "r", "rrrr" });
            inputs.Add(new List<string> { "6", "10", "r", "bsrcqbtrpbr" });
            inputs.Add(new List<string> { "7", "8", "w", "wwwwwwwvw" });
            inputs.Add(new List<string> { "12", "17", "h", "hnffmvtrqnmhgsnbhrr" });
            inputs.Add(new List<string> { "9", "13", "c", "cccjcddcchccc" });
            inputs.Add(new List<string> { "11", "13", "c", "cwccctccccccc" });
            inputs.Add(new List<string> { "6", "8", "d", "khjjvdddpkddcddd" });
            inputs.Add(new List<string> { "1", "2", "r", "lmrr" });
            inputs.Add(new List<string> { "1", "5", "t", "wtttmt" });
            inputs.Add(new List<string> { "6", "7", "m", "qdmmmmmxm" });
            inputs.Add(new List<string> { "5", "18", "h", "hhhhshhhhhhhhhhhhhh" });
            inputs.Add(new List<string> { "4", "11", "l", "llllllllllcllll" });
            inputs.Add(new List<string> { "2", "8", "k", "kkbkkkkkkkkk" });
            inputs.Add(new List<string> { "3", "6", "q", "rqbqmqwqgq" });
            inputs.Add(new List<string> { "3", "6", "d", "dsrdfh" });
            inputs.Add(new List<string> { "16", "20", "m", "qmllmddfldjmmrpmmwpt" });
            inputs.Add(new List<string> { "9", "16", "j", "tjjpjqvhjjjtjjtjj" });
            inputs.Add(new List<string> { "4", "9", "b", "btbdbbbbrbbb" });
            inputs.Add(new List<string> { "5", "16", "w", "wwwwpwwwmwwwwwwmwww" });
            inputs.Add(new List<string> { "1", "2", "g", "gggggbwgggbgg" });
            inputs.Add(new List<string> { "1", "2", "l", "lllllbcwlllkfb" });
            inputs.Add(new List<string> { "4", "5", "h", "ghhshkhhhdbs" });
            inputs.Add(new List<string> { "4", "5", "s", "ssssssvssspssxs" });
            inputs.Add(new List<string> { "7", "12", "k", "kkpkkkgtrkkk" });
            inputs.Add(new List<string> { "11", "16", "t", "tgjttttktrtstsxtm" });
            inputs.Add(new List<string> { "9", "13", "c", "cccccccccccccc" });
            inputs.Add(new List<string> { "5", "9", "q", "qqqqqqqqq" });
            inputs.Add(new List<string> { "2", "4", "q", "rqqqq" });
            inputs.Add(new List<string> { "4", "6", "l", "lllblql" });
            inputs.Add(new List<string> { "2", "4", "b", "jbbbnvbx" });
            inputs.Add(new List<string> { "4", "9", "q", "kqqqbxqsq" });
            inputs.Add(new List<string> { "3", "4", "q", "rzjrcq" });
            inputs.Add(new List<string> { "1", "5", "l", "rllqsc" });
            inputs.Add(new List<string> { "1", "6", "l", "lgljslmsmbwbllsjw" });
            inputs.Add(new List<string> { "2", "5", "p", "psmkj" });
            inputs.Add(new List<string> { "1", "3", "v", "vvvvv" });
            inputs.Add(new List<string> { "7", "10", "k", "kbmdkkdkpzxhkqk" });
            inputs.Add(new List<string> { "3", "6", "g", "ggtgpgxg" });
            inputs.Add(new List<string> { "1", "8", "w", "wswwwgww" });
            inputs.Add(new List<string> { "2", "6", "r", "rrqmfs" });
            inputs.Add(new List<string> { "5", "6", "r", "rrrrpzr" });
            inputs.Add(new List<string> { "2", "5", "v", "vvfvvv" });
            inputs.Add(new List<string> { "5", "10", "r", "rdrrrrrnrr" });
            inputs.Add(new List<string> { "1", "7", "v", "vvvvdvvvv" });
            inputs.Add(new List<string> { "6", "7", "r", "nhbxnrr" });
            inputs.Add(new List<string> { "1", "4", "g", "mggr" });
            inputs.Add(new List<string> { "2", "3", "g", "ggqtgw" });
            inputs.Add(new List<string> { "7", "8", "k", "qkkkckkkxxwkvt" });
            inputs.Add(new List<string> { "2", "4", "g", "gbmgx" });
            inputs.Add(new List<string> { "7", "14", "w", "wrwnftwrbcbxrx" });
            inputs.Add(new List<string> { "7", "10", "f", "ffkmfftlnf" });
            inputs.Add(new List<string> { "10", "13", "j", "qjjjjjjjjgjjq" });
            inputs.Add(new List<string> { "11", "13", "n", "ntnnnnnnnnknsn" });
            inputs.Add(new List<string> { "1", "7", "d", "lsddrwzzddhxddq" });
            inputs.Add(new List<string> { "12", "17", "q", "qjqqqrlqdqqvqwqqd" });
            inputs.Add(new List<string> { "2", "3", "z", "crzz" });
            inputs.Add(new List<string> { "3", "4", "d", "dtsd" });
            inputs.Add(new List<string> { "3", "5", "k", "hkgstlvxr" });
            inputs.Add(new List<string> { "18", "19", "d", "hswndtgrdtwtdddddpl" });
            inputs.Add(new List<string> { "9", "12", "x", "xxxqxxxxxxxjhxx" });
            inputs.Add(new List<string> { "1", "2", "b", "dpbb" });
            inputs.Add(new List<string> { "8", "15", "h", "bhhzkqhghhtphfzh" });
            inputs.Add(new List<string> { "13", "17", "d", "dnddddddddddddddxd" });
            inputs.Add(new List<string> { "15", "17", "m", "mmmmmmmmmmmmmmmmmmmm" });
            inputs.Add(new List<string> { "5", "11", "r", "rrrrwrrrrrwrr" });
            inputs.Add(new List<string> { "4", "6", "v", "vvvhvf" });
            inputs.Add(new List<string> { "7", "10", "l", "lllllltxlfllfll" });
            inputs.Add(new List<string> { "3", "7", "s", "sssssssss" });
            inputs.Add(new List<string> { "2", "7", "b", "fbfcfdgtbb" });
            inputs.Add(new List<string> { "4", "5", "x", "xmxxxxx" });
            inputs.Add(new List<string> { "2", "5", "g", "gqqsqbmgclq" });
            inputs.Add(new List<string> { "3", "5", "z", "zbzgznzp" });
            inputs.Add(new List<string> { "7", "8", "z", "hzzxtzzz" });
            inputs.Add(new List<string> { "2", "4", "q", "qjqqqq" });
            inputs.Add(new List<string> { "17", "19", "g", "ggggggggggggggggggwg" });
            inputs.Add(new List<string> { "7", "10", "s", "pwqssvsqmsbfrbfg" });
            inputs.Add(new List<string> { "8", "12", "b", "bbbbbbbsvbfsfgvbzbk" });
            inputs.Add(new List<string> { "1", "9", "n", "mnnnnnnnnn" });
            inputs.Add(new List<string> { "2", "3", "z", "zcwzz" });
            inputs.Add(new List<string> { "6", "18", "x", "xxxxxtxxxxxxxxxxxlx" });
            inputs.Add(new List<string> { "6", "15", "m", "mmtmmmmmmmmmmmmdmm" });
            inputs.Add(new List<string> { "4", "8", "v", "bfbvlmwgrvlh" });
            inputs.Add(new List<string> { "16", "18", "m", "mmmmmmmmmmmmmmmjmd" });
            inputs.Add(new List<string> { "8", "9", "j", "hjqdjjjgj" });
            inputs.Add(new List<string> { "2", "3", "q", "qfkv" });
            inputs.Add(new List<string> { "10", "12", "p", "kpzvlppqzmpdd" });
            inputs.Add(new List<string> { "3", "4", "s", "ssss" });
            inputs.Add(new List<string> { "2", "12", "c", "mcnscktznndc" });
            inputs.Add(new List<string> { "3", "5", "l", "lllllll" });
            inputs.Add(new List<string> { "3", "4", "w", "wwww" });
            inputs.Add(new List<string> { "9", "10", "s", "sssssssssls" });
            inputs.Add(new List<string> { "11", "13", "d", "dzdddddjddtddw" });
            inputs.Add(new List<string> { "6", "7", "x", "xxjxxxxdx" });
            inputs.Add(new List<string> { "7", "8", "f", "dqjhfqfw" });
            inputs.Add(new List<string> { "8", "13", "m", "mmmmqmmlmmmmcmmmmmmm" });
            inputs.Add(new List<string> { "7", "10", "j", "bdcmkjjhfjzbfwxgzg" });
            inputs.Add(new List<string> { "3", "8", "j", "tgmdwwjjnjgjgjhjtx" });
            inputs.Add(new List<string> { "4", "7", "l", "llllllllvplglld" });
            inputs.Add(new List<string> { "11", "15", "z", "tzxvzzzzzzmfzzczz" });
            inputs.Add(new List<string> { "3", "6", "z", "zzzzpzzsgztcpzz" });
            inputs.Add(new List<string> { "9", "13", "x", "pfzxpqtckxvsxx" });
            inputs.Add(new List<string> { "7", "8", "g", "gmglbpgxwglxbztbkgcv" });
            inputs.Add(new List<string> { "3", "5", "b", "vqnbbb" });
            inputs.Add(new List<string> { "6", "7", "g", "ggggggg" });
            inputs.Add(new List<string> { "4", "10", "n", "nnqnnnnnnmhqnnnn" });
            inputs.Add(new List<string> { "7", "9", "b", "bbbbbbqbdbkbqbbb" });
            inputs.Add(new List<string> { "15", "17", "h", "hhhhhhhhhhhhhhdhjz" });
            inputs.Add(new List<string> { "2", "3", "b", "bbbxb" });
            inputs.Add(new List<string> { "1", "3", "b", "bpbvbbbbbbbbzlbrsb" });
            inputs.Add(new List<string> { "9", "13", "c", "ccccccccpcccvc" });
            inputs.Add(new List<string> { "10", "13", "n", "hnnnwbnnnntnnn" });
            inputs.Add(new List<string> { "6", "12", "s", "zssscssfsssszs" });
            inputs.Add(new List<string> { "2", "9", "n", "pnwkdvknxhvvqpjrqk" });
            inputs.Add(new List<string> { "1", "2", "c", "hvfdcltktc" });
            inputs.Add(new List<string> { "3", "6", "c", "cpccblcrqnlfdnd" });
            inputs.Add(new List<string> { "12", "14", "h", "mxpghswhdlklnb" });
            inputs.Add(new List<string> { "4", "5", "b", "kbbggvbbxkbsl" });
            inputs.Add(new List<string> { "1", "6", "j", "chjjjxjjjj" });
            inputs.Add(new List<string> { "4", "6", "m", "mmmmmmm" });
            inputs.Add(new List<string> { "13", "15", "m", "mmmmmmmmmmmmrms" });
            inputs.Add(new List<string> { "9", "15", "z", "zzzzzzzzxzzzzzzz" });
            inputs.Add(new List<string> { "5", "11", "q", "gqmlbsgjbzv" });
            inputs.Add(new List<string> { "12", "15", "t", "sgtgscntdttttjt" });
            inputs.Add(new List<string> { "13", "15", "h", "sgxqbhhhmkfzhmd" });
            inputs.Add(new List<string> { "7", "9", "p", "dppzplppppt" });
            inputs.Add(new List<string> { "2", "6", "v", "rzlgcxspgwdwrkxbsqvw" });
            inputs.Add(new List<string> { "2", "5", "n", "mnlxnnn" });
            inputs.Add(new List<string> { "17", "18", "p", "pkcjklpppxdqptpnfxk" });
            inputs.Add(new List<string> { "10", "11", "s", "sssjssssstd" });
            inputs.Add(new List<string> { "8", "11", "f", "fffffffffffffffff" });
            inputs.Add(new List<string> { "1", "3", "h", "hhhhhhh" });
            inputs.Add(new List<string> { "4", "5", "d", "vddxnd" });
            inputs.Add(new List<string> { "2", "10", "h", "hxhhhhhhhhhh" });
            inputs.Add(new List<string> { "11", "13", "c", "vrmccccccqcccccchnk" });
            inputs.Add(new List<string> { "8", "14", "l", "llrlllllllllqljjm" });
            inputs.Add(new List<string> { "9", "15", "g", "bkglbmgfgkfxnblg" });
            inputs.Add(new List<string> { "14", "16", "c", "ccccbccccccccccccccc" });
            inputs.Add(new List<string> { "3-5", "l", "llglx" });
            inputs.Add(new List<string> { "1", "7", "t", "qtttgtn" });
            inputs.Add(new List<string> { "6", "8", "j", "jjjjjjjjkjjjj" });
            inputs.Add(new List<string> { "11", "14", "n", "btnndcxnbnnjjnnkvn" });
            inputs.Add(new List<string> { "4", "5", "r", "rgrrq" });
            inputs.Add(new List<string> { "7", "9", "l", "rxltlljllll" });
            inputs.Add(new List<string> { "1", "5", "w", "wwrgn" });
            inputs.Add(new List<string> { "14", "18", "d", "zlxdglmbsstdbqddnq" });
            inputs.Add(new List<string> { "1", "18", "m", "mmmmmmmmmmmmmmmmmm" });
            inputs.Add(new List<string> { "13", "16", "p", "prpphpqppplppzpnpppp" });
            inputs.Add(new List<string> { "3", "6", "s", "nfdsssssss" });
            inputs.Add(new List<string> { "11", "12", "b", "bmbbstbbwbbt" });
            inputs.Add(new List<string> { "5", "6", "x", "fstlxx" });
            inputs.Add(new List<string> { "7", "11", "w", "hwmxkpwwdfmr" });

            foreach (List<string> subList in inputs)
            {
                    string psswrd = subList[3];
                    char letter = char.Parse(subList[2]);
                    int max = Int32.Parse(subList[1]);
                    int min = Int32.Parse(subList[0]);

                if (psswrd.Contains(letter))
                {
                    var count = psswrd.Count(x => x == letter);

                    if (count <= max && count >= min)
                    {
                        counter++;
                    }
                }
            }
            

            
            Console.WriteLine(counter);
        }
    }
}


