using System;
using Newtonsoft.Json;
using System.Xml.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// KoubeiRetailWmsSupplierreportdetailQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class KoubeiRetailWmsSupplierreportdetailQueryModel : AlipayObject
    {
        /// <summary>
        /// 供货商盘点单id
        /// </summary>
        [JsonProperty("supplier_report_id")]
        [XmlElement("supplier_report_id")]
        public string SupplierReportId { get; set; }
    }
}
