using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Translator_My
{
    public partial class Translate
    {
        string[] ru = new string[File.ReadAllLines("ru.txt").Length];
        string[] en = new string[File.ReadAllLines("en.txt").Length];

        //переводим с русского
        public Translate(string word, TextBox textBox, int index)
        {
            if (index == 0)
            {
                for (int i = 0; i < ru.Length; i++)
                {
                    ru[i] = File.ReadAllLines("ru.txt")[i];
                    en[i] = File.ReadAllLines("en.txt")[i];

                    if (ru[i].Equals(word, StringComparison.CurrentCultureIgnoreCase))
                    {
                        textBox.Text = en[i];

                        return;
                    }
                }
            }
            //переводим с английского
            if (index == 1)
            {
                for (int i = 0; i < en.Length; i++)
                {
                    en[i] = File.ReadAllLines("en.txt")[i];
                    ru[i] = File.ReadAllLines("ru.txt")[i];

                    if (en[i].Equals(word, StringComparison.CurrentCultureIgnoreCase))
                    {
                        textBox.Text = ru[i];

                        return;
                    }
                }
            }
        }

        

    }
}
