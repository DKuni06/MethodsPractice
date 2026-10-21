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
        /// <param name="numCheck">The number to check if it's within the range</param>
        /// <param name="minVal">Minimum inclusive value to compare</param>
        /// <param name="maxVal">Maximum inclusive value to compare</param>
        /// <returns></returns>
        private static bool IsWithinRange(int numCheck, int minVal, int maxVal)
        {
            if (numCheck >= minVal && numCheck <= maxVal)
            {
                return true;
            }
            return false;
        }
    }
}
