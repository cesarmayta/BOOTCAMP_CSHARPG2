﻿using HtmlAgilityPack;

class Program
{
    static async Task Main(string[] args)
    {
        string url = "https://www.sbs.gob.pe/app/pp/sistip_portal/paginas/publicacion/tipocambiopromedio.aspx";

        using HttpClient client = new HttpClient();

        var response = await client.GetStringAsync(url);

        //Console.WriteLine(response);

        if (response != null)
        {
            var html = new HtmlDocument();
            html.LoadHtml(response);

            var table = html.DocumentNode.SelectSingleNode("//table[@id='ctl00_cphContent_rgTipoCambio_ctl00']");
            //Console.WriteLine(table.InnerHtml);

            var row = table.SelectSingleNode(".//tr[@id='ctl00_cphContent_rgTipoCambio_ctl00__0']");
            //Console.WriteLine(row.InnerHtml);

            var nombreMoneda = row.SelectSingleNode(".//td[@class='APLI_fila3']");
            var montoMonedas = row.SelectNodes(".//td[@class='APLI_fila2']");
            //Console.WriteLine(nombreMoneda.InnerHtml);
            var moneda = nombreMoneda.InnerText.Trim();
            var compra = montoMonedas[0].InnerText.Trim();
            var venta = montoMonedas[1].InnerText.Trim();

            Console.WriteLine($"Moneda : {moneda}");
            Console.WriteLine($"Precio Compra: {compra}");
            Console.WriteLine($"Precio Venta : {venta}");
        }
    }
}

