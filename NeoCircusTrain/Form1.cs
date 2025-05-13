using NeoCircusTrain.Classes;

namespace NeoCircusTrain
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            //pass
        }

        private void BTNCSmallDecrease_Click(object sender, EventArgs e)
        {
            LBL_CSmall.Text = (int.Parse(LBL_CSmall.Text) - 1).ToString();

        }

        private void BTNCSmallIncrease_Click(object sender, EventArgs e)
        {
            LBL_CSmall.Text = (int.Parse(LBL_CSmall.Text) + 1).ToString();

        }

        private void BTNCMediumDecrease_Click(object sender, EventArgs e)
        {
            LBL_CMedium.Text = (int.Parse(LBL_CMedium.Text) - 1).ToString();

        }

        private void BTNCMediumIncrease_Click(object sender, EventArgs e)
        {
            LBL_CMedium.Text = (int.Parse(LBL_CMedium.Text) + 1).ToString();
        }

        private void BTNCLargeDecrease_Click(object sender, EventArgs e)
        {
            LBL_CLarge.Text = (int.Parse(LBL_CLarge.Text) - 1).ToString();
        }

        private void BTNCLargeIncrease_Click(object sender, EventArgs e)
        {
            LBL_CLarge.Text = (int.Parse(LBL_CLarge.Text) + 1).ToString();
        }

        private void BTNHSmallDecrease_Click(object sender, EventArgs e)
        {
            LBL_HSmall.Text = (int.Parse(LBL_HSmall.Text) - 1).ToString();

        }

        private void BTNHSmallIncrease_Click(object sender, EventArgs e)
        {
            LBL_HSmall.Text = (int.Parse(LBL_HSmall.Text) + 1).ToString();

        }

        private void BTNHMediumDecrease_Click(object sender, EventArgs e)
        {
            LBL_HMedium.Text = (int.Parse(LBL_HMedium.Text) - 1).ToString();

        }

        private void BTNHMediumIncrease_Click(object sender, EventArgs e)
        {
            LBL_HMedium.Text = (int.Parse(LBL_HMedium.Text) + 1).ToString();

        }

        private void BTNHLargeDecrease_Click(object sender, EventArgs e)
        {
            LBL_HLarge.Text = (int.Parse(LBL_HLarge.Text) - 1).ToString();

        }

        private void BTNHLargeIncrease_Click(object sender, EventArgs e)
        {
            LBL_HLarge.Text = (int.Parse(LBL_HLarge.Text) + 1).ToString();

        }
    }
}
