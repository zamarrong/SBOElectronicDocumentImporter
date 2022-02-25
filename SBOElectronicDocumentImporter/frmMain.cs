using SAPbobsCOM;
using System;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using System.Xml.Linq;

namespace SBOElectronicDocumentImporter
{
    public partial class frmMain : Form
    {
        public static Company sap { get; set; }

        public class ElectronicDocument
        {
            public string SourceType { get; set; }
            public int SourceObject { get; set; }
            public string ObjectID { get; set; }
            public string ReportID { get; set; }
            public string Message { get; set; }
            public DateTime PostingDate { get; set; }
            public string SignMsg { get; set; }
            public string SignDigest { get; set; }
        }
        public frmMain()
        {
            InitializeComponent();
        }

        private void btnConnect_Click(object sender, System.EventArgs e)
        {
            groupBox2.Enabled = ConnectSBO();
        }

        public bool ConnectSBO()
        {
            try
            {
                sap = new Company();

                sap.Server = txtServer.Text;
                sap.SLDServer = txtLicenseServer.Text;
                sap.LicenseServer = txtLicenseServer.Text;
                switch (cbServerTypes.SelectedIndex)
                {
                    case 0:
                        sap.DbServerType = BoDataServerTypes.dst_MSSQL2008;
                        break;
                    case 1:
                        sap.DbServerType = BoDataServerTypes.dst_MSSQL2012;
                        break;
                    case 2:
                        sap.DbServerType = BoDataServerTypes.dst_MSSQL2014;
                        break;
                    case 3:
                        sap.DbServerType = BoDataServerTypes.dst_MSSQL2016;
                        break;
                    case 4:
                        sap.DbServerType = BoDataServerTypes.dst_HANADB;
                        break;
                }
                
                sap.CompanyDB = txtDB.Text;
                sap.DbUserName = txtDBUserName.Text;
                sap.DbPassword = txtDBPassword.Text;
                sap.UserName = txtSBOUserName.Text;
                sap.Password = txtSBOPassword.Text;
                sap.language = BoSuppLangs.ln_Spanish_La;

                sap.UseTrusted = false;

                if (sap.Connect() == 0)
                    return true;

                MessageBox.Show(string.Format("SAP Error: {0}", sap.GetLastErrorDescription()));
                return false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(string.Format("Error: {0}, SAP Error: {1}", ex.Message, sap.GetLastErrorDescription()));
                return false;
            }
        }

        public bool ImportElectronicDocument(ElectronicDocument electronic_document)
        {
            try
            {
                CompanyService service = sap.GetCompanyService();
                ElectronicCommunicationActionsService eservice = service.GetBusinessService(ServiceTypes.ElectronicCommunicationActionsService);
                EcmAction action = eservice.GetDataInterface(ElectronicCommunicationActionsServiceDataInterfaces.ecasEcmAction);

                action.Protocol = "M";
                action.Type = (rbPayment.Checked) ? EcmActionTypeEnum.latPaymentIncoming : EcmActionTypeEnum.latDocumentAR;
                action.Status = EcmActionStatusEnum.lasAuthorized;
                action.GenerationType = EcmActionGenerationTypeEnum.lgtGenerate;
                action.SourceType = electronic_document.SourceType;
                action.SourceObject = electronic_document.SourceObject;
                action.ObjectID = electronic_document.ObjectID;
                action.Submits = 0;
                action.ReportID = electronic_document.ReportID;
                action.Message = electronic_document.Message;

                //action.UserFields.Item("U_B1SYS_FechaTimbr").Value = electronic_document.PostingDate.ToString("yyyy-MM-ddTHH:mm:ss");
                //action.UserFields.Item("U_B1SYS_SignMsg").Value = electronic_document.SignMsg;
                //action.UserFields.Item("U_B1SYS_SignDigest").Value = electronic_document.SignDigest;

                var action_result = eservice.AddEcmAction(action);

                EcmActionLog action_log = eservice.GetDataInterface(ElectronicCommunicationActionsServiceDataInterfaces.ecasEcmActionLog);

                action_log.ActionID = action_result.ActionID;
                action_log.Type = EcmActionLogTypeEnum.altReceive;
                action_log.LogDate = DateTime.Now;
                action_log.LogTime = 1234;
                action_log.Message = "SBOElectronicDocumentImporter";
                action_log.Data = electronic_document.SignDigest;

                var action_log_result = eservice.AddEcmActionLog(action_log);

                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(string.Format("Error: {0}, SAP Error: {1}", ex.Message, sap.GetLastErrorDescription()));
                return false;
            }
        }

