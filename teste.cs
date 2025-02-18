  using System;

public partial class Teste : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        System.Threading.Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo("pt-BR");
        System.Threading.Thread.CurrentThread.CurrentCulture = System.Globalization.CultureInfo.CreateSpecificCulture("pt-BR");

        if (!IsPostBack)

        {
            var vDadosPartic = '';
            TituloGrafico.InnerText = "Reserva do Participante";
            TxtPaginaTitulo.Text = "Reserva do Participante";
            PreencheGrafico(vDadosPartic);
            PreencheDadosPlano(vDadosPartic);
        }
    }
