using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace EsercizioFigureGeometriche2
{
    public partial class Prima : System.Web.UI.Page
    {
        
        protected void Page_Load(object sender, EventArgs e)
        {
           
        }
      

        protected void BottoneTriangolo_Click(object sender, EventArgs e)
        {
           
            test3.Text = "1";
            test4.Text = "1";
            tr0.Visible = true;
            td1.Visible = true;
            td2.Visible = true;
            td3.Visible = false;
            trinizio2.Visible = false;
            trinizio3.Visible = false;

        }

        protected void BottoneCerchio_Click(object sender, EventArgs e)
        {
           
            test3.Text = "2";
            test4.Text = "2";
            tr0.Visible = true;
            td3.Visible = true;
            td1.Visible = false;
            td2.Visible = false;
            trinizio.Visible = false;
            trinizio3.Visible = false;

        }

        protected void BottoneRettangolo_Click(object sender, EventArgs e)
        {
            
           
            test3.Text = "3";
            test4.Text = "1";

            tr0.Visible = true;
            td1.Visible = true;
            td2.Visible = true;
            td3.Visible = false;
            trinizio.Visible = false;
            trinizio2.Visible = false;
        }

        protected void BottoneCalcolo_Click(object sender, EventArgs e)
        {
           
            if(test4.Text=="1")
            {
                if (TextLato.Text != "" && TextAltezza.Text != "")
                {
                    if (test3.Text == "3")
                    {
                        if (TextLato.Text == TextAltezza.Text)
                        {
                            test3.Text = "4";
                        }
                    }

                    if (test3.Text == "1")
                    {
                        Triangolo triangolo = new Triangolo();
                        TextAreaT.Text = triangolo.Area(Convert.ToInt32(TextLato.Text), Convert.ToInt32(TextAltezza.Text), 0).ToString();
                        TextPerimetroT.Text = triangolo.Perimetro(Convert.ToInt32(TextLato.Text), Convert.ToInt32(TextAltezza.Text), 0).ToString();
                        tr1.Visible = true;
                    }
                    else
                    {
                        if (test3.Text == "2")
                        {
                            Cerchio cerchio = new Cerchio();
                            TextPerimetroC.Text = cerchio.Perimetro(0, 0, Convert.ToInt32(TextRaggio.Text)).ToString();
                            TextAreaC.Text = cerchio.Area(0, 0, Convert.ToInt32(TextRaggio.Text)).ToString();
                            tr2.Visible = true;
                        }
                        else
                        {
                            if (test3.Text == "3")
                            {
                                Rettangolo rettangolo = new Rettangolo();
                                TextAreaR.Text = rettangolo.Area(Convert.ToInt32(TextLato.Text), Convert.ToInt32(TextAltezza.Text), 0).ToString();
                                TextPerimetroR.Text = rettangolo.Perimetro(Convert.ToInt32(TextLato.Text), Convert.ToInt32(TextAltezza.Text), 0).ToString();
                                tr3.Visible = true;
                            }

                            else
                            {
                                Quadrato quadrato = new Quadrato();
                                TextAreaQ.Text = quadrato.Area(Convert.ToInt32(TextLato.Text), 0, 0).ToString();
                                TextPerimetroQ.Text = quadrato.Perimetro(Convert.ToInt32(TextLato.Text), 0, 0).ToString();
                                tr4.Visible = true;
                            }
                        }
                    }
                }
            }
            else
            {
                if (TextRaggio.Text!="")
                {
                    if (test3.Text == "3")
                    {
                        if (TextLato.Text == TextAltezza.Text)
                        {
                            test3.Text = "4";
                        }
                    }

                    if (test3.Text == "1")
                    {
                        Triangolo triangolo = new Triangolo();
                        TextAreaT.Text = triangolo.Area(Convert.ToInt32(TextLato.Text), Convert.ToInt32(TextAltezza.Text), 0).ToString();
                        TextPerimetroT.Text = triangolo.Perimetro(Convert.ToInt32(TextLato.Text), Convert.ToInt32(TextAltezza.Text), 0).ToString();
                        tr1.Visible = true;
                    }
                    else
                    {
                        if (test3.Text == "2")
                        {
                            Cerchio cerchio = new Cerchio();
                            TextPerimetroC.Text = cerchio.Perimetro(0, 0, Convert.ToInt32(TextRaggio.Text)).ToString();
                            TextAreaC.Text = cerchio.Area(0, 0, Convert.ToInt32(TextRaggio.Text)).ToString();
                            tr2.Visible = true;
                        }
                        else
                        {
                            if (test3.Text == "3")
                            {
                                Rettangolo rettangolo = new Rettangolo();
                                TextAreaR.Text = rettangolo.Area(Convert.ToInt32(TextLato.Text), Convert.ToInt32(TextAltezza.Text), 0).ToString();
                                TextPerimetroR.Text = rettangolo.Perimetro(Convert.ToInt32(TextLato.Text), Convert.ToInt32(TextAltezza.Text), 0).ToString();
                                tr3.Visible = true;
                            }

                            else
                            {
                                Quadrato quadrato = new Quadrato();
                                TextAreaQ.Text = quadrato.Area(Convert.ToInt32(TextLato.Text), 0, 0).ToString();
                                TextPerimetroQ.Text = quadrato.Perimetro(Convert.ToInt32(TextLato.Text), 0, 0).ToString();
                                tr4.Visible = true;
                            }
                        }
                    }
                }
            }
         
         
            
        }
    }
}