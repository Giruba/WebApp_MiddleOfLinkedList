using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MiddleOfLinkedList_WebApp
{
    public partial class Default : System.Web.UI.Page
    {
        private String noOfElementsString;
        private String allElementsString;

        private int noOfElements;
        private int[] allElements;
        private static LinkedList linkedList = new LinkedList();

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void TextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            noOfElementsString = TextBox1.Text;
            noOfElements = int.Parse(noOfElementsString);
            allElements = new int[noOfElements];
            allElementsString = TextBox2.Text;
            try
            {
                allElements = allElementsString.Contains(';') ?
                              Array.ConvertAll(allElementsString.Split(';'), int.Parse) :
                              Array.ConvertAll(allElementsString.Split(','), int.Parse);
            }
            catch (Exception arrayConvOrStringSplitException) {
                Label2.Text = "Enter elements delimited by comma(,) or semicolon(;)";
            }
            //linkedList = new LinkedList();
            linkedList.appendToList(allElements);
            TextBox3.Text = linkedList.displayLinkedList();
        }
        protected void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        protected void TextBox4_TextChanged(object sender, EventArgs e)
        {

        }

        protected void Button2_Click1(object sender, EventArgs e)
        {
            linkedList = linkedList.getCurrentList();
            TextBox4.Text = linkedList.findMiddleOfLinkedList(linkedList).ToString();
        }
    }
}