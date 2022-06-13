using PetPikachu.Animation;
using PetPikachu.Model;
using PetPikachu.Sprite;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PetPikachu
{
    public partial class Form1 : Form, IAnimationListerner
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Set Form transparency
            this.ControlBox = false;
            this.Text = String.Empty;
            this.FormBorderStyle = FormBorderStyle.None;
            this.BackColor = Color.Cornsilk;
            this.TransparencyKey = Color.Cornsilk;

            this.pictureBoxPikachu.BackColor = Color.Cornsilk;
            this.pictureBoxStatus.BackColor = Color.Cornsilk;

            // Set Always on top
            this.TopMost = true;

            // Set Form initial Position
            this.StartPosition = FormStartPosition.Manual;
            this.Location = new Point(1513, 808);

            // Start Animations
            StartAnimations().ConfigureAwait(false);
        }

        private async Task StartAnimations()
        {
            var spriteSheetPikachu = new SpriteSheetPikachu();
            //var spriteSheetStatus = new SpriteSheetStatus();


            var animationPikachu = new AnimationPikachu(spriteSheetPikachu.GetSprites(), this);
            //var animationStatus = new AnimationStatus(spriteSheetStatus.GetSprites(), this);

            var cancellationToken = new CancellationTokenSource();
            await animationPikachu.Animate(cancellationToken.Token);
            //await animationStatus.Animate(cancellationToken.Token);
        }

        public void AnimatePikachu(SpriteModel.SpriteItem sprite)
        {
            this.pictureBoxPikachu.Image = sprite.Image;

            this.Location = new Point(this.Location.X - 8, this.Location.Y);
        }

        public void AnimateStatus(SpriteModel.SpriteItem sprite)
        {
            this.pictureBoxStatus.Image = sprite.Image;
        }
    }
}
