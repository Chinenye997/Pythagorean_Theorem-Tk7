using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pythagorean_Theorem
{
    public partial class Pyth : Form
    {
        public Pyth()
        {
            InitializeComponent();
        }


        private double hypotenus(double opp, double adj)
        {
            double hyp = Math.Sqrt(Math.Pow(opp,2) + Math.Pow(adj,2));
            return hyp;
        }
        private double adjacent(double hyp, double opp)
        {
            double adj = Math.Sqrt(Math.Pow(hyp, 2) - Math.Pow(opp, 2));
            return adj;
        }
        private double opposite(double hyp, double adj)
        {
            double opp = Math.Sqrt(Math.Pow(hyp, 2) - Math.Pow(adj, 2));
            return opp;
        }
        private void Sidescmb_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Sidescmb.Text == "Adjacent")
            {
                firstlb1.Text = "Opposite";
                seclbl.Text = "Hypotenus";
            }
            else if (Sidescmb.Text == "Opposite")
            {
                firstlb1.Text = "Adjacent";
                seclbl.Text = "Hypotenus";
            }
            if (Sidescmb.Text == "Hypotenus")
            {
                firstlb1.Text = "Adjacent";
                seclbl.Text = "Opposite";
            }

          
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Clicked!"); // Button to click

            if (Sidescmb.Text != "")
            {

                if (firsttxt.Text != "" || sectxt.Text != "")
                {
                    if (Sidescmb.Text == "Opposite" & Convert.ToDouble (sectxt.Text) <= Convert.ToDouble(firsttxt.Text)) 
                    {
                        MessageBox.Show("The Hypotenus is the longest side!");

                    }

                    else if (Sidescmb.Text == "Adjacent" &Convert.ToDouble(sectxt.Text) <= Convert.ToDouble(firsttxt.Text)) 
                    {
                        MessageBox.Show("The Hypotenus is always the longest side!");

                    }
                    else if(Sidescmb.Text == "Hypotenus")
                    {
                       double hyp = hypotenus(Convert.ToDouble(firsttxt.Text), Convert.ToDouble(sectxt.Text));
                       Answertxt.Text = hyp.ToString();
                    }
                    else if (Sidescmb.Text == "Adjacent")
                    {
                        double Adj = adjacent(Convert.ToDouble(sectxt.Text), Convert.ToDouble(firsttxt.Text));
                        Answertxt.Text =Adj.ToString();
                    }
                    else if (Sidescmb.Text == "Opposite")
                    {
                        double opp = opposite(Convert.ToDouble(sectxt.Text), Convert.ToDouble(firsttxt.Text));
                        Answertxt.Text = opp.ToString();
                    }

                }
                else
                {
                    MessageBox.Show("Provide values for the availble sides");
                }
               
            }
            else
            {
                MessageBox.Show("Choose a side to find for");
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            
            firsttxt.Text = string.Empty;
            sectxt.Text = string.Empty;
            Answertxt.Text = string.Empty;

            
            Sidescmb.SelectedIndex = -1; // Clear the selected side
            firstlb1.Text = "First Side";
            seclbl.Text = "Second Side";

        }

        private void btnShowFormula_Click(object sender, EventArgs e)
        {
            // Check the current text of the button
            if (btnShowFormula.Text == "Show Formula")
            { 
                btnShowFormula.Text = "a² + b² = c²";
            }
            else
            {
                btnShowFormula.Text = "Show Formula";
            }
        }

       
    }   
}

    

