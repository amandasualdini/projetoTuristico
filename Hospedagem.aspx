<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Hospedagem.aspx.cs" Inherits="projetoTuristico.Hospedagem" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder" runat="server">
    <html>
    <body>
        <div>
            <link rel="stylesheet" href="http://code.jquery.com/ui/1.9.0/themes/base/jquery-ui.css" />
            <script src="http://code.jquery.com/jquery-1.8.2.js"></script>
            <script src="http://code.jquery.com/ui/1.9.0/jquery-ui.js"></script>

            <form id="form1" runat="server">
                <article class="kanban-entry grab" id="item1" draggable="true">
                    <div class="kanban-entry-inner">
                        <div class="kanban-label">
                            <h2><a href="#" style="padding:12px">Hospedagem</a> <span></span></h2>
                            <p></p>
                        </div>
                    </div>
                </article>
                <div class="form-group col-md-5">
                    <label for="descricao">Informe o ID da requisição</label>
                    <asp:TextBox class="form-control" ID="TxtIdReq"
                        runat="server" placeholder="Informe o ID da requisição"></asp:TextBox>
                </div>
                <div class="form-group col-md-5">
                    <label for="descricao">Informe a quantidade de diárias</label>
                    <asp:TextBox class="form-control" ID="TxtQtde"
                        runat="server" placeholder="Informe a quantidade de diárias"></asp:TextBox>
                </div>
                <div class="form-group col-md-5">
                    <label for="descricao">Informe o valor</label>
                    <asp:TextBox class="form-control" ID="TxtValor"
                        runat="server" placeholder="Informe o valor"></asp:TextBox>
                </div>
                <div class="form-group col-md-5">
                    <label for="descricao">Informe a moeda</label>
                    <asp:TextBox class="form-control" ID="TxtMoeda"
                        runat="server" placeholder="Informe a moeda"></asp:TextBox>
                </div>
                <div class="form-group col-md-5">
                    <label for="descricao">Informe o total</label>
                    <asp:TextBox class="form-control" ID="TxtTotal"
                        runat="server" placeholder="Informe o total"></asp:TextBox>
                </div>
                <div class="form-group col-md-5">
                    <label for="descricao">Informe o total em Reais</label>
                    <asp:TextBox class="form-control" ID="TxtConvert"
                        runat="server" placeholder="Informe o total em Reais"></asp:TextBox>
                </div>
                <div class="form-group col-md-5">
                    <label for="descricao">Informe a forma de pagamento</label>
                    <asp:TextBox class="form-control" ID="TxtPgto"
                        runat="server" placeholder="Informe a forma de pagamento"></asp:TextBox>
                </div>
                <div class="form-group col-md-5" style="padding:22px"> 
                    <asp:Button class="btn btn-primary" ID="btnCadastrar" runat="server" Text="Salvar"
                        OnClick="btnCadastrar_Click" />
                    <asp:Button class="btn btn-danger" ID="btnCancelar" runat="server" Text="Cancelar"
                        OnClick="btnCancelar_Click" />
                    <br />
                    <% if (!String.IsNullOrEmpty(lblmsg.Text))
                        {%>
                    <div class="alert alert-success">
                        <a href="#" class="close" data-dismiss="alert" aria-label="close">&times;</a>
                        <strong>
                            <asp:Label ID="lblmsg" runat="server" Text=""></asp:Label></strong>
                    </div>
                    <%} %>
                </div>
            </form>
        </div>

    </body>
    </html>
</asp:Content>
