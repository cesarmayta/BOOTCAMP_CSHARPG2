using HtmlAgilityPack;

class Program
{
    static async Task Main(string[] args)
    {
        string url = "https://www.sbs.gob.pe/app/pp/sistip_portal/paginas/publicacion/tipocambiopromedio.aspx";

        using HttpClient client = new HttpClient();

        var response = await client.GetStringAsync(url);

        if (response != null)
        {
            var html = new HtmlDocument();
            html.LoadHtml(response);

            var table = html.DocumentNode.SelectSingleNode("//table[@id='ctl00_cphContent_rgTipoCambio_ctl00']");
            Console.WriteLine(table.InnerHtml);

            
        }
    }
}

