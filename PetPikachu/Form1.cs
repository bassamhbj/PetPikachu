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
        private int SCREEN_WIDTH;
        private int SCREEN_HEIGHT;
        private const int MOVE_PIXELS = 8;

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

            // Get Screen Size
            var screenBounds = Screen.FromControl(this).Bounds;
            SCREEN_WIDTH = screenBounds.Width;
            SCREEN_HEIGHT = screenBounds.Height;

            // Start Animations
            StartAnimations().ConfigureAwait(false);
        }

        private async Task StartAnimations()
        {
            var spriteSheetPikachu = new SpriteSheetPikachu();
            var pikachuModel = spriteSheetPikachu.GetSprites();
            pikachuModel.InitAnimationSet();
            //var spriteSheetStatus = new SpriteSheetStatus();


            var animationPikachu = new AnimationPikachu(pikachuModel, this);
            //var animationStatus = new AnimationStatus(spriteSheetStatus.GetSprites(), this);

            var cancellationToken = new CancellationTokenSource();
            await animationPikachu.Animate(cancellationToken.Token);
            //await animationStatus.Animate(cancellationToken.Token);
        }

        public void AnimatePikachu(Bitmap sprite, AnimationManager.AninamtionType aninamtionType)
        {
            this.pictureBoxPikachu.Image = sprite;

            switch (aninamtionType) {
                case AnimationManager.AninamtionType.MOVE_FRONT:
                    if(!IsOutOfBounds(this.Location.X, this.Location.Y + MOVE_PIXELS))
                        this.Location = new Point(this.Location.X, this.Location.Y + MOVE_PIXELS);
                    break;
                case AnimationManager.AninamtionType.MOVE_LEFT:
                    if(!IsOutOfBounds(this.Location.X - MOVE_PIXELS, this.Location.Y))
                        this.Location = new Point(this.Location.X - MOVE_PIXELS, this.Location.Y);
                    break;
                case AnimationManager.AninamtionType.MOVE_RIGHT:
                    if(!IsOutOfBounds(this.Location.X + MOVE_PIXELS, this.Location.Y))
                        this.Location = new Point(this.Location.X + MOVE_PIXELS, this.Location.Y);
                    break;
                case AnimationManager.AninamtionType.MOVE_BACK:
                    if(!IsOutOfBounds(this.Location.X, this.Location.Y - MOVE_PIXELS))
                        this.Location = new Point(this.Location.X, this.Location.Y - MOVE_PIXELS);
                    break;
            }
        }

        public void AnimateStatus(SpriteModel.SpriteItem sprite)
        {
            this.pictureBoxStatus.Image = sprite.Image;
        }

        public void AnimatePikachuDebug(int animationIndex, int animationCount)
        {
            //this.label1.Text = $"Index: {animationIndex}";
            //this.label2.Text = $"Animation Count: {animationCount}";
        }

        private bool IsOutOfBounds(int x, int y) =>
            (x + this.Width) > SCREEN_WIDTH || x < 0 ||
            (y + this.Height) > SCREEN_HEIGHT || y < 0;
    }
}
