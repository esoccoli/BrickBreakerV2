using Microsoft.Xna.Framework;
using static Devcade.Input;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace BrickBreaker
{
    public class Instructions : State
    {
        public Instructions(SpriteBatch sb, 
            GraphicsDevice graphics, 
            Game1 game, 
            SpriteFont notoSans, 
            SpriteFont notoSansSmall, 
            SpriteFont paytoneOne, 
            Texture2D redButton, 
            Texture2D blueButton, 
            Texture2D greenButton, Texture2D whiteButton)
            : base(sb, 
            graphics, 
            game, 
            notoSans, 
            notoSansSmall, 
            paytoneOne, 
            redButton, 
            blueButton,
            greenButton, 
            whiteButton)
        {
            SB = sb;
            Graphics = graphics;
            Game = game;
            
            PaytoneOne = paytoneOne;
            NotoSans = notoSans;
            NotoSansSmall = notoSansSmall;
            
            Window = Graphics.Viewport.Bounds;
            
            RedButton = redButton;
            BlueButton = blueButton;
            GreenButton = greenButton;
            WhiteButton = whiteButton;
        }
        
        /// <summary>
        /// Determines whether the state should be updated
        /// </summary>
        public void UpdateInstructions()
        {
            if (Keyboard.GetState().IsKeyDown(Keys.B) ||
                GetButtonDown(1, ArcadeButtons.A3) ||
                GetButtonDown(2, ArcadeButtons.A3))
            {
                Game.currState = GameState.Menu;
            }
        }

        public void DrawText()
        {
            SB.DrawString(PaytoneOne, "Controls", new Vector2(110, 30), Color.White);
            
            SB.DrawString(NotoSansSmall, "Move the joystick to move the paddle", new Vector2(Window.Center.X - 185, Window.Center.Y - 300), Color.White);
            SB.DrawString(NotoSansSmall, "Break all the bricks to win", new Vector2(Window.Center.X - 125, Window.Center.Y - 200), Color.White);
            SB.DrawString(NotoSansSmall, "Try to win with all 5 lives", new Vector2(Window.Center.X - 125, Window.Center.Y - 100), Color.White);
            
            SB.DrawString(NotoSansSmall, "Press ", new Vector2(Window.Center.X - 150, Window.Center.Y), Color.White);
            SB.Draw(GreenButton, new Rectangle(Window.Center.X - 80, Window.Center.Y - 10, 50, 50), Color.White);
            SB.DrawString(NotoSansSmall, " to return to menu", new Vector2(Window.Center.X - 20, Window.Center.Y), Color.White);
            
            SB.Draw(Game.surprisedPikachu, new Rectangle(0, Window.Center.Y, Window.Width, Window.Height / 2), Color.White);
        }
    }
}