        public string GetSourceType()
        {
            try
            {
                if (rbPayment.Checked)
                    return "170";

                switch (cbTypes.SelectedIndex)
                {
                    case 0:
                        return "13";
                    case 1:
                        return "14";
                }

                return string.Empty;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return string.Empty;
            }
        }

        public string GetObjectType()
        {
            try
            {
                if (rbPayment.Checked)
                    return "IP";

                switch (cbTypes.SelectedIndex)
                {
                    case 0:
                        return "IN";
                    case 1:
                        return "CM";
                }

                return string.Empty;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return string.Empty;
            }
        }

        private void rbDocument_CheckedChanged(object sender, EventArgs e)
        {
            cbTypes.Enabled = rbDocument.Checked;
        }

        private ElectronicDocument FillElectronicDocument()
        {
            try
            {
                ElectronicDocument electronic_document = new ElectronicDocument();
                electronic_document.SourceType = GetSourceType();
                electronic_document.SourceObject = int.Parse(txtDocEntry.Text);
                electronic_document.ObjectID = string.Format("{0} {1}", GetObjectType(), txtDocNum.Text);
                electronic_document.ReportID = txtReportID.Text;
                electronic_document.Message = "Documento importado desde SBOElectronicDocumentImporter";

                electronic_document.PostingDate = dtDate.Value;
                electronic_document.SignMsg = txtSignMsg.Text;
                electronic_document.SignDigest = txtSignDigest.Text;

                return electronic_document;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return new ElectronicDocument();
            }
        }

        private void btnImport_Click(object sender, EventArgs e)
        {
            if (ImportElectronicDocument(FillElectronicDocument()))
                MessageBox.Show("Se realizó la importación correctamente.");
            else
                MessageBox.Show("No fue posible realizar la importación, verifique la información y trate nuevamente");
        }

