using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Translator_My
{
    public partial class ViewDictionary
    {
        string[] ruText = new string[File.ReadAllLines("ru.txt").Length];
        string[] enText = new string[File.ReadAllLines("en.txt").Length];

        public ViewDictionary()
        {
            #region Создаем форму.
            Form viewDictionaryForm = new Form();
            viewDictionaryForm.StartPosition = FormStartPosition.CenterScreen;
            viewDictionaryForm.FormBorderStyle = FormBorderStyle.Fixed3D;
            viewDictionaryForm.Size = new Size(300, 200);
            viewDictionaryForm.MinimizeBox = false;
            viewDictionaryForm.MaximizeBox = false;
            viewDictionaryForm.Text = "Просмотр словаря";
            #endregion

            #region Создаем RichTextBox.
            RichTextBox richText = new RichTextBox();
            richText.Location = new Point(10, 10);
            richText.Size = new Size(215, 105);
            richText.ScrollBars = RichTextBoxScrollBars.ForcedVertical;
            richText.ReadOnly = true;
            for (int i = 0; i < ruText.Length; i++)
            {
                ruText[i] = File.ReadAllLines("ru.txt")[i];
                enText[i] = File.ReadAllLines("en.txt")[i];
                richText.AppendText(ruText[i] + " - " + enText[i] + "\n");
            }
            viewDictionaryForm.Controls.Add(richText);
            #endregion

            #region Создаем кнопку.
            Button closeButton = new Button();
            closeButton.Location = new Point(150, 120);
            closeButton.Size = new Size(75, 25);
            closeButton.Text = "Закрыть";
            closeButton.DialogResult = DialogResult.OK;
            viewDictionaryForm.Controls.Add(closeButton);
            #endregion

            viewDictionaryForm.ShowDialog();
        }
    }
}
