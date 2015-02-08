using GasAudit.Dal.Abstract;
using GasAudit.Dal.Concrete;
using GasAudit.Entities;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.ServiceModel.Channels;
using System.Web;
using System.Web.Http;

namespace GasAudit.WebUI.Controllers
{
    public class GasAuditController : ApiController
    {

        private static NLog.Logger logger = NLog.LogManager.GetCurrentClassLogger();

        [HttpGet]
        public List<tblGasTrends> GetAll()
        {
    
            string connectionString = ConfigurationManager.ConnectionStrings["GasAuditEntities_Web"].ConnectionString;
            IGasTrendsRepository gasTrendsRepository = new GasTrendsRepository(connectionString);

            string ip = GetClientIp();
            ip = string.IsNullOrEmpty(ip) ? "0.0.0.0" : ip;
            logger.Info(string.Format("Send all trends to user : {0}", ip));

            return gasTrendsRepository.GetAll();
        }

        [HttpPost]
        public void Insert(tblGasTrends trend)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["GasAuditEntities_Web"].ConnectionString;
            IGasTrendsRepository gasTrendsRepository = new GasTrendsRepository(connectionString);

            trend.Time = DateTime.Now;          //встановлюємо час сервера

            gasTrendsRepository.Insert(trend);
            string ip = GetClientIp();
            ip = string.IsNullOrEmpty(ip) ? "0.0.0.0" : ip;
            logger.Info(string.Format("Recived data drom user : {0}", ip));
        }


        //допоміжний метод для визначення IP  користувача
        private string GetClientIp(HttpRequestMessage request = null)
        {
            request = request ?? Request;

            if (request.Properties.ContainsKey("MS_HttpContext"))
            {
                return ((HttpContextWrapper)request.Properties["MS_HttpContext"]).Request.UserHostAddress;
            }
            else if (request.Properties.ContainsKey(RemoteEndpointMessageProperty.Name))
            {
                RemoteEndpointMessageProperty prop = (RemoteEndpointMessageProperty)request.Properties[RemoteEndpointMessageProperty.Name];
                return prop.Address;
            }
            else if (HttpContext.Current != null)
            {
                return HttpContext.Current.Request.UserHostAddress;
            }
            else
            {
                return null;
            }
        }
    }
}