        private void btnImportFromExcel_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog of = new OpenFileDialog();
                of.Filter = "Excel Files|*.xls;*.xlsx;*.xlsm";
                if (of.ShowDialog() == DialogResult.OK)
                {
                    MessageBox.Show(of.FileName);

                    Microsoft.Office.Interop.Excel.Application xlApp = new Microsoft.Office.Interop.Excel.Application();
                    Microsoft.Office.Interop.Excel.Workbook xlWorkbook = xlApp.Workbooks.Open(of.FileName);
                    Microsoft.Office.Interop.Excel.Worksheet xlWorksheet = xlWorkbook.ActiveSheet;

                    int rowCount = xlWorksheet.Rows.Count;

                    for (int i = 1; i <= rowCount; i++)
                    {
                        ElectronicDocument electronic_document = new ElectronicDocument();

                        electronic_document.SourceType = xlWorksheet.Cells[i, 1].Value.ToString();
                        electronic_document.SourceObject = int.Parse(xlWorksheet.Cells[i, 2].Value.ToString());
                        electronic_document.ReportID = xlWorksheet.Cells[i, 3].Value.ToString();
                        electronic_document.ObjectID = string.Format("{0} {1}", GetObjectType(), xlWorksheet.Cells[i, 4].Value.ToString());
                        electronic_document.Message = "Documento importado desde SBOElectronicDocumentImporter (Excel)";
                        electronic_document.PostingDate = DateTime.Now;
                        electronic_document.SignMsg = string.Empty;
                        electronic_document.SignDigest = string.Empty;

                        if (!ImportElectronicDocument(electronic_document))
                        {
                            MessageBox.Show(string.Format("No fue posible importar el documento electrónico {0}, Error: {1}", electronic_document.ReportID, sap.GetLastErrorDescription()));
                        }
                    }

                    GC.Collect();
                    GC.WaitForPendingFinalizers();

                    Marshal.ReleaseComObject(xlWorksheet);

                    xlWorkbook.Close();
                    Marshal.ReleaseComObject(xlWorkbook);

                    xlApp.Quit();
                    Marshal.ReleaseComObject(xlApp);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnCancelarDocmentos_Click(object sender, EventArgs e)
        {
            try
            {
                string query = @txtReportID.Text;
                Recordset oRecordset = (Recordset)sap.GetBusinessObject(BoObjectTypes.BoRecordset);
                if (oRecordset != null)
                {
                    oRecordset.DoQuery(query);
                    if (oRecordset.RecordCount > 0)
                    {
                        while (!oRecordset.EoF)
                        {
                            int DocEntry = (int)oRecordset.Fields.Item(0).Value;
                            try
                            {
                                txtSignMsg.Text += DocEntry + ", ";
                                Documents document = (Documents)sap.GetBusinessObject(BoObjectTypes.oInvoices);
                                if (document != null)
                                {
                                    if (document.GetByKey(DocEntry))
                                    {
                                        Documents cn = (Documents)sap.GetBusinessObject(BoObjectTypes.oCreditNotes);

                                        cn.Series = 80;
                                        cn.DocDate = document.DocDate;
                                        cn.TaxDate = document.TaxDate;
                                        cn.DocDueDate = document.DocDueDate;
                                        cn.CardCode = document.CardCode;
                                        cn.DocType = BoDocumentTypes.dDocument_Service;

                                        document.Lines.SetCurrentLine(0);
                                        cn.Lines.SetCurrentLine(0);
                                        cn.Lines.AccountCode = document.Lines.AccountCode;
                                        cn.Lines.ItemDescription = document.Lines.ItemDescription;
                                        cn.Lines.TaxCode = document.Lines.TaxCode;
                                        cn.Lines.BaseEntry = document.DocEntry;
                                        cn.Lines.BaseType = 13;
                                        cn.Lines.BaseLine = document.Lines.LineNum;
                                        cn.Lines.UnitPrice = document.Lines.UnitPrice;
                                        cn.Lines.Price = document.Lines.Price;
                                        cn.Lines.Quantity = document.Lines.Quantity;

                                        cn.EDocGenerationType = EDocGenerationTypeEnum.edocNotRelevant;

                                        Text = string.Format("Cancelando documento ({0})", DocEntry);

                                        if (cn.Add() != 0)
                                        {
                                            txtSignDigest.Text += string.Format("Ocurrió un error al cancelar el documento {0}, Error: {1} \n \b", DocEntry, sap.GetLastErrorDescription());
                                        }
                                    }
                                }
                                else
                                {
                                    MessageBox.Show("Inicializacion nula de documento.");
                                }
                            }
                            catch (Exception exc)
                            {
                                txtSignDigest.Text += string.Format("Ocurrió un error al cancelar el documento {0}, Error: {1} \n \b", DocEntry, exc.Message);
                            }
                            oRecordset.MoveNext();
                        }
                    }
                    else
                    {
                        MessageBox.Show("No se obtuvieron resultados.");
                    }
                }
                else
                {
                    MessageBox.Show("El recordset es nulo.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnImportarXML_Click(object sender, EventArgs e)
        {
            try
            {
                FolderBrowserDialog fd = new FolderBrowserDialog();
                DialogResult result = fd.ShowDialog();

                if (result == DialogResult.OK)
                {
                    string[] files = Directory.GetFiles(fd.SelectedPath).Where(p => p.EndsWith(".xml")).ToArray();
                    MessageBox.Show("XML Obtenidos" + files.Count());
                    foreach (var path in files)
                    {
                        XDocument xDoc = XDocument.Load(path);

                        try
                        {
                            XNamespace cfdi = @"http://www.sat.gob.mx/cfd/3";
                            XNamespace tfd = @"http://www.sat.gob.mx/TimbreFiscalDigital";

                            var xdoc = XDocument.Load(path);
                            var timbre = xdoc.Element(cfdi + "Comprobante").Element(cfdi + "Complemento").Element(tfd + "TimbreFiscalDigital");
                            var comprobante = xdoc.Element(cfdi + "Comprobante");

                            string uuid = (string)timbre.Attribute("UUID");
                            string folio = (string)comprobante.Attribute("Folio");

                            ElectronicDocument electronic_document = new ElectronicDocument();

                            Recordset oRecordset = (Recordset)sap.GetBusinessObject(BoObjectTypes.BoRecordset);
                            oRecordset.DoQuery(string.Format("SELECT TOP 1 DocEntry FROM OINV WHERE NumAtCard = '{0}'", folio));

                            int DocEntry = (int)oRecordset.Fields.Item(0).Value;

                            if (DocEntry != 0)
                            {
                                electronic_document.SourceType = "13";
                                electronic_document.SourceObject = DocEntry;
                                electronic_document.ReportID = uuid;
                                electronic_document.ObjectID = DocEntry.ToString();
                                electronic_document.Message = "Documento importado desde SBOElectronicDocumentImporter (Excel XML)";
                                electronic_document.PostingDate = DateTime.Now;
                                electronic_document.SignMsg = string.Empty;
                                electronic_document.SignDigest = string.Empty;

                                if (!ImportElectronicDocument(electronic_document))
                                {
                                    MessageBox.Show(string.Format("No fue posible importar el documento electrónico {0}, Error: {1}", electronic_document.ReportID, sap.GetLastErrorDescription()));
                                }
                            }
                        }
                        catch
                        {
                            //
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
