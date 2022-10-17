using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace calculaArea
{
    /// <summary>
    /// calculadora de Area 
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    
    public class calculaArea : System.Web.Services.WebService
    {

        [WebMethod]  

        public double ACirculo(double Radio)
        {
            Calcula r = new Calcula(); 
            return r.Circulo(Radio);
        }
        [WebMethod]
        public decimal ACuadrado(decimal Lado)
        {
            Calcula r = new Calcula();
            return r.Cuadrado(Lado);
        }
        [WebMethod]
        public decimal ATriangulo(decimal Base, decimal Altura)
        {
            Calcula r = new Calcula();
            return r.Triangulo(Base, Altura);
        }
    }
}
