namespace MethodsPractice
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Checks if a number is within a specific inclusive range
        /// </summary>
        /// <param name="numCheck"></param>
        /// <param name="minVal"></param>
        /// <param name="maxVal"></param>
        /// <returns></returns>
        private bool IsWithinRange(int numCheck, int minVal, int maxVal)
        {
            if (numCheck >= minVal && numCheck <= maxVal)
            {
                return true;
            }
            return false;
        }
    }
}
