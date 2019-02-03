using AnimalIdentifier_Base;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;


namespace AnimalForm
{
    public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}
		ImageTagger animalImageTagger = new ImageTagger();
        
        private void button1_Click(object sender, EventArgs e)
		{
            var filter = new AnimalFilter();
            var confd = new ConfidenceCheck();
            List<Tag> tags = animalImageTagger.GetTagsForImage(textBox1.Text);
            foreach (Tag tag in tags)
			{
				//checking each picutre 
				filter.checkAnimal(tag.name, tag.confidence);
				if (confd.result(tag.confidence) == true)
				{
					if (tag.name == "dog")
					{
						checkBox1.Checked = true;
					}
				    else if (tag.name == "cat")
					{
						checkBox2.Checked = true;
					}
					else if (tag.name == "bird")
					{
						checkBox3.Checked = true;
					}

				}
                pictureBox1.Image = Image.FromFile(@""+textBox1.Text);

            }

		}

		private void checkBox1_CheckedChanged(object sender, EventArgs e)
		{

		}

		private void textBox1_TextChanged(object sender, EventArgs e)
		{

		}

        private void folderBrowserDialog1_HelpRequest(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
