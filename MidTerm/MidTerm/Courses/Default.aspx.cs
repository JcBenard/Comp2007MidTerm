using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.Entity;
using MidTerm.Models;

namespace MidTerm.Courses
{
    public partial class Default : System.Web.UI.Page
    {
		protected MidTerm.Models.DefaultConnection _db = new MidTerm.Models.DefaultConnection();

        protected void Page_Load(object sender, EventArgs e)
        {
        }

        // Model binding method to get List of Cours entries
        // USAGE: <asp:ListView SelectMethod="GetData">
        public IQueryable<MidTerm.Models.Cours> GetData()
        {
            return _db.Courses;
        }
    }
}

