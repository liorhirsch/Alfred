using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace client
{
    public partial class MoviesList : Form
    {
        private List<Common.Models.Movie> _listOfMovies;

        public MoviesList()
        {
            InitializeComponent();
        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }

        private void MoviesList_Load(object sender, EventArgs e)
        {
            // Load data
            _listOfMovies = new List<Common.Models.Movie>();

            


        }
    }
}
