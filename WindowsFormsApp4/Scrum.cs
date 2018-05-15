using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp4
{
    public partial class Scrum : Form
    {
        public Scrum()
        {
            InitializeComponent();
        }
        Panel StoryPanelNew;
        FlowLayoutPanel TaskPanelNew;
        Label StoryTopicNew;
        PictureBox HumanPicBox;
        Panel Task;
        Label NewTaskLabelStatusToDo;
        Label NewTaskLabelStatusInProgress;
        Label NewTaskLabelStatusDone;
        
        private void NewStroyButton_Click(object sender, EventArgs e)
        {
            NewStoryPanel.Visible = true;
        }

        private void CreateNewStory_Click(object sender, EventArgs e)
        {


            StoryPanelNew = new Panel {
                Height = 123,
                Width = 1177,
                Name = txtStoryHead.Text,
                
            };
            
            StoryPanelNew.MouseClick += new MouseEventHandler(StoryPanel_Click);
            switch (cbColor.SelectedIndex)
            {
                case 0: StoryPanelNew.BackgroundImage= Properties.Resources.depositphotos_117032238_stock_illustration_trash_can_delete_icon_vector_red; break;
                case 1: StoryPanelNew.BackgroundImage = Properties.Resources.depositphotos_117032238_stock_illustration_trash_can_delete_icon_vector_yellow; break;
                case 2: StoryPanelNew.BackgroundImage = Properties.Resources.depositphotos_117032238_stock_illustration_trash_can_delete_icon_vector_blue; break;
                case 3: StoryPanelNew.BackgroundImage = Properties.Resources.depositphotos_117032238_stock_illustration_trash_can_delete_icon_vector_green; break;
                


                default: break;
            }

            TaskPanelNew = new FlowLayoutPanel
            {
                Location = new Point(577, 0),
                Width = 570,
                Height = 123,
                BackColor = Color.Teal,
                AutoScroll = true// değiştirelecek
            };
            TaskPanelNew.MouseClick += new MouseEventHandler(TaskPanel_Click);

            StoryTopicNew = new Label
            {
                Text = txtStoryHead.Text,
                Location = new Point(0, 0),
                Size = new Size(577, 35),
                TextAlign = ContentAlignment.MiddleCenter,
                BackColor = Color.LimeGreen,
                Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162))),

            };

            StoryPanelNew.Controls.Add(StoryTopicNew);
            StoryTopicNew = new Label
            {
                Text = txtStoryBody.Text,
                Dock = DockStyle.Left,
                Width = 550,
                BackColor = Color.Transparent,
                TextAlign = ContentAlignment.MiddleCenter,
                Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162))),

            }; StoryTopicNew.MouseClick += new MouseEventHandler(StoryPanel_Click);

            HumanPicBox = new PictureBox {
                BackgroundImageLayout = ImageLayout.Zoom,
                Location = new Point(550, 35),
                Size = new Size(27, 88)
            };
            if (radioButton1.Checked == true)
                HumanPicBox.BackgroundImage = global::WindowsFormsApp4.Properties.Resources._15586731blue;
            if (radioButton2.Checked == true)
                HumanPicBox.BackgroundImage = global::WindowsFormsApp4.Properties.Resources._15586731red;
            if (radioButton3.Checked == true)
                HumanPicBox.BackgroundImage = global::WindowsFormsApp4.Properties.Resources._15586731gree;
            if (radioButton4.Checked == true)
            { HumanPicBox.BackgroundImage = global::WindowsFormsApp4.Properties.Resources._1558673; }
            HumanPicBox.MouseClick += new MouseEventHandler(StoryPanel_Click);

            NewStoryPanel.Visible = false;
            
            
            if ((txtStoryHead.Text == "" && txtStoryBody.Text == "")&&(radioButton1.Checked == false || radioButton2.Checked == false || radioButton3.Checked == false || radioButton4.Checked == false))
            {
                MessageBox.Show("You must fill in all the gaps");
            }
                else {
                this.MainPanel.Controls.Add(StoryPanelNew);
                StoryPanelNew.Controls.Add(TaskPanelNew);
                StoryPanelNew.Controls.Add(StoryTopicNew);
                StoryPanelNew.Controls.Add(HumanPicBox);
                
            }
            ClearAllBox();
        }
        public void ClearAllBox()
        {
            txtStoryHead.Text = "";
            txtStoryBody.Text = "";
            radioButton1.Checked = false;
            radioButton2.Checked = false;
            radioButton3.Checked = false;
            radioButton4.Checked = false;
            NewStoryPanel.Visible = false;
        }
        public void StoryPanel_Click(object sender, MouseEventArgs e)
        {
            StoryPanelNew = sender as Panel;
            this.MainPanel.Controls.Remove(StoryPanelNew);
        }

        

        FlowLayoutPanel panel;
        
        private void TaskPanel_Click(object sender, EventArgs e)
        {
            TaskPanel.Visible = true;
            
            panel = sender as FlowLayoutPanel;// tıklanan paneli kaydeder
            
            
        }
        
        private void LabelStatusToDo_Click(object sender, EventArgs e)
        {
            NewTaskLabelStatusToDo = sender as Label;
            NewTaskLabelStatusToDo.BackColor = Color.Yellow;
        }

        private void LabelStatusInProgress_Click(object sender, EventArgs e)
        {
            NewTaskLabelStatusInProgress = sender as Label;
            NewTaskLabelStatusInProgress.BackColor = Color.Yellow;
        }

        private void LabelStatusDone_Click(object sender, EventArgs e)
        {
            NewTaskLabelStatusDone = sender as Label;
            NewTaskLabelStatusDone.BackColor = Color.Yellow;
        }

        private void CreateNewTask_Click(object sender, EventArgs e)
        {
            Task = new Panel()
            {
                Size=new Size(130,90)
            };
            
            panel.Controls.Add(Task);
            Label NewTaskLabel = new Label {
                Text = txtTaskName.Text,
                Size = new Size(80, 70),
                BackColor=Color.Crimson,
                TextAlign = ContentAlignment.MiddleCenter,

                Dock = DockStyle.Left
            };
            Task.Controls.Add(NewTaskLabel);
            NewTaskLabelStatusToDo = new Label
            {
                Text ="To Do",
                BackColor=Color.AliceBlue,
                Size=new Size(50,30),
                Font = new System.Drawing.Font("Century", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162))),
                Location=new Point(80,0),
                TextAlign = ContentAlignment.MiddleLeft

            };
            NewTaskLabelStatusToDo.Click += new EventHandler(LabelStatusToDo_Click);
            Task.Controls.Add(NewTaskLabelStatusToDo);
            NewTaskLabelStatusInProgress = new Label
            {
                Text = "In Progress",
                BackColor = Color.AliceBlue,
                Size = new Size(50, 30),
                Font = new System.Drawing.Font("Century", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162))),
                Location = new Point(80, 30),
                TextAlign = ContentAlignment.MiddleLeft

            };
            NewTaskLabelStatusInProgress.Click += new EventHandler(LabelStatusInProgress_Click);

            Task.Controls.Add(NewTaskLabelStatusInProgress);
            NewTaskLabelStatusDone = new Label
            {
                Text = "Done",
                BackColor = Color.AliceBlue,
                Size = new Size(50, 30),
                Font = new System.Drawing.Font("Century",8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162))),
                Location = new Point(80, 60),
                TextAlign=ContentAlignment.MiddleLeft


            };
            NewTaskLabelStatusDone.Click += new EventHandler(LabelStatusDone_Click);

            Task.Controls.Add(NewTaskLabelStatusDone);
            TaskPanel.Visible = false;
            txtTaskName.Text = "";
        }


        

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Help help = new Help();
            help.Show();
        }
    }
}
