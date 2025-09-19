using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dự_án_cuối_kì_OOP
{

    public partial class PersonalScheduleManager : Form
    {
        private bool isKittyBackground = false;

        public PersonalScheduleManager()
        {
            InitializeComponent();                  // gọi bản trong Designer
            this.BackgroundImageLayout = ImageLayout.Stretch;
        }

        private void btnChangeBackground_Click(object sender, EventArgs e)
        {
            string imgPath = Path.Combine(Application.StartupPath, "hello_kitty.png");

            if (!isKittyBackground)
            {
                if (File.Exists(imgPath))
                {
                    this.BackgroundImage?.Dispose();
                    this.BackgroundImage = Image.FromFile(imgPath);
                }
                else
                {
                    MessageBox.Show("Không tìm thấy ảnh: " + imgPath);
                }
            }
            else
            {
                this.BackgroundImage?.Dispose();
                this.BackgroundImage = null;
                this.BackColor = Color.LightBlue;
            }

            isKittyBackground = !isKittyBackground;
        }
        private void PersonalScheduleManager_Load(object sender, EventArgs e)
        {
            // TODO: code khởi tạo sau khi form load
            // ví dụ:
            this.BackgroundImageLayout = ImageLayout.Stretch;
        }

        private void btnChangeBackGround_Click_1(object sender, EventArgs e)
        {
            this.btnChangeBackGround.Click += new System.EventHandler(this.btnChangeBackground_Click);

            using (OpenFileDialog dlg = new OpenFileDialog())
            {
                dlg.Title = "Chọn ảnh nền";
                dlg.Filter = "Ảnh (*.png;*.jpg;*.jpeg)|*.png;*.jpg;*.jpeg|Tất cả|*.*";

                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    // đổi nền cho container bạn muốn (Form, tableLayoutPanel1, panel1...)
                    TableLayoutPanel target = this.tableLayoutPanel1; // hoặc Panel target = this.panel1;
                    if (target.BackgroundImage != null)
                    {
                        target.BackgroundImage.Dispose();
                    }
                    target.BackgroundImage = Image.FromFile(dlg.FileName);
                    target.BackgroundImageLayout = ImageLayout.Stretch;
                }
            }


        }
    }
}



