using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kelime_Ödev
{
    public partial class kelimebul : Form
    {
        public kelimebul()
        {
            InitializeComponent();
            
        }
        private static int ssorthash(string str)
        {
            char[] foo = str.ToArray();
            Array.Sort(foo);
            return new string(foo).GetHashCode();
        }
        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            Random rastgele = new Random();
            string harfler = "abcçdefgğhıijklmnoöprsştuüvyz";
            string uret = "";
            for (int i = 0; i < 8; i++)
            {
                uret += harfler[rastgele.Next(harfler.Length)];
            }
            string[] harfdizi = new string[7];
            for (int i = 0; i < 7; i++)
            {
                harfdizi[i] = uret;
                randomText.Text = harfdizi[i];
            }
        }
        private void bunifuThinButton23_Click(object sender, EventArgs e)
        {
            
            if (randomText.Text != "" && jtext.Text!="")
            {
                string b = randomText.Text + jtext.Text; ;
                string sentence = b;
                char[] charArr = sentence.ToCharArray();
                string[] kume = new string[b.Count()];
                for (int i = 0; i < b.Count(); i++)
                {
                    kume[i] = charArr[i].ToString();
                }
                int kombinasyon = 3;
                for (int i = 0; i <= kume.Length; i++)
                {
                    var result = Deneme.Combinations(kume, kombinasyon);

                    foreach (var item in result)
                    {
                        string a = string.Join("", item.ToArray());
                        listBox1.Items.Add(a);
                    }
                    kombinasyon++;
                }
            }
            else
            {
                string sentence = randomText.Text;
                char[] charArr = sentence.ToCharArray();
                string[] kume = new string[randomText.Text.Count()];
                for (int i = 0; i < randomText.Text.Count(); i++)
                {
                    kume[i] = charArr[i].ToString();
                }
                int kombinasyon = 3;
                for (int i = 0; i <= kume.Length; i++)
                {
                    var result = Deneme.Combinations(kume, kombinasyon);

                    foreach (var item in result)
                    {
                        string a = string.Join("", item.ToArray());
                        listBox1.Items.Add(a);
                    }
                    kombinasyon++;
                }
            }
            if(ktext.Text!="" && jtext.Text != "")
            {
                string c = ktext.Text + jtext.Text; ;
                string sentence = c;
                char[] charArr = sentence.ToCharArray();
                string[] kume = new string[c.Count()];
                for (int i = 0; i < c.Count(); i++)
                {
                    kume[i] = charArr[i].ToString();
                }
                int kombinasyon = 3;
                for (int i = 0; i <= kume.Length; i++)
                {
                    var result = Deneme.Combinations(kume, kombinasyon);

                    foreach (var item in result)
                    {
                        string a = string.Join("", item.ToArray());
                        listBox1.Items.Add(a);
                    }
                    kombinasyon++;
                }
            }
            else
            {
                string sentence = ktext.Text;
                char[] charArr = sentence.ToCharArray();
                string[] kume = new string[ktext.Text.Count()];
                for (int i = 0; i < ktext.Text.Count(); i++)
                {
                    kume[i] = charArr[i].ToString();
                }
                int kombinasyon = 3;
                for (int i = 0; i <= kume.Length; i++)
                {
                    var result = Deneme.Combinations(kume, kombinasyon);

                    foreach (var item in result)
                    {
                        string a = string.Join("", item.ToArray());
                        listBox1.Items.Add(a);
                    }
                    kombinasyon++;
                }
            }
            string[] arr = new string[listBox1.Items.Count];
            listBox1.Items.CopyTo(arr, 0);
            var arr1 = arr.Distinct();
            listBox1.Items.Clear();
            foreach (string s in arr1)
            {
                listBox1.Items.Add(s);
            }
            var s1 = Stopwatch.StartNew();
            StreamReader sr = new StreamReader(@"C:\Users\baran\Desktop\Proje\Kelime Ödev\Kelime Bul\turkce.txt", Encoding.GetEncoding("iso-8859-9"));
            string[] wordlist = sr.ReadToEnd().Split("\r\n".ToCharArray());
            int[] hashes = new int[wordlist.Count()];
            for (int i = 0; i <= wordlist.GetUpperBound(0); i++)
            {
                hashes[i] = ssorthash(wordlist[i]);
            }
            s1.Stop();

            for (int i = 0; i < listBox1.Items.Count; i++)
            {
                string newWord;
                newWord = listBox1.Items[i].ToString();

                if (newWord != null)
                {
                    s1.Reset();
                    s1.Start();
                    newWord = newWord.ToLower();
                    int w1hash = ssorthash(newWord);
                    for (int x = 0; x <= hashes.GetUpperBound(0); x++)
                    {
                        if (hashes[x] == w1hash)
                        {
                            listBox2.Items.Add(wordlist[x].ToString());
                        }
                    }
                    s1.Stop();

                }
            }
            string[] arr2 = new string[listBox2.Items.Count];
            listBox2.Items.CopyTo(arr2, 0);
            var arr3 = arr2.Distinct();
            listBox2.Items.Clear();
            foreach (string s in arr3)
            {
                listBox2.Items.Add(s);
            }
            
            for (int i=0; i < listBox2.Items.Count; i++)
            {
                textBox1.Text = listBox2.Items[i].ToString();
                if(textBox1.Text.Length == 3)
                {
                    listBox3.Items.Add(textBox1.Text);
                }
                if (textBox1.Text.Length == 4)
                {
                    listBox4.Items.Add(textBox1.Text);
                }
                if (textBox1.Text.Length == 5)
                {
                    listBox5.Items.Add(textBox1.Text);
                }
                if (textBox1.Text.Length == 6)
                {
                    listBox6.Items.Add(textBox1.Text);
                }
                if (textBox1.Text.Length == 7)
                {
                    listBox7.Items.Add(textBox1.Text);
                }
                if (textBox1.Text.Length == 8)
                {
                    listBox8.Items.Add(textBox1.Text);
                }
                if (textBox1.Text.Length == 9)
                {
                    listBox9.Items.Add(textBox1.Text);
                }
            }
        }

        private void kelimebul_Load(object sender, EventArgs e)
        {

        }

        
    }
}
