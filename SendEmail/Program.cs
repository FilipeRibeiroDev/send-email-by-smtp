using SendEmail;

var outlook = new Email("smtp.office365.com", "", ENV.PASSWORD);

outlook.SendEmail(
emailsTo: new List<string>
{
    ""
},
subject: "Teste",
body: "Segue Anexo",
attachments: new List<string>
{
    @"C:\temp\excel\Dados.xlsx"
});