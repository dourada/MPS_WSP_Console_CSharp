using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MPS_WSP_Console_CSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            var mpsWS = new MPSWebServices.wsSoapClient();
            var xmlRequest = @"<TStream>
                                  <Transaction>
                                      <MerchantID>003503902913105</MerchantID>
                                      <OperatorID>dano</OperatorID>
                                      <TranType>Credit</TranType>
                                      <TranCode>Sale</TranCode>
                                      <Memo>Team1 money2020</Memo>
                                      <InvoiceNo>123456</InvoiceNo>
                                      <RefNo>123456</RefNo>
                                      <Amount>
                                          <Purchase>2.26</Purchase>
                                      </Amount>
                                      <Account>
                                            <AcctNo>5499990123456781</AcctNo>
                                            <ExpDate>0816</ExpDate>
                                            <AccountSource>Keyed</AccountSource>
                                      </Account>
                                  </Transaction>
                                </TStream>";
            Console.WriteLine(xmlRequest);
            Console.WriteLine("");
            Console.WriteLine("");
            var xmlResponse = mpsWS.CreditTransaction(xmlRequest, "xyz");
            Console.WriteLine(xmlResponse);
            Console.WriteLine("");
            Console.WriteLine("");
            Console.ReadLine();
        }
    }
}
