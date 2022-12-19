namespace Translator_My
{
    public partial class Form1 : Form
    {
        //объявляем переменные
        ToolTip toolTip = new ToolTip();

        List<string> ruLang = new List<string>();
        List<string> enLang = new List<string>();
        public Form1()
        {
            InitializeComponent();
        }



        private void Form1_Load(object sender, EventArgs e)
        {
            langComboBox.SelectedIndex = 0;

            ruLang.AddRange(File.ReadAllLines("ru.txt"));
            enLang.AddRange(File.ReadAllLines("en.txt"));
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        
        //Добавление слов
        private void AddButton_Click(object sender, EventArgs e)
        {
            NewWord newWord = new NewWord();
            if (newWord.AddWord() == DialogResult.OK & newWord.wordTextBox.Text != "" & newWord.translateTextBox.Text != "")
            {
                ruLang.Add(newWord.wordTextBox.Text);
                enLang.Add(newWord.translateTextBox.Text);

                File.WriteAllLines("ru.txt", ruLang);
                File.WriteAllLines("en.txt", enLang);
            }
        }

        private void translateButton_Click(object sender, EventArgs e)
        {
            translateTextBox.Text = null;

            Translate tanslate = new Translate(wordTextBox.Text, translateTextBox, langComboBox.SelectedIndex);
        }

        private void viewDictionaryButton_Click(object sender, EventArgs e)
        {
            ViewDictionary viewDictionary = new ViewDictionary();
        }
    }
}