using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ConditionalRadioButton
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (RadioButton1.Checked)
            {
                Label1.Text = "Of course it is! The are mine aswell, I recomend the books.";
            }
            else if (RadioButton2.Checked)
            {
                Label1.Text = "Well they do say it is the best movie of all time!";
            }
            else if (RadioButton3.Checked)
            {
                Label1.Text = "Helped define a genre and produced the best monster in film, not a bad pick!";
            }
            else if (RadioButton4.Checked)
            {
                Label1.Text = "An over all amazing movie, the great actors made it that much better!";
            }
            else
            {
                Label1.Text = "Well? What is it? Or do you not like these?";
            }/*
            if (RadioButton1.Checked)
            {
                Image1.ImageUrl = "Ringstrilogyposter.jpg";
            }
            else if (RadioButton2.Checked)
            {
                Image1.ImageUrl = "The_Godfather,_The_Game.jpg";
            }
            else if (RadioButton3.Checked)
            {
                Image1.ImageUrl = "Alien_2XLP_FC_a5c27829-ef23-4f62-8b56-dc844f53df9d_1024x1024.jpg";
            }
            else if (RadioButton4.Checked)
            {
                Image1.ImageUrl = "5vZw7ltCKI0JiOYTtRxaIC3DX0e.jpg";
            }
            else
            {
                Image1.ImageUrl = "C8qDcUcWsAAHGK_.jpg";
            }*/
        }
    }
        
}
//Image1.ImageUrl= "Ringstrilogyposter.jpg";
//Image1.ImageUrl = "The_Godfather,_The_Game.jpg";
//Image1.ImageUrl = "Alien_2XLP_FC_a5c27829-ef23-4f62-8b56-dc844f53df9d_1024x1024.jpg";
//Image1.ImageUrl = "5vZw7ltCKI0JiOYTtRxaIC3DX0e.jpg";
//Image1.ImageUrl = "C8qDcUcWsAAHGK_.jpg";