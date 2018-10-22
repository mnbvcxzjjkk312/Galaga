using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Galag
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            BulletPB.Visible = false;
        }

        Rectangle bullet1 = new Rectangle();

        // 총알 위치
        private void BulletLocation()
        {

        }

        // Form x, y 좌표
        int FormX = 350;
        int FormY = 600;

        // Player x, y 좌표
        int playerX;
        int playerY;

        // Player 가로, 세로 길이
        int playerWidth;
        int playerHeight;

        Point point= new Point();
        bool hasBullet = true;
        
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Right)
            {
                Point p = new Point(PlayerPB.Location.X + 5, PlayerPB.Location.Y);
                PlayerPB.Location = p;
            }
            else if (e.KeyCode == Keys.Left)
            {
                Point p = new Point(PlayerPB.Location.X - 5, PlayerPB.Location.Y);
                PlayerPB.Location = p;
            }
            // space bar를 누르면 
            // 1. 비행기의 앞에서 총알이 생성된다.
            // 2. 총알은 화면 안에서 1개만 사용할 수 있다.
            // 3. 총알은 화면 끝까지 가면 소멸한다.
            // 4. 화면 안에 총알이 있을 경우 두번째 총알은 나오지 않는다. 
            // 5. 
            if (e.KeyCode == Keys.Space)
            {
                hasBullet = false;
                BulletPB.Visible = true;

                PlayerAndBulletLocation();
            }
        }

        public void PlayerAndBulletLocation()
        {
            //BulletLocation(); //총알 위치
            //int bulletY = BulletPB.Location.Y;
            //int bulletX = BulletPB.Location.X;

            //플레이어 W, H
            playerWidth = PlayerPB.Size.Width;
            playerHeight = PlayerPB.Size.Height;

            point.X = PlayerPB.Location.X + 10;
            point.Y = PlayerPB.Location.Y - playerHeight;

            Point p = new Point(point.X, point.Y);
            BulletPB.Location = p;

            if (BulletPB.Location.Y == FormY && BulletPB.Visible)
            {
                BulletPB.Visible = false;
                hasBullet = true;
            }
        }

    }
}