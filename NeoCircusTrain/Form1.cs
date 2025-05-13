using NeoCircusTrain.Classes;

namespace NeoCircusTrain
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void DecreaseLabel(Label label)
        {
            if (int.TryParse(label.Text, out int value) && value > 0)
            {
                label.Text = (value - 1).ToString();
            }
        }

        private void IncreaseLabel(Label label)
        {
            if (int.TryParse(label.Text, out int value))
            {
                label.Text = (value + 1).ToString();
            }
        }

        private void BTNCSmallDecrease_Click(object sender, EventArgs e)
        {
            DecreaseLabel(LBL_CSmall);
        }

        private void BTNCSmallIncrease_Click(object sender, EventArgs e)
        {
            IncreaseLabel(LBL_CSmall);
        }

        private void BTNCMediumDecrease_Click(object sender, EventArgs e)
        {
            DecreaseLabel(LBL_CMedium);
        }

        private void BTNCMediumIncrease_Click(object sender, EventArgs e)
        {
            IncreaseLabel(LBL_CMedium);
        }

        private void BTNCLargeDecrease_Click(object sender, EventArgs e)
        {
            DecreaseLabel(LBL_CLarge);
        }

        private void BTNCLargeIncrease_Click(object sender, EventArgs e)
        {
            IncreaseLabel(LBL_CLarge);
        }

        private void BTNHSmallDecrease_Click(object sender, EventArgs e)
        {
            DecreaseLabel(LBL_HSmall);
        }

        private void BTNHSmallIncrease_Click(object sender, EventArgs e)
        {
            IncreaseLabel(LBL_HSmall);
        }

        private void BTNHMediumDecrease_Click(object sender, EventArgs e)
        {
            DecreaseLabel(LBL_HMedium);
        }

        private void BTNHMediumIncrease_Click(object sender, EventArgs e)
        {
            IncreaseLabel(LBL_HMedium);
        }

        private void BTNHLargeDecrease_Click(object sender, EventArgs e)
        {
            DecreaseLabel(LBL_HLarge);
        }

        private void BTNHLargeIncrease_Click(object sender, EventArgs e)
        {
            IncreaseLabel(LBL_HLarge);
        }

        private void BTNActCreateTrain_Click(object sender, EventArgs e)
        {

        }
    }
}